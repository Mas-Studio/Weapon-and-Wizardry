using System;
using System.IO;
using Newtonsoft.Json;
using System.Linq;
using WeaponAndWizardry.Code;

/// <summary>
/// Module: MainMenu
/// Description: This page is for Loading the save data of the game
/// Author:
///	 Name: Dongwon(Shawn) Kim   Date: 2017-11-27
///	Modified:
///  Name: Jia Qi Lee           Date: 2017-12-05
/// Based on:
///    http://www.dotnetcurry.com/aspnet/89/aspnet-redirect-go-back-to-previous-page

/// </summary>
namespace WeaponAndWizardry
{
    public partial class LoadGame : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Session["referrer"] = Request.UrlReferrer.ToString();
            }
        }

        protected void Button_Load_Back_Click(object sender, EventArgs e)
        {
            Response.Redirect((string)Session["referrer"]);
        }

        protected void Button_Load_Game_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(TextBox_SaveDataCode.Text))
            {
                ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('Your Save Game Cannot Be Found! Please Make Sure Your Password Is Correct!');", true);
                return;
            }
            try
            {
                SessionHandler.SaveId = TextBox_SaveDataCode.Text;
                string[] filesPath = Directory.GetFiles(Utility.PlayerSaveDataUrl, SessionHandler.SaveId);
                for (int i = 0; i < filesPath.Length; i++)
                {
                    if (Path.GetFileName(filesPath[i]).Equals(SessionHandler.SaveId))
                    {
                        string savedata = File.ReadAllText(filesPath[i]);
                        Save savefile = JsonConvert.DeserializeObject<Save>(savedata);
                        SessionHandler.Loading = true;
                        SessionHandler.SaveFile = savefile;
                        Response.Redirect("MainScene.aspx");
                        return;
                    }
                }
            }
            catch (Exception ex)
            {
            }
            ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('Your Save Game Cannot Be Found! Please Make Sure Your Password Is Correct!');", true);
        }
    }
}