using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WeaponAndWizardry
{
    /// <summary>
    /// Module: MainMenu
    /// Description: This page is for Main Menu of the game
    /// Author: 
    ///	 Name: Dongwon(Shawn) Kim   Date: 2017-11-15
    /// Based on:
    ///     https://stackoverflow.com/questions/23976683/asp-net-button-to-redirect-to-another-page
    /// </summary>
    public partial class MainMenu : System.Web.UI.Page
    {

        /// <summary>
        /// When the page is loaded
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// For the New Game
        /// </summary>
        /// <param name="sender">reference of the objec</param>
        /// <param name="e">events arguement</param>
        protected void Button_New_Game_Click(object sender, EventArgs e)
        {
            //Session["_gameover"] = "false";
            Server.Transfer("MainScene.aspx", false);
        }
    }
}