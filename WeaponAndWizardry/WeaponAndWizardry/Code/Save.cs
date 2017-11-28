using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WeaponAndWizardry.Code
{
    /// <summary>
    /// Represents a save file for serialization
    /// </summary>
    public class Save
    {
        public Guid Id { get; set; }

        public List<uint> ChoicesPicked { get; set; }

        public Save(Guid id, List<uint> choicesPicked)
        {
            if (id == null || id == Guid.Empty)
            {
                Id = Guid.NewGuid();
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