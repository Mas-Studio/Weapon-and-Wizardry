﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WeaponAndWizardry.App_Code
{
    /// <summary>
    /// Represents a script scenario that uses ScriptEngine API
    /// to dictate the game flow.
    /// </summary>
    public partial class ScriptEngine
    {
        static Choices nextChoice = new Choices("Next");

        private void LoadScripts()
        {
            _scriptLines.Add(Line1);
            _scriptLines.Add(Line2);
            _scriptLines.Add(Line3);
            _scriptLines.Add(Line4);
        }

        private void Line1()
        {
            ClearImageDisplay();
            SetBackgroundImage("Camp.png");
            //AddForegroundImage("images/Shiki.png", 400, 300, 12, 120, 120);
            SetChoiceButtons(nextChoice);
            PrintTextDialogue("Where am I…?\nA soft light fills the area," +
                "giving the atmosphere a solemn feel.\n ... Is this a dream?");
            _currentExecutingLine++;
        }

        private void Line2()
        {
            SetChoiceButtons(nextChoice);
            PrintTextDialogue("Oh brave hero…\nYou hear a beautiful voice begin to call you.\n" 
                + "The great goddess Ilias suddenly appears before you.");
            _currentExecutingLine++;                       
        }

        private void Line3()
        {
            SetChoiceButtons(new Choices("I can!", "Nope", "..."));
            PrintTextDialogue("Oh great hero… can you hear my voice?");
            _currentExecutingLine++;
        }

        private void Line4()
        {
            SetChoiceButtons(nextChoice);
            PrintTextDialogue("You begin to tremble at the sound of Ilias‘s voice.\n"+
                "The goddess whom created the world, who extends her love to humanity.\n" +
                "You feel both relaxed and awed with such an amazing figure before you.\n" +
                "Even if it’s just a dream.");
            _currentExecutingLine++;
        }

        private void Line5()
        {
            SetChoiceButtons(new Choices("I can!", "Nope", "..."));
            PrintTextDialogue("You begin to tremble at the sound of Ilias‘s voice.\n" +
                "The goddess whom created the world, who extends her love to humanity.\n" +
                "You feel both relaxed and awed with such an amazing figure before you.\n" +
                "Even if it’s just a dream.");
            _currentExecutingLine++;
        }

        private void Line6()
        {
            SetChoiceButtons(nextChoice);
            PrintTextDialogue("I have forseen that you will be the deciding factor"
                + "in bringing harmony or calamity to men and beast alike.\n" +
                "I am here to help guide you, so that you may live up to your full potential.");
            _currentExecutingLine++;
        }

        private void Line7()
        {
            SetChoiceButtons(new Choices("I'm the strongest there is.(Strength++)", "Speed's my game.(Dexterity++)", 
                "I know everything.(Intelligence++)", "I've always been very lucky (Luck++)"));
            PrintTextDialogue("Before we begin, I want to know more about you, oh great hero.\n" +
                "How would you describe yourself ?");
            _currentExecutingLine++;
        }

        private void Line8()
        {
            SetChoiceButtons(new Choices("I'm not very strong...(Strength--)", "I'm a little slow (Dexterity--)",
                "I've never been very bright.(Intelligence--)", "I'm super unlucky.(Luck--)"));
            PrintTextDialogue("What would you say is your biggest weakness?");
            _currentExecutingLine++;
        }

        private void Line9()
        {
            SetChoiceButtons(nextChoice);
            PrintTextDialogue("Farewell, brave hero.\n  Know that I will always be watching over you, " + 
                "even in the tutorial section.");
            _currentExecutingLine++;
        }

        private void Line10()
        {
            SetChoiceButtons(nextChoice);
            PrintTextDialogue("You suddenly wake up to see the camp you made last night.\n" +
                "Your possessions include: your sword, your monster slaying medallion, a monster" +
                "slaying contract and typical camping necessities.");
            _currentExecutingLine++;
        }

        private void Line11()
        {
            SetChoiceButtons(nextChoice);
            PrintTextDialogue("You open the contract scroll among your belongings.\n" +
                "Contract: Slay the beast of Granberia");
            _currentExecutingLine++;
        }

        private void Line12()
        {
            SetChoiceButtons(nextChoice);
            PrintTextDialogue("You decide to head towards Granberia to attempt to complete the contract. \n" +
                "Man’s gotta eat after all.");
            _currentExecutingLine++;
        }

        private void Line13()
        {
            SetChoiceButtons(nextChoice);
            PrintTextDialogue("You make your way along the road to the city of Granberia.");
            _currentExecutingLine++;
        }

        private void Line14()
        {
            SetChoiceButtons(nextChoice);
            PrintTextDialogue("HELP ME!");
            _currentExecutingLine++;
        }

        private void Line15()
        {
            SetChoiceButtons(new Choices("Rush over to find out who's calling for help", "Ignore it"));
            PrintTextDialogue("You hear someone shouting nearby");
            _currentExecutingLine++;
        }

        private void Line16()
        {
            SetChoiceButtons(new Choices("Attempt to rescue the soldier", "Ignore"));
            PrintTextDialogue("You rush over and see a soldier tied up, being attacked by goblins.\n" +
                "What do you do?");
            _currentExecutingLine++;
        }

        private void Line17()
        {
            SetChoiceButtons(nextChoice);
            PrintTextDialogue("You rush over with your sword in hand.The goblins are alerted to your presence. \n"
                + "KREEE!KREEE!");
            _currentExecutingLine++;
        }

        private void Line18()
        {
            SetChoiceButtons(new Choices("Attack with your sword", "Flee", "Intimidate them with a battle-cry (Strength)" ));
            PrintTextDialogue("You’re outnumbered 3-to-1.  However, you know that goblins are generally cowards" +
                " and will flee if they think the odds are against them.\n  What do you do?");
            _currentExecutingLine++;
        }

        private void Line19()
        {
            SetChoiceButtons(nextChoice);
            PrintTextDialogue("You’ve decided that the incident was more trouble than it’s worth.\n" +  
                "You continue on your way towards Granberia. ");
            _currentExecutingLine++;
        }

        private void Line20()
        {
            SetChoiceButtons(nextChoice);
            PrintTextDialogue("With your sword in hand, you attempt to slice the biggest goblin in two.\n" +  
            "However, you swing doesn’t go clean through and the goblin is able to retaliate ");
            _currentExecutingLine++;
        }

        private void Line21()
        {
            SetChoiceButtons(nextChoice);
            PrintTextDialogue("The goblin is now badly wounded and is open " +
                "for your next attack which cleaves the goblin in two.\n  KREEE!Kree... ");
            _currentExecutingLine++;
        }

        private void Line22()
        {
            SetChoiceButtons(nextChoice);
            PrintTextDialogue("The big goblin goes crashing down.  His two companions now fear stricken," +
                "flee for their lives.  \nTired from the ordeal, you decide not to give chase.");
            _currentExecutingLine++;
        }

        private void Line23()
        {
            SetChoiceButtons(nextChoice);
            PrintTextDialogue("You decide the best course of action would be to bluff your way to victory.\n" +  
            "You bellow a battle cry with all your might.");
            _currentExecutingLine++;
        }

        private void Line24()
        {
            SetChoiceButtons(nextChoice);
            PrintTextDialogue("COME FORTH YOU SHALL FIND NO HONOUR IN DEATH!");
            _currentExecutingLine++;
        }

        private void Line25()
        {
            SetChoiceButtons(nextChoice);
            PrintTextDialogue("Your cry succeeds in intimidating the three goblins." +
                "They all look to each other in fear and run away." +
                "You decide not pursue them since you’ve already won the battle.  ");
            _currentExecutingLine++;
        }

        private void Line27()
        {
            SetChoiceButtons(new Choices("Untie him", "Ask him why he’s tied up", "Leave him to the monsters", 
                "Kill him and loot him"));
            PrintTextDialogue("Thank you.  My name is John Verdan.  Now quick, untie me!\n" +
                "The tied up soldier is now asking for your assistance.  His fate is in your hands.\n" +
                "What do you do?");
            _currentExecutingLine++;
        }

        private void Line28()
        {
            SetChoiceButtons(nextChoice);
            PrintTextDialogue("You decide to untie the ropes around the soldier's arms and legs. \n" + 
                "Thanks. Now, I’m gonna get out of here before more of those goblins show up. " +
                "\nI promise I’ll pay you back someday.The soldier leaves."
            );
            _currentExecutingLine++;
        }

        private void Line29()
        {
            SetChoiceButtons(nextChoice);
            PrintTextDialogue("You decide to continue onwards with your journey.");
            _currentExecutingLine++;
        }

        private void Line30()
        {
            SetChoiceButtons(new Choices("No", "Fine, fine"));
            PrintTextDialogue("What? Can’t you just untie me first?");
            _currentExecutingLine++;
        }

        private void Line31()
        {
            SetChoiceButtons(nextChoice);
            PrintTextDialogue("But I… Ugh, okay fine.  I’m tied up because I’m a deserter.\n" +
                "I left the army because I’m a coward who doesn’t want to die.  \n" +
                "With so much political instability, nations aren’t so keen on sharing at the moment. ");
            _currentExecutingLine++;
        }

        private void Line32()
        {
            SetChoiceButtons(new Choices("Untie him", "Leave him to the monsters", "Kill him and loot him"));
            PrintTextDialogue("I’m not that nationalistic, but I needed money to buy food to survive.  \n" +
            "It’s hard making a living in this day and age.  I joined the army to make ends meet, but… well you know.");
            _currentExecutingLine++;
        }

        private void Line99()
        {
            ClearImageDisplay();
            SetBackgroundImage("original.jpg");
            AddForegroundImage("images/Neet.jpg", 400, 300, 12, 120, 120);
            switch (_choicePicked)
            {
                case 1:
                    PrintTextDialogue("You attack!");
                    break;
                case 2:
                    PrintTextDialogue("You Run!");
                    break;
            }
            SetChoiceButtons(new Choices("Fight More", "Run more"));
            _currentExecutingLine++;
        }

        private void Line100()
        {
            ClearImageDisplay();
            SetBackgroundImage("original.jpg");
            AddForegroundImage("images/Shiki.png", 400, 300, 12, 120, 120);
            switch (_choicePicked)
            {
                case 1:
                    SetChoiceButtons(new Choices());
                    PrintTextDialogue("You Die!");
                    break;
                case 2:
                    SetChoiceButtons(new Choices());
                    PrintTextDialogue("You Slip!");
                    break;
            }
            _currentExecutingLine++;
        }
    }
}