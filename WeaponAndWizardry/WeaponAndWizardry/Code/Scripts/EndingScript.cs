﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WeaponAndWizardry.Code
{
    /// <summary>
    /// Module: WebGameEngine
    /// Description: Container for ending scripts which tell the engine 
    /// what order the instructions should go in.
    /// Author: Steven Ma			Date: 2017-11-30 
    /// </summary>
    public partial class WebGameEngine
    {
        /// <summary>
        /// Region containing a method for loading the scripts needed.
        /// </summary>

        #region Script Load
        public void LoadEndingScript()
        {
            _scriptLines.Add(EndingLine1);

        }

        #endregion

        /// <summary>
        /// Region containing the script methods, each containing what's needed for the next
        /// line of dialogue.
        /// </summary>

        #region Scripts

        private void EndingLine1()
        {
            ClearImageDisplay();
            //SetBackgroundImage("gameover.png");
            SetChoiceButtons(nextChoice);
            PrintTextDialogue("Suddenly a flash of light blinds your eyes.\n"+
                "You've felt this sensation before.");
            //QuitGame();
        }

        private void EndingLine2()
        {
            ClearImageDisplay();
            SetBackgroundImage("01.png");
            AddForegroundImage("Ilias_neutral.png", 100, 20, 12, 640, 480);
            SetChoiceButtons(nextChoice);
            PrintTextDialogue("\"Hello user, thank you for participating in this version of Weapons and Wizardry.\n" +
                "We hoped you enjoyed a taste of what Group 7 can offer.\"");
            _currentExecutingLine++;
        }

        private void EndingLine3()
        {
            ClearForegroundImages();
            AddForegroundImage("Ilias_closed1.png", 100, 20, 12, 640, 480);
            SetChoiceButtons(nextChoice);
            PrintTextDialogue("\"Unforutnately, the deadline for this project has come to a close.\n"+
                "This means that the story portion remains unfinished.\n"+
                "Perhaps someday, we will be able to add more content to this project.\"");
            _currentExecutingLine++;
        }

        private void EndingLine4()
        {
            ClearForegroundImages();
            AddForegroundImage("Ilias_neutral.png", 100, 20, 12, 640, 480);
            SetChoiceButtons(nextChoice);
            PrintTextDialogue("\"If you had a good experience so far, please comment in the following survey provided by one of the developers.\n" +
                "Project Lead: George Lee\nStory Designer: Steven Ma\nGame Visuals Designer: Shawn Kim\"");
            _currentExecutingLine++;
        }

        private void EndingLine5()
        {
            ClearForegroundImages();
            AddForegroundImage("Ilias_happy.png", 100, 20, 12, 640, 480);
            SetChoiceButtons(new Choices("Princess Melty", "Hero Motaire", "Royal escort Isis", "Other"));
            PrintTextDialogue("\"Before we end off, I would like to show you just a glimpse of one of the possible endings to this game as a thank you.\"");
            PrintTextDialogue("\"Please select a character ending you wish to view.\"");
            _currentExecutingLine++;
        }

        private void EndingLine6()
        {
            SetChoiceButtons(new Choices("Princess Melty", "Hero Motaire", "Royal escort Isis", "Other"));
            PrintTextDialogue("\"Please select a character ending you wish to view.\"");
            _currentExecutingLine++;
        }


        private void EndingLine7()
        {
            switch (_choicePicked)
            {
                case 1:
                    PrintTextDialogue("\"Excellent choice. I'm sure you and the princess will be happy.\"");
                    SetChoiceButtons(nextChoice);
                    _currentExecutingLine = _currentExecutingLine + 3;
                    break;
                case 2:
                    PrintTextDialogue("\"A sucker for the hero-types, huh?\n"+
                        "Many blessings upon you.\"");
                    SetChoiceButtons(nextChoice);
                    _currentExecutingLine++;
                    break;
                case 3:
                    PrintTextDialogue("\"A beautiful rose, has thorns does it not?\n"+
                        "Enjoy your life together, hero.\"");
                    SetChoiceButtons(nextChoice);
                    _currentExecutingLine++;
                    break;
                case 4:
                    PrintTextDialogue("\"Hmm? Is there another you wish to view?\"");
                    SetChoiceButtons(nextChoice);
                    _currentExecutingLine++;
                    break;
            }
        }

        private void EndingLine8()
        {
            PrintTextDialogue("\"Please select a character ending you wish to view.\"");
            SetChoiceButtons(new Choices("Court Wizard Albus", "You", "Monster Queen Alice", "Back"));
            _currentExecutingLine++;
        }

        private void EndingLine9()
        {
            switch (_choicePicked)
            {
                case 1:
                    PrintTextDialogue("\"A wizard with a destiny for greatness.\n"+
                        "You've chosen well.\"");
                    SetChoiceButtons(nextChoice);
                    _currentExecutingLine++;
                    break;
                case 2:
                    PrintTextDialogue("\"As you wish. I...\"");
                    SetChoiceButtons(nextChoice);
                    _currentExecutingLine++;
                    break;
                case 3:
                    PrintTextDialogue("\"My, my. What a greedy hero I've raised.\"");
                    SetChoiceButtons(nextChoice);
                    _currentExecutingLine++;
                    break;
                case 4:
                    PrintTextDialogue("\"My, my. What a greedy hero I've raised.\"");
                    SetChoiceButtons(nextChoice);
                    _currentExecutingLine = _currentExecutingLine - 3;
                    break;
            }
        }

        private void EndingLine10()
        {
            ClearImageDisplay();
            SetBackgroundImage("11.png");
            PrintLineTextDialogue("You awake in your royal styled chambers.\n"+
                "It has been several weeks since you saved the kingdom from calamity.\n"+
                "Since then, you've been crowned a hero of the era.");
            SetChoiceButtons(nextChoice);
            _currentExecutingLine++;
        }

        private void EndingLine11()
        {
            PrintLineTextDialogue("This of course came with castles, money and everything you could ever hope for.");
            SetChoiceButtons(nextChoice);
            _currentExecutingLine++;
        }

        private void EndingLine12()
        {
            PrintLineTextDialogue("This of course came with castles, money and everything you could ever hope for.");
            SetChoiceButtons(nextChoice);
            _currentExecutingLine++;
        }

        private void EndingLine13()
        {
            PrintLineTextDialogue("You attempt to stand up from your bed, but are stopped by a very familiar soft embrace.");
            SetChoiceButtons(nextChoice);
            _currentExecutingLine++;
        }

        private void EndingLine14()
        {
            PrintLineTextDialogue("\"Nnnn, 5 more minutes, honey.\"");
            SetChoiceButtons(nextChoice);
            _currentExecutingLine++;
        }

        private void EndingLine15()
        {
            PrintLineTextDialogue("Oh, and you got married to the princess ");
            SetChoiceButtons(nextChoice);
            _currentExecutingLine++;
        }

        #endregion
    }
}