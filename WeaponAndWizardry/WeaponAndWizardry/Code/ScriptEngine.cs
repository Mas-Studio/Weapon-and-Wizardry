using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI.WebControls;

namespace WeaponAndWizardry.Code
{
    /// <summary>
    /// Core class that handles logic of game workflow
    /// for ASP.NET webforms.
    /// Handles execution of scenario scripts.
    /// Exposes API for Script class to use.
    /// </summary>
    public partial class WebGameEngine
    {
        private int _currentExecutingLine;
        private Panel _imageDisplay;
        private TextBox _textDisplay;
        private List<ScriptLine> _scriptLines;
        private List<Button> _choiceButtons;
        private uint _choicePicked;
        private Image _currentBackgroundImage;
        private List<Image> _currentForegroundImages;
        private List<Label> _stats;
                
        private delegate void ScriptLine();

        #region Properties
        /// <summary>
        /// Gets or Sets the HP stat of the character
        /// </summary>
        public int HP
        {            
            get
            {
                foreach (Label label in _stats)
                {
                    if (label.Text.Contains("HP"))
                    {
                        return Int32.Parse(label.Text.Substring(4));
                    }
                }
                return 0;
            }
            set
            {
                foreach (Label label in _stats)
                {
                    if (label.Text.Contains("HP"))
                    {
                        label.Text = "HP: " + value;
                    }
                }
            }
        }

        /// <summary>
        /// Gets or Sets the Strength stat of the character
        /// </summary>
        public Strength Str
        {
            get
            {
                foreach (Label label in _stats)
                {
                    if (label.Text.Contains("Str"))
                    {
                        return (Strength)Enum.Parse(typeof(Strength), label.Text.Substring(4));
                    }
                }
                return 0;
            }
            set
            {
                foreach (Label label in _stats)
                {
                    if (label.Text.Contains("Str"))
                    {
                        if (value > Strength.Herculean)
                        {
                            value = Strength.Herculean;
                        }
                        if (value < Strength.Pitiful)
                        {
                            value = Strength.Pitiful;
                        }
                        label.Text = "Str: " + value;
                    }
                }
            }
        }

        /// <summary>
        /// Gets or Sets the Dexterity stat of the character
        /// </summary>
        public Dexterity Dex
        {
            get
            {
                foreach (Label label in _stats)
                {
                    if (label.Text.Contains("Dex"))
                    {
                        return (Dexterity)Enum.Parse(typeof(Dexterity),label.Text.Substring(4));
                    }
                }
                return 0;
            }
            set
            {
                foreach (Label label in _stats)
                {
                    if (label.Text.Contains("Dex"))
                    {
                        if(value > Dexterity.Agile)
                        {
                            value = Dexterity.Agile;
                        }
                        if(value < Dexterity.Uncoordinated)
                        {
                            value = Dexterity.Uncoordinated;
                        }
                        label.Text = "Dex: " + value;
                    }
                }
            }
        }

        /// <summary>
        /// Gets or Sets the Intelligence stat of the character
        /// </summary>
        public Intelligence Int
        {
            get
            {
                foreach (Label label in _stats)
                {
                    if (label.Text.Contains("Int"))
                    {
                        return (Intelligence)Enum.Parse(typeof(Intelligence),label.Text.Substring(4));
                    }
                }
                return 0;
            }
            set
            {
                foreach (Label label in _stats)
                {
                    if (label.Text.Contains("Int"))
                    {
                        if (value > Intelligence.Enlightened)
                        {
                            value = Intelligence.Enlightened;
                        }
                        if (value < Intelligence.Dumb)
                        {
                            value = Intelligence.Dumb;
                        }
                        label.Text = "Int: " + value;
                    }
                }
            }
        }

        /// <summary>
        /// Gets or Sets the Luck stat of the character
        /// </summary>
        public Luck Luk
        {
            get
            {
                foreach (Label label in _stats)
                {
                    if (label.Text.Contains("Luk"))
                    {
                        return (Luck)Enum.Parse(typeof(Luck),label.Text.Substring(4));
                    }
                }
                return 0;
            }
            set
            {
                foreach (Label label in _stats)
                {
                    if (label.Text.Contains("Luk"))
                    {
                        if (value > Luck.Blessed)
                        {
                            value = Luck.Blessed;
                        }
                        if (value < Luck.Jinxed)
                        {
                            value = Luck.Jinxed;
                        }
                        label.Text = "Luk: " + value;
                    }
                }
            }
        }

        public Alignment Align
        {
            get
            {
                foreach (Label label in _stats)
                {
                    if (label.Text.Contains("Alignment"))
                    {
                        return (Alignment)Enum.Parse(typeof(Alignment),label.Text.Substring(10));
                    }
                }
                return 0;
            }
            set
            {
                foreach (Label label in _stats)
                {
                    if (label.Text.Contains("Alignment"))
                    {
                        if (value > Alignment.Adored)
                        {
                            value = Alignment.Adored;
                        }
                        if (value < Alignment.Wicked)
                        {
                            value = Alignment.Wicked;
                        }
                        label.Text = "Alignment: " + value;
                    }
                }
            }
        }

        public int Gold
        {
            get
            {
                foreach (Label label in _stats)
                {
                    if (label.Text.Contains("Gold"))
                    {
                        return Int32.Parse(label.Text.Substring(5));
                    }
                }
                return 0;
            }
            set
            {
                foreach (Label label in _stats)
                {
                    if (label.Text.Contains("Gold"))
                    {
                        label.Text = "Gold: " + value;
                    }
                }
            }
        }

        #endregion Properties

        /// <summary>
        /// Instantiates an instance of the ScriptEngine
        /// Requires a page as a parameter for interacting with the Page.
        /// Scripts are run in the sequential order starting from the
        /// first index in the collection.
        /// </summary>
        /// <param name="gui"></param>
        public WebGameEngine(Panel imageDisplay, TextBox textDisplay, List<Button> choiceButtons, List<Label> stats)
        {
            _currentExecutingLine = 0;
            _imageDisplay = imageDisplay;
            _textDisplay = textDisplay;
            _scriptLines = new List<ScriptLine>();
            _currentForegroundImages = new List<Image>();
            _choiceButtons = choiceButtons;
            _currentBackgroundImage = null;
            _stats = stats;
            LoadScripts();            
        }        

        /// <summary>
        /// Updates the references to the GUI controls.
        /// Used when a the html page is refreshed and the reference to the new
        /// controls is needed
        /// </summary>
        /// <param name="imageDisplay">The new panel to refer to</param>
        /// <param name="textDisplay">The new text box to refer to</param>
        /// <param name="choiceButtons">The buttons to refer to</param>
        public void UpdateReferences(Panel imageDisplay, TextBox textDisplay, List<Button> choiceButtons, List<Label> stats)
        {
            _imageDisplay = imageDisplay;
            _textDisplay = textDisplay;
            _choiceButtons = choiceButtons;
            _stats = stats;
        }

        /// <summary>
        /// Execute the next line of the script loaded
        /// </summary>
        /// <param name="choicePicked">The user choice picked in the previous line</param>
        public void ExecuteLine(uint choicePicked)
        {
            _choicePicked = choicePicked;
            SessionHandler.ChoicesPicked.Add(_choicePicked);
            _scriptLines[_currentExecutingLine].Invoke();
        }

        /// <summary>
        /// Saves the game into a serializable Save object
        /// </summary>
        public Save SaveGame()
        {
            Save save = new Save(SessionHandler.Guid, SessionHandler.ChoicesPicked);
            return save;
        }

        /// <summary>
        /// Loads the game from a serializable Save object
        /// </summary>
        public void LoadGame(Save save)
        {
            SessionHandler.ChoicesPicked.Clear();
            _textDisplay.Text = "";
            _currentExecutingLine = 0;
            _currentForegroundImages = new List<Image>();
            _currentBackgroundImage = null;
            foreach (uint choice in save.ChoicesPicked)
            {
                ExecuteLine(choice);
            }
        }

        /// <summary>
        /// Returns the user to the main menu
        /// </summary>
        public void QuitGame(System.Web.UI.Page page)
        {
            SessionHandler.ClearSession();
            page.Server.Transfer("MainMenu.aspx", false);
        }

        #region Script API methods

        /// <summary>
        /// Outputs text to the Text Display
        /// </summary>
        /// <param name="message">The string message to output</param>
        public void PrintTextDialogue(string message)
        {
            message = "\n\n" + message;
            _textDisplay.Text += message;
        }

        /// <summary>
        /// Outputs text to the Text Display with a new line appended
        /// </summary>
        /// <param name="message">The string message to output</param>
        public void PrintLineTextDialogue(string message)
        {
            _textDisplay.Text += message + "\n";
        }

        /// <summary>
        /// Sets the choice button text labels in the GUI
        /// </summary>
        /// <param name="choices">The choices to give to the user</param>
        public void SetChoiceButtons(Choices choices)
        {
            for (int i = 0; i < _choiceButtons.Count; i++)
            {
                _choiceButtons[i].Enabled = true;
                _choiceButtons[i].Text = choices.Collection[i];
                if (String.IsNullOrWhiteSpace(_choiceButtons[i].Text))
                {
                    _choiceButtons[i].Enabled = false;
                }
            }
        }

        /// <summary>
        /// Clears the image display
        /// </summary>
        public void ClearImageDisplay()
        {
            _imageDisplay.Controls.Clear();
            _currentBackgroundImage = null;
            _currentForegroundImages.Clear();
        }

        /// <summary>
        /// Clears all foreground images in the image display
        /// </summary>
        public void ClearForegroundImages()
        {
            for (int i = 0; i < _imageDisplay.Controls.Count; i++)
            {
                if (_imageDisplay.Controls[i] is Image)
                {
                    foreach (Image image in _currentForegroundImages)
                    {
                        if (image.ImageUrl == ((Image)_imageDisplay.Controls[i]).ImageUrl)
                        {
                            _imageDisplay.Controls.RemoveAt(i);
                            i--;
                        }
                    }
                }
            }
            _currentForegroundImages.Clear();
        }

        /// <summary>
        /// Sets the backgroud image of the image display,
        /// replacing the previous background image.
        /// The image file needs to be in the ~/Content/images/backgrounds/ folder.
        /// </summary>
        /// <param name="imageFileName">The filename of the image to set.</param>
        public void SetBackgroundImage(string imageFileName)
        {
            for (int i = 0; i < _imageDisplay.Controls.Count; i++)
            {
                if (_imageDisplay.Controls[i] is Image)
                {
                    if (_currentBackgroundImage.ImageUrl == ((Image)_imageDisplay.Controls[i]).ImageUrl)
                    {
                        _imageDisplay.Controls.RemoveAt(i);
                        break;
                    }
                }
            }
            Image image = new Image();
            image.Style["position"] = "absolute";
            image.Style["z-index"] = "0";
            image.Style["left"] = "0px";
            image.Style["top"] = "0px";
            image.Width = 800;
            image.Height = 600;
            image.ImageUrl = "~/Content/images/backgrounds/" + imageFileName;
            _currentBackgroundImage = image;
            _imageDisplay.Controls.Add(_currentBackgroundImage);
        }

        /// <summary>
        /// Adds a foreground image to the image display
        /// May display foreground multiple images by calling this method more than once.
        /// The image file needs to be in the ~/Content/images/characters/ folder.
        /// </summary>
        /// <param name="url">The url of the image file</param>
        /// <param name="xPos">the x position of where the image should be placed in the image display</param>
        /// <param name="yPos">the y position of where the image should be placed in the image display</param>
        /// <param name="zPos">the z position of where the image should be placed in the image display</param>
        /// <param name="width">the desired width size of the image</param>
        /// <param name="height">the desired height size of the image</param>
        public void AddForegroundImage(string url, int xPos, int yPos, int zPos, int width, int height)
        {
            Image image = new Image();
            image.Style["position"] = "absolute";
            image.Style["z-index"] = zPos.ToString();
            image.Style["left"] = xPos.ToString() + "px";
            image.Style["top"] = yPos.ToString() + "px";
            image.Width = width;
            image.Height = height;
            image.ImageUrl = "~/Content/images/characters/" + url;
            _currentForegroundImages.Add(image);
            _imageDisplay.Controls.Add(image);
        }

        #endregion Script API methods
    }
}