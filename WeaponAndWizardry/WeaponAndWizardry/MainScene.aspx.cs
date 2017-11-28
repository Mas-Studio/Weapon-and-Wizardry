using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WeaponAndWizardry.Code;

namespace WeaponAndWizardry
{
    /// <summary>
    /// Module: MainScene
    /// Description: This page is for Main Scene of the game
    /// Author:
    ///	 Name: Dongwon(Shawn) Kim   Date: 2017-11-15
    ///	 Name: George Lee           Date: 2017-11-20
    /// Based on:
    ///     https://stackoverflow.com/questions/23976683/asp-net-button-to-redirect-to-another-page
    /// </summary>
    public partial class MainScene : Page
    {
        /// <summary>
        /// When the page is loaded
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {
            Page.Title = "MA's Weapon & Wizardry";
            List<Button> choiceButtons = new List<Button> { ButtonChoice1, ButtonChoice2, ButtonChoice3, ButtonChoice4 };
            List<Label> stats = new List<Label> { Label_HP, Label_Str, Label_Dex, Label_Int, Label_Luck, Label_Alignment, Label_Gold };
            // check the postback and session handler of script engine is null
            if (!IsPostBack && SessionHandler.ScriptEngine == null)
            {
                // if it is, assign new game

                SessionHandler.ScriptEngine = new WebGameEngine(ImageDisplay, TextDisplay, choiceButtons, stats);
                SessionHandler.ScriptEngine.ExecuteLine(0);
                SessionHandler.SaveGuiState(ImageDisplay, TextDisplay.Text, choiceButtons, stats);
            }
            else
            {
                SessionHandler.RestoreGuiState(ImageDisplay, TextDisplay, choiceButtons, stats);
                SessionHandler.ScriptEngine.UpdateReferences(ImageDisplay, TextDisplay, choiceButtons, stats);
            }
            SessionHandler.MainScene = this;

           
        }

        /// <summary>
        /// Handles all choice buttons
        /// </summary>
        /// <param name="sender">The button clicked</param>
        /// <param name="e">events arguement</param>
        protected void ButtonChoice_Clicked(object sender, EventArgs e)
        {
            List<Button> choiceButtons = new List<Button> { ButtonChoice1, ButtonChoice2, ButtonChoice3, ButtonChoice4 };
            List<Label> stats = new List<Label> { Label_HP, Label_Str, Label_Dex, Label_Int, Label_Luck };
            Button button = (Button)sender;
            string choice = new string(button.ID.Last(), 1);
            SessionHandler.ScriptEngine.ExecuteLine(uint.Parse(choice));
            SessionHandler.SaveGuiState(ImageDisplay, TextDisplay.Text, choiceButtons, stats);
        }

        /// <summary>
        /// Quit the game
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Button_Quit_Click(object sender, EventArgs e)
        {
            SessionHandler.ScriptEngine.QuitGame(this);
        }

        /// <summary>
        /// Saves the game
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Button_Save_Click(object sender, EventArgs e)
        {
            Session["save"] = SessionHandler.ScriptEngine.SaveGame();
            string save = Newtonsoft.Json.JsonConvert.SerializeObject(Session["save"]);
            System.IO.File.WriteAllText("c:\\save.txt", save); // Do database save
        }

        /// <summary>
        /// Loads the game
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Button_Load_Click(object sender, EventArgs e)
        {
            string save = System.IO.File.ReadAllText("c:\\save.txt", System.Text.Encoding.ASCII); // Do database load
            Save s = Newtonsoft.Json.JsonConvert.DeserializeObject<Save>(save);
            SessionHandler.ScriptEngine.LoadGame(s);
            //Response.Redirect("~/LoadGame.aspx");
        }
        
    }
}