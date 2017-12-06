using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WeaponAndWizardry.Code
{
    /// <summary>
    /// A wrapper to allow safe use of Session variables
    /// </summary>
    public static class SessionHandler
    {
        /// <summary>
        /// Strongly-typed Script Engine string index
        /// </summary>
        private const string _engine = "engine";

        /// <summary>
        /// Strongly-typed Image Display string index
        /// </summary>
        private const string _imageDisplay = "imagedisplay";

        /// <summary>
        /// Strongly-typed Text Display string index
        /// </summary>
        private const string _textDisplay = "textdisplay";

        /// <summary>
        /// Strongly-typed Choice Buttons string index
        /// </summary>
        private const string _choiceButtons = "choicebuttons";
        
        /// <summary>
        /// Strongly-typed Main Scene string index
        /// </summary>
        private const string _mainScene = "mainscene";

        /// <summary>
        /// Strongly-typed Choices picked string index
        /// </summary>
        private const string _choices = "choices";

        /// <summary>
        /// Strongly-typed GUID string index
        /// </summary>
        private const string _guid = "guid";

        /// <summary>
        /// Strongly-typed Stats string index
        /// </summary>
        private const string _stats = "stats";

        /// <summary>
        /// Returns the Session object of type Script Engine
        /// </summary>
        public static WebGameEngine ScriptEngine
        {
            get
            {
                if (HttpContext.Current.Session[_engine] == null)
                {
                    return null;
                }
                else
                {
                    return (WebGameEngine)HttpContext.Current.Session[_engine];
                }
            }
            set
            {
                HttpContext.Current.Session[_engine] = value;
            }
        }

        /// <summary>
        /// Returns the Session object of type Page
        /// This is stores the reference of the main scene
        /// for the script engine to use.
        /// </summary>
        public static Page MainScene
        {
            get
            {
                if (HttpContext.Current.Session[_mainScene] == null)
                {
                    return null;
                }
                else
                {
                    return (Page)HttpContext.Current.Session[_mainScene];
                }
            }
            set
            {
                HttpContext.Current.Session[_mainScene] = value;
            }
        }

        /// <summary>
        /// Returns the Session object of type Panel
        /// Which is the container for image display
        /// </summary>
        public static Panel ImageDisplay
        {
            get
            {
                if (HttpContext.Current.Session[_imageDisplay] == null)
                {
                    HttpContext.Current.Session[_imageDisplay] = new Panel();
                }
                return (Panel)HttpContext.Current.Session[_imageDisplay];
            }
            set
            {
                HttpContext.Current.Session[_imageDisplay] = value;
            }
        }

        /// <summary>
        /// Returns the Session object of type string
        /// Which is the text data for text display
        /// </summary>
        public static string TextDisplay
        {
            get
            {
                if (HttpContext.Current.Session[_textDisplay] == null)
                {
                    return null; //If we return empty string instead, the user may think an empty string was initially assigned
                }
                else
                {
                    return (string)HttpContext.Current.Session[_textDisplay];
                }
            }
            set
            {
                HttpContext.Current.Session[_textDisplay] = value;
            }
        }

        /// <summary>
        /// Returns the Session object of type string[]
        /// Which is the text data for each choice button
        /// </summary>
        public static string[] ChoiceButtons
        {
            get
            {
                if (HttpContext.Current.Session[_choiceButtons] == null)
                {
                    HttpContext.Current.Session[_choiceButtons] = new string[4];
                }
                return (string[])HttpContext.Current.Session[_choiceButtons];
            }
            set
            {
                HttpContext.Current.Session[_choiceButtons] = value;
            }
        }

        /// <summary>
        /// Returns the Session object of type string[]
        /// Which is the text data for each Stat
        /// </summary>
        public static string[] Stats
        {
            get
            {
                if (HttpContext.Current.Session[_stats] == null)
                {
                    HttpContext.Current.Session[_stats] = new string[7];
                }
                return (string[])HttpContext.Current.Session[_stats];
            }
            set
            {
                HttpContext.Current.Session[_stats] = value;
            }
        }

        /// <summary>
        /// Returns the Session object of type List<int>
        /// Which is the unsigned int data for each choice 
        /// picked by the player previously
        /// </summary>
        public static List<uint> ChoicesPicked
        {
            get
            {
                if (HttpContext.Current.Session[_choices] == null)
                {
                    HttpContext.Current.Session[_choices] = new List<uint>();
                }
                return (List<uint>)HttpContext.Current.Session[_choices];
            }
            set
            {
                HttpContext.Current.Session[_choices] = value;
            }
        }

        /// <summary>
        /// Returns the Session object of type Guid
        /// </summary>
        public static Guid Guid
        {
            get
            {
                if (HttpContext.Current.Session[_guid] == null)
                {
                    return Guid.Empty;
                }
                else
                {
                    return (Guid)HttpContext.Current.Session[_guid];
                }
            }
            set
            {
                HttpContext.Current.Session[_guid] = value;
            }
        }

        /// <summary>
        /// Saves the GUI State to Session Variables
        /// </summary>
        /// <param name="imageDisplay">The panel control state to save</param>
        public static void SaveGuiState(Panel imageDisplay, string textDisplay, List<Button> buttons, List<Label> stats)
        {
            //TODO: Cleanup save state to require only the page
            ImageDisplay.Controls.Clear();
            foreach (Image image in imageDisplay.Controls)
            {
                ImageDisplay.Controls.Add(Utility.CopyImage(image));
            }

            TextDisplay = textDisplay;

            for (int i = 0; i < buttons.Count; i++)
            {
                ChoiceButtons[i] = buttons[i].Text;
            }

            for (int i = 0; i < stats.Count; i++)
            {
                Stats[i] = stats[i].Text;
            }
        }

        /// <summary>
        /// Restores the Session state back to the GUI
        /// </summary>
        /// <param name="imageDisplay">The panel control to retore image GUI to</param>
        /// <param name="textDisplay">The control for displaying text</param>
        /// <param name="buttons">The controls for the buttons</param>
        /// <param name="stats">The controls for the stats</param>
        public static void RestoreGuiState(Panel imageDisplay, TextBox textDisplay, List<Button> buttons, List<Label> stats)
        {
            imageDisplay.Controls.Clear();
            foreach (Image image in ImageDisplay.Controls)
            {
                imageDisplay.Controls.Add(Utility.CopyImage(image));
            }

            textDisplay.Text = TextDisplay;

            for (int i = 0; i < ChoiceButtons.Length; i++)
            {
                buttons[i].Text = ChoiceButtons[i];
            }
            for (int i = 0; i < Stats.Length; i++)
            {
                stats[i].Text = Stats[i];
            }
        }

        /// <summary>
        /// Clears all session data
        /// </summary>
        public static void ClearSession()
        {
            HttpContext.Current.Session.Clear();
        }
    }
}