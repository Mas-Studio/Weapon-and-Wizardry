using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WeaponAndWizardry.App_Code;

namespace WeaponAndWizardry
{
    /// <summary>
    /// Module: MainScene
    /// Description: This page is for Main Scene of the game
    /// Author: 
    ///	 Name: Dongwon(Shawn) Kim   Date: 2017-11-15
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
            // check the postback and session handler of script engine is null
            if (!IsPostBack && SessionHandler.ScriptEngine == null)
            {
                // if it is, assign new game
                SessionHandler.ScriptEngine = new ScriptEngine(ImageDisplay, TextDisplay, new List<Button> { ButtonChoice1, ButtonChoice2, ButtonChoice3, ButtonChoice4 });
                SessionHandler.ScriptEngine.ExecuteLine(0);
                SessionHandler.SaveGuiState(ImageDisplay, TextDisplay.Text, new List<Button> { ButtonChoice1, ButtonChoice2, ButtonChoice3, ButtonChoice4 });
            }
            else
            {
                //if(Session["_gameover"] != null)
                //    try
                //    {
                //        if (((string)Session["_gameover"]).Equals("true"))
                //        {
                //            Server.Transfer("MainMenu.aspx", true);
                //        }

                //    } catch (Exception ex)
                //    {

                //    }

                // if not check it is game over and restore the previouse scene
                SessionHandler.RestoreGuiState(ImageDisplay, TextDisplay, new List<Button> { ButtonChoice1, ButtonChoice2, ButtonChoice3, ButtonChoice4 });
                SessionHandler.ScriptEngine.UpdateReferences(ImageDisplay, TextDisplay, new List<Button> { ButtonChoice1, ButtonChoice2, ButtonChoice3, ButtonChoice4 });
            }
            SessionHandler.MainScene = this;
        }

        /// <summary>
        /// For the first choice
        /// </summary>
        /// <param name="sender">reference of the objec</param>
        /// <param name="e">events arguement</param>
        protected void ButtonChoice1_Click(object sender, EventArgs e)
        {
            SessionHandler.ScriptEngine.ExecuteLine(1);
            SessionHandler.SaveGuiState(ImageDisplay, TextDisplay.Text, new List<Button> { ButtonChoice1, ButtonChoice2, ButtonChoice3, ButtonChoice4 });
        }


        /// <summary>
        /// For the second choice
        /// </summary>
        /// <param name="sender">reference of the objec</param>
        /// <param name="e">events arguement</param>
        protected void ButtonChoice2_Click(object sender, EventArgs e)
        {
            SessionHandler.ScriptEngine.ExecuteLine(2);
            SessionHandler.SaveGuiState(ImageDisplay, TextDisplay.Text, new List<Button> { ButtonChoice1, ButtonChoice2, ButtonChoice3, ButtonChoice4 });
        }

        /// <summary>
        /// For the third choice
        /// </summary>
        /// <param name="sender">reference of the objec</param>
        /// <param name="e">events arguement</param>
        protected void ButtonChoice3_Click(object sender, EventArgs e)
        {
            SessionHandler.ScriptEngine.ExecuteLine(3);
            SessionHandler.SaveGuiState(ImageDisplay, TextDisplay.Text, new List<Button> { ButtonChoice1, ButtonChoice2, ButtonChoice3, ButtonChoice4 });
        }

        /// <summary>
        /// For the forth choice
        /// </summary>
        /// <param name="sender">reference of the objec</param>
        /// <param name="e">events arguement</param>
        protected void ButtonChoice4_Click(object sender, EventArgs e)
        {
            SessionHandler.ScriptEngine.ExecuteLine(4);
            SessionHandler.SaveGuiState(ImageDisplay, TextDisplay.Text, new List<Button> { ButtonChoice1, ButtonChoice2, ButtonChoice3, ButtonChoice4 });
        }

        /// <summary>
        /// Quit the game
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Button_Back_Click(object sender, EventArgs e)
        {
            SessionHandler.ScriptEngine.QuitGame();
        }
    }
}