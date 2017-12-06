using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WeaponAndWizardry.Code
{
    /// <summary>
    /// Contains a collection of choices used in Script API
    /// </summary>
    public class Choices
    {
        public string[] Collection { get; set; }

        /// <summary>
        /// Creates an instance of this class. 
        /// Default value is empty string which would result
        /// in the Button to be disabled for that choice
        /// </summary>
        /// <param name="choice1">String value to display to the user for choice 1</param>
        /// <param name="choice2">String value to display to the user for choice 2</param>
        /// <param name="choice3">String value to display to the user for choice 3</param>
        /// <param name="choice4">String value to display to the user for choice 4</param>
        public Choices (string choice1 = "", string choice2 = "", string choice3 = "", string choice4 = "")
        {
            Collection = new string[4] { choice1, choice2, choice3, choice4 };
        }
    }
}