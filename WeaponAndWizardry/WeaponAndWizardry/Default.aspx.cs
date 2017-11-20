using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WeaponAndWizardry.App_Code;

namespace WeaponAndWizardry
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack && SessionHandler.ScriptEngine == null)
            {
                SessionHandler.ScriptEngine = new ScriptEngine(ImageDisplay, TextDisplay, new List<Button> { ButtonChoice1, ButtonChoice2, ButtonChoice3, ButtonChoice4 });
                SessionHandler.ScriptEngine.ExecuteLine(0);
                SessionHandler.SaveGuiState(ImageDisplay, TextDisplay.Text, new List<Button> { ButtonChoice1, ButtonChoice2, ButtonChoice3, ButtonChoice4 });
            }
            else
            {
                SessionHandler.RestoreGuiState(ImageDisplay, TextDisplay, new List<Button> { ButtonChoice1, ButtonChoice2, ButtonChoice3, ButtonChoice4 });
                SessionHandler.ScriptEngine.UpdateReferences(ImageDisplay, TextDisplay, new List<Button> { ButtonChoice1, ButtonChoice2, ButtonChoice3, ButtonChoice4 });
            }
        }

        protected void ButtonChoice1_Click(object sender, EventArgs e)
        {
            SessionHandler.ScriptEngine.ExecuteLine(1);
            SessionHandler.SaveGuiState(ImageDisplay, TextDisplay.Text, new List<Button> { ButtonChoice1, ButtonChoice2, ButtonChoice3, ButtonChoice4 });
        }

        protected void ButtonChoice2_Click(object sender, EventArgs e)
        {
            SessionHandler.ScriptEngine.ExecuteLine(2);
            SessionHandler.SaveGuiState(ImageDisplay, TextDisplay.Text, new List<Button> { ButtonChoice1, ButtonChoice2, ButtonChoice3, ButtonChoice4 });
        }

        protected void ButtonChoice3_Click(object sender, EventArgs e)
        {
            SessionHandler.ScriptEngine.ExecuteLine(3);
            SessionHandler.SaveGuiState(ImageDisplay, TextDisplay.Text, new List<Button> { ButtonChoice1, ButtonChoice2, ButtonChoice3, ButtonChoice4 });
        }

        protected void ButtonChoice4_Click(object sender, EventArgs e)
        {
            SessionHandler.ScriptEngine.ExecuteLine(4);
            SessionHandler.SaveGuiState(ImageDisplay, TextDisplay.Text, new List<Button> { ButtonChoice1, ButtonChoice2, ButtonChoice3, ButtonChoice4 });
        }
    }
}