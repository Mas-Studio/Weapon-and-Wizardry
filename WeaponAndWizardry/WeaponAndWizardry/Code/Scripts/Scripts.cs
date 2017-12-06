using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WeaponAndWizardry.Code
{
    /// <summary>
    /// Represents a script scenario that uses ScriptEngine API
    /// to dictate the game flow.
    /// </summary>
    public partial class WebGameEngine
    {
        static Choices nextChoice = new Choices("Next");

        private void LoadScripts()
        {
            LoadPrologueScripts();
        }



    }
}