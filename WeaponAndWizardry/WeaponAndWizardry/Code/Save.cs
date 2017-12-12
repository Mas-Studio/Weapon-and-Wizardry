using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WeaponAndWizardry.Code
{
    /// <summary>
    /// Represents a save file for serialization
    /// Author:
    ///     Name: Jia Qi Lee (George) Date: 2017-11-15
    /// </summary>
    public class Save
    {
        /// <summary>
        /// The GUID for this data
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or sets the list of choices picked in this data
        /// </summary>
        public List<uint> ChoicesPicked { get; set; }

        /// <summary>
        /// Creates a new save data
        /// </summary>
        /// <param name="id">the GUID for the data</param>
        /// <param name="choicesPicked">the list of choices picked so far by the player</param>
        public Save(Guid id, List<uint> choicesPicked)
        {
            if (id == null || id == Guid.Empty)
            {
                Id = Guid.NewGuid();
            }
            else
            {
                Id = id;
            }
            ChoicesPicked = new List<uint>();
            if (choicesPicked.Count > 0)
            {
                foreach (uint choice in choicesPicked)
                {
                    ChoicesPicked.Add(choice);
                }
            }
        }
    }
}