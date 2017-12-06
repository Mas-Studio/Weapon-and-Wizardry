using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WeaponAndWizardry.Code
{
    /// <summary>
    /// Container for the Script methods for the Prologue.
    /// </summary>
    public partial class WebGameEngine
    {
        private Strength _str;
        private Dexterity _dex;
        private Intelligence _int;
        private Luck _luk;
        private bool _monsterSlain = false;
        private bool _haggledReward = false;

        public enum Health { Dying, Maimed, Wounded, Healthy};
        public enum Strength { Pitiful, Weak, Average, Strong, Herculean };
        public enum Dexterity { Uncoordinated, Clumsy, Average, Nimble, Agile };
        public enum Intelligence { Dumb, Foolish, Average, Brilliant, Enlightened };
        public enum Luck { Jinxed, Unlucky, Average, Lucky, Blessed };
        public enum Alignment { Wicked, Evil, Troublesome, Neutral, Likeable, Good, Adored}


        /// <summary>
        /// Region containing a method for loading the scripts needed.
        /// </summary>

        #region Script Load

        public void LoadPrologueScripts()
        {
            _scriptLines.Add(Prologue1);
            _scriptLines.Add(Prologue2);
            _scriptLines.Add(Prologue3);
            _scriptLines.Add(Prologue4);
            _scriptLines.Add(Prologue5);
            _scriptLines.Add(Prologue6);
            _scriptLines.Add(Prologue7);
            _scriptLines.Add(Prologue8);
            _scriptLines.Add(Prologue9);
            _scriptLines.Add(Prologue10);
            _scriptLines.Add(Prologue11);
            _scriptLines.Add(Prologue12);
            _scriptLines.Add(Prologue13);
            _scriptLines.Add(Prologue14);
            _scriptLines.Add(Prologue15);
            _scriptLines.Add(Prologue16);
            _scriptLines.Add(Prologue17);
            _scriptLines.Add(Prologue18);
            _scriptLines.Add(Prologue19);
            _scriptLines.Add(Prologue20);
            _scriptLines.Add(Prologue21);
            _scriptLines.Add(Prologue22);
            _scriptLines.Add(Prologue23);
            _scriptLines.Add(Prologue24);
            _scriptLines.Add(Prologue25);
            _scriptLines.Add(Prologue26);
            _scriptLines.Add(Prologue27);
            _scriptLines.Add(Prologue28);
            _scriptLines.Add(Prologue29);
            _scriptLines.Add(Prologue30);
            _scriptLines.Add(Prologue31);
            _scriptLines.Add(Prologue32);
            _scriptLines.Add(Prologue33);
            _scriptLines.Add(Prologue34);
            _scriptLines.Add(Prologue35);
            _scriptLines.Add(Prologue36);
            _scriptLines.Add(Prologue37);
            _scriptLines.Add(Prologue38);
            _scriptLines.Add(Prologue39);
            _scriptLines.Add(Prologue40);
            _scriptLines.Add(Prologue41);
            _scriptLines.Add(Prologue42);
            _scriptLines.Add(Prologue43);
            _scriptLines.Add(Prologue44);
            _scriptLines.Add(Prologue45);
            _scriptLines.Add(Prologue46);
            _scriptLines.Add(Prologue47);
            _scriptLines.Add(Prologue48);
            _scriptLines.Add(Prologue49);
            _scriptLines.Add(Prologue50);
            _scriptLines.Add(Prologue51);
            _scriptLines.Add(Prologue52);
            _scriptLines.Add(Prologue53);
            _scriptLines.Add(Prologue54);
            _scriptLines.Add(Prologue55);
            _scriptLines.Add(Prologue56);
            _scriptLines.Add(Prologue57);
            _scriptLines.Add(Prologue58);
            _scriptLines.Add(Prologue59);
            _scriptLines.Add(Prologue60);
            _scriptLines.Add(Prologue61);
            _scriptLines.Add(Prologue62);
            _scriptLines.Add(Prologue63);
            _scriptLines.Add(Prologue64);
            _scriptLines.Add(Prologue65);
            _scriptLines.Add(Prologue66);
            _scriptLines.Add(Prologue67);
            _scriptLines.Add(Prologue68);
            _scriptLines.Add(Prologue69);
            _scriptLines.Add(Prologue70);
            _scriptLines.Add(Prologue71);
            _scriptLines.Add(Prologue72);
            _scriptLines.Add(Prologue73);
            _scriptLines.Add(Prologue74);
            _scriptLines.Add(Prologue75);
            _scriptLines.Add(Prologue76);
            _scriptLines.Add(Prologue77);
            _scriptLines.Add(Prologue78);
            _scriptLines.Add(Prologue79);
            _scriptLines.Add(Prologue80);
            _scriptLines.Add(Prologue81);
            _scriptLines.Add(Prologue82);
            _scriptLines.Add(Prologue83);
            _scriptLines.Add(Prologue84);
            _scriptLines.Add(Prologue85);
            _scriptLines.Add(Prologue86);
            _scriptLines.Add(Prologue87);
            _scriptLines.Add(Prologue88);
            _scriptLines.Add(Prologue89);
            _scriptLines.Add(Prologue90);
            _scriptLines.Add(Prologue91);
            _scriptLines.Add(Prologue92);
            _scriptLines.Add(Prologue93);
            _scriptLines.Add(Prologue94);
            _scriptLines.Add(Prologue95);
            _scriptLines.Add(Prologue96);
            _scriptLines.Add(Prologue97);
            _scriptLines.Add(Prologue98);
            _scriptLines.Add(Prologue99);
            _scriptLines.Add(Prologue100);
        }

        #endregion Script Load

        /// <summary>
        /// Region containing the script methods, each containing what's needed for the next
        /// line of dialogue.
        /// </summary>

        #region Scripts

        private void Prologue1()
        {
            HP = 100;
            Str = Strength.Average;
            Dex = Dexterity.Average;
            Int = Intelligence.Average;
            Luk = Luck.Average;
            Align = Alignment.Neutral;
            Gold = 0;
            ClearImageDisplay();
            SetBackgroundImage("01.png");
            SetChoiceButtons(nextChoice);
            PrintTextDialogue("\"Where am I…?\"\nA soft light fills the area," +
                "giving the atmosphere a solemn feel.\n ... \"Is this a dream?\"");
            _currentExecutingLine++;
        }

        private void Prologue2()
        {
            ClearImageDisplay();
            SetBackgroundImage("01.png");
            AddForegroundImage("Ilias_neutral.png", 100, 120, 12, 640, 480);
            SetChoiceButtons(nextChoice);
            PrintTextDialogue("\"Oh brave hero…\"\nYou hear a beautiful voice begin to call you.\n"
                + "The great goddess Ilias suddenly appears before you.");
            _currentExecutingLine++;
        }

        private void Prologue3()
        {
            ClearImageDisplay();
            SetBackgroundImage("01.png");
            AddForegroundImage("Ilias_closed1.png", 100, 120, 12, 640, 480);
            SetChoiceButtons(new Choices("\"I can!\"", "\"Nope.\"", "\"...\""));
            PrintTextDialogue("\"Oh great hero… can you hear my voice?\"");
            _currentExecutingLine++;
        }

        private void Prologue4()
        {
            switch (_choicePicked)
            {
                case 1:
                    ClearImageDisplay();
                    SetBackgroundImage("01.png");
                    AddForegroundImage("Ilias_happy.png", 100, 120, 12, 640, 480);
                    SetChoiceButtons(nextChoice);
                    PrintTextDialogue("\"I can!\"");
                    PrintTextDialogue("\"Excellent.\"\nYou begin to tremble at the sound of Ilias‘s voice.\n" +
                "The goddess whom created the world, who extends her love to humanity.\n" +
                "You feel both relaxed and awed with such an amazing figure before you.\n" +
                "Even if it’s just a dream.");
                    _currentExecutingLine++;
                    break;

                case 2:
                    ClearImageDisplay();
                    SetBackgroundImage("01.png");
                    AddForegroundImage("Ilias_closed2.png", 100, 120, 12, 640, 480);
                    SetChoiceButtons(nextChoice);
                    PrintTextDialogue("\"Nope.\"");
                    PrintTextDialogue("\"Why did you reply then?\"\nYou begin to tremble at the sound of Ilias‘s voice.\n" +
                "The goddess whom created the world, who extends her love to humanity.\n" +
                "You feel both relaxed and awed with such an amazing figure before you.\n" +
                "Even if it’s just a dream.");
                    _currentExecutingLine++;
                    break;

                case 3:
                    ClearImageDisplay();
                    SetBackgroundImage("01.png");
                    AddForegroundImage("Ilias_closed2.png", 100, 120, 12, 640, 480);
                    SetChoiceButtons(nextChoice);
                    PrintTextDialogue("\"...\"");
                    PrintTextDialogue("\"If you don't reply, I'm going to get upset\"\n" +
                        "You begin to tremble at the sound of Ilias‘s voice.\n" +
                "The goddess whom created the world, who extends her love to humanity.\n" +
                "You feel both relaxed and awed with such an amazing figure before you.\n" +
                "Even if it’s just a dream.");
                    _currentExecutingLine++;
                    break;
            }
        }

        private void Prologue5()
        {
            ClearImageDisplay();
            SetBackgroundImage("01.png");
            AddForegroundImage("Ilias_closed1.png", 100, 120, 12, 640, 480);
            SetChoiceButtons(nextChoice);
            PrintTextDialogue("\"I have forseen that you will be the deciding factor "
                + "in bringing harmony or calamity to men and beast alike.\n" +
                "Whether your destiny leads to that of rightous paragon or" +
                "a ruthless renagede. I am here to help guide you, so that " +
                "you may live up to your full potential.\"");
            _currentExecutingLine++;
        }

        private void Prologue6()
        {
            ClearImageDisplay();
            SetBackgroundImage("01.png");
            AddForegroundImage("Ilias_neutral.png", 100, 120, 12, 640, 480);
            SetChoiceButtons(new Choices("\"I'm the strongest there is.(Strength++)\"", "\"Speed's my game.(Dexterity++)\"",
                "\"I'm a know-it-all.(Intelligence++)\"", "\"I've always been very lucky (Luck++)\""));
            PrintTextDialogue("\"Before we begin, I want to know more about you, oh great hero.\n" +
                "How would you describe yourself?\"");
            _currentExecutingLine++;
        }

        private void Prologue7()
        {
            ClearImageDisplay();
            SetBackgroundImage("01.png");
            AddForegroundImage("Ilias_neutral.png", 100, 120, 12, 640, 480);
            switch (_choicePicked)
            {
                case 1:
                    Str++;
                    PrintTextDialogue("\"I'm the strongest there is.\"");
                    PrintTextDialogue("\"Excellent, you should see that your Str stat has changed on the right-hand side of your screen.\n"+
                        "What would you say is your biggest weakness?\"");
                    SetChoiceButtons(new Choices("\"I'm not very strong...(Strength--)\"", "\"I'm a little slow (Dexterity--)\"",
                    "\"I've never been very bright.(Intelligence--)\"", "\"I'm super unlucky.(Luck--)\""));

                    break;

                case 2:
                    Dex++;
                    PrintTextDialogue("\"Speed's my game.\"");
                    PrintTextDialogue("\"Excellent, you should see that your Dex stat has changed on the right-hand side of your screen.\n" +
                        "What would you say is your biggest weakness?\"");
                    SetChoiceButtons(new Choices("\"I'm not very strong...(Strength--)\"", "\"I'm a little slow (Dexterity--)\"",
                    "\"I've never been very bright.(Intelligence--)\"", "\"I'm super unlucky.(Luck--)\""));

                    break;

                case 3:
                    Int++;
                    PrintTextDialogue("\"I'm a know-it-all.\"");
                    PrintTextDialogue("\"Excellent, you should see that your Int stat has changed on the right-hand side of your screen.\n" +
                        "What would you say is your biggest weakness?\"");
                    SetChoiceButtons(new Choices("\"I'm not very strong...(Strength--)\"", "\"I'm a little slow (Dexterity--)\"",
                    "\"I've never been very bright.(Intelligence--)\"", "\"I'm super unlucky.(Luck--)\""));

                    break;

                case 4:
                    Luk++;
                    PrintTextDialogue("\"I've always been very lucky\"");
                    PrintTextDialogue("\"Excellent, you should see that your Luk stat has changed on the right-hand side of your screen.\n" +
                        "What would you say is your biggest weakness?\"");
                    SetChoiceButtons(new Choices("\"I'm not very strong...(Strength--)\"", "\"I'm a little slow (Dexterity--)\"",
                    "\"I've never been very bright.(Intelligence--)\"", "\"I'm super unlucky.(Luck--)\""));

                    break;
            }

            _currentExecutingLine = _currentExecutingLine + 2;
        }

        private void Prologue8()
        {
            //More dialogue here?
            SetChoiceButtons(nextChoice);
            PrintTextDialogue("More text added here for tutorial");
            _currentExecutingLine++;
        }

        private void Prologue9()
        {
            switch (_choicePicked)
            {
                case 1:
                    PrintTextDialogue("\"I'm not very strong...\"");
                    Str--;
                    break;

                case 2:
                    PrintTextDialogue("\"I'm a little slow.\"");
                    Dex--;
                    break;

                case 3:
                    PrintTextDialogue("\"I've never been very bright.\"");
                    Int--;
                    break;

                case 4:
                    PrintTextDialogue("\"I'm super unlucky.\"");
                    Luk--;
                    break;
            }
            ClearImageDisplay();
            SetBackgroundImage("01.png");
            AddForegroundImage("Ilias_happy.png", 100, 120, 12, 640, 480);
            SetChoiceButtons(nextChoice);
            PrintTextDialogue("\"Farewell, brave hero.\nKnow that I will always be watching over you, " +
                "even in the tutorial section.\"");
            _currentExecutingLine++;
        }

        private void Prologue10()
        {
            ClearImageDisplay();
            SetBackgroundImage("13.png");
            SetChoiceButtons(nextChoice);
            PrintTextDialogue("You suddenly wake up to see the camp you made last night.\n" +
                "A dream about Ilias.\n\"I wonder what sort of great destiny " +
                "I could possibly have.\"");
            _currentExecutingLine++;
        }

        private void Prologue11()
        {
            SetChoiceButtons(nextChoice);
            PrintTextDialogue("You check around your camp belongings as you ponder your thoughts. \n" +
                "Your possessions include: your sword, your monster " +
                "slaying medallion, monster slaying contract and typical camping necessities.");
            _currentExecutingLine++;
        }

        private void Prologue12()
        {
            SetChoiceButtons(nextChoice);
            PrintTextDialogue("You open the contract scroll among your belongings.\n" +
                "\"Contract: Slay the beast of Granberia.\n Reward will be given by Granberia's village chief.\"");
            _currentExecutingLine++;
        }

        private void Prologue13()
        {
            SetChoiceButtons(nextChoice);
            PrintTextDialogue("You recall that you camped near the Granberia city to hopefully slay the beast " +
                "and collect the bounty." +
                "\nTo make ends meet, you took up your sword and began slaying monsters for a living for a couple years now.\n" +
                "\"Man’s gotta eat after all.\"");
            _currentExecutingLine++;
        }

        private void Prologue14()
        {
            SetBackgroundImage("11.png");
            SetChoiceButtons(nextChoice);
            PrintTextDialogue("You make your way along the road to the city of Granberia.");
            _currentExecutingLine++;
        }

        private void Prologue15()
        {
            SetChoiceButtons(nextChoice);
            PrintTextDialogue("\"HELP ME!\"");
            _currentExecutingLine++;
        }

        private void Prologue16()
        {
            SetChoiceButtons(new Choices("Rush over to find out who's calling for help", "Ignore it"));
            PrintTextDialogue("You hear someone shouting nearby");
            _currentExecutingLine++;
        }

        private void Prologue17()
        {
            switch (_choicePicked)
            {
                case 1:
                    SetChoiceButtons(new Choices("Attempt to rescue the soldier", "Ignore"));
                    PrintTextDialogue("You rush over and see a soldier tied up, being attacked by goblins.\n" +
                "What do you do?");
                    _currentExecutingLine++;
                    break;

                case 2:
                    SetChoiceButtons(nextChoice);
                    PrintTextDialogue("You’ve decided that the incident was more trouble than it’s worth.\n" +
                        "You continue on your way towards Granberia. ");
                    _currentExecutingLine = _currentExecutingLine + 17;
                    break;
            }
        }

        private void Prologue18()
        {
            switch (_choicePicked)
            {
                case 1:
                    ClearImageDisplay();
                    SetBackgroundImage("11.png");
                    AddForegroundImage("Redgoblin_neutral.png", -100, 120, 12, 640, 480);
                    AddForegroundImage("Redgoblin_neutral.png", 300, 120, 12, 640, 480);
                    SetChoiceButtons(nextChoice);
                    PrintTextDialogue("You rush over with your sword in hand. The goblins are alerted to your presence.\n"
                        + "\"KREEE!KREEE!\"");
                    _currentExecutingLine++;
                    break;

                case 2:
                    SetChoiceButtons(nextChoice);
                    PrintTextDialogue("You’ve decided that the incident was more trouble than it’s worth.\n" +
                        "You continue on your way towards Granberia. ");
                    _currentExecutingLine = _currentExecutingLine + 16;
                    break;
            }
        }

        private void Prologue19()
        {
            if (Str > Strength.Average)
            {
                SetChoiceButtons(new Choices("Attack with your sword", "Flee", "Intimidate them with a battle-cry (Strength)"));
            }
            else
            {
                SetChoiceButtons(new Choices("Attack with your sword", "Flee"));
            }
            PrintTextDialogue("You’re outnumbered 3-to-1.  However, you know that goblins are generally cowards" +
                " and will flee if they think the odds are against them.\nWhat do you do?");
            _currentExecutingLine++;
        }

        private void Prologue20()
        {
            switch (_choicePicked)
            {
                case 1:
                    SetChoiceButtons(nextChoice);
                    PrintTextDialogue("With your sword in hand, you attempt to slice the biggest goblin in two.\n" +
                    "However, you swing doesn’t go clean through and the goblin is able to retaliate.");
                    _currentExecutingLine++;
                    break;

                case 2:
                    SetChoiceButtons(nextChoice);
                    PrintTextDialogue("You’ve decided that the incident was more trouble than it’s worth.\n" +
                        "You continue on your way towards Granberia.");
                    _currentExecutingLine = _currentExecutingLine + 14;
                    break;

                case 3:
                    SetChoiceButtons(nextChoice);
                    PrintTextDialogue("You decide the best course of action would be to bluff your way to victory.\n" +
                    "You bellow a battle cry with all your might.");
                    _currentExecutingLine = _currentExecutingLine + 4;
                    break;
            }
        }

        private void Prologue21()
        {
            SetChoiceButtons(nextChoice);
            PrintTextDialogue("With your sword in hand, you attempt to slice the biggest goblin in two.\n" +
            "However, you swing doesn’t go clean through and the goblin is able to retaliate.\n"+
            "The goblins swings back and hits you with a glancing blow. (-15 HP)");
            HP = HP - 15;
            _currentExecutingLine++;
        }

        private void Prologue22()
        {
            ClearImageDisplay();
            SetBackgroundImage("11.png");
            AddForegroundImage("Redgoblin_neutral.png", -100, 120, 12, 640, 480);
            AddForegroundImage("Redgoblin_scared.png", 300, 120, 12, 640, 480);
            SetChoiceButtons(nextChoice);
            PrintTextDialogue("The goblin is now badly wounded and is open " +
                "for your next attack which cleaves the goblin in two.\n\"KREEE!Kree... \"");
            _currentExecutingLine++;
        }

        private void Prologue23()
        {
            ClearImageDisplay();
            SetBackgroundImage("11.png");
            SetChoiceButtons(nextChoice);
            PrintTextDialogue("The big goblin goes crashing down.  His companion is now fear stricken," +
                "flees for his life.  \nTired from the ordeal, you decide not to give chase.");
            _currentExecutingLine = _currentExecutingLine + 3;
        }

        private void Prologue24()
        {
            ClearImageDisplay();
            SetBackgroundImage("11.png");
            AddForegroundImage("Redgoblin_scared.png", -100, 120, 12, 640, 480);
            AddForegroundImage("Redgoblin_scared.png", 300, 120, 12, 640, 480);
            SetChoiceButtons(nextChoice);
            PrintTextDialogue("\"COME FORTH YOU SHALL FIND NO HONOUR IN DEATH!\"");
            _currentExecutingLine++;
        }

        private void Prologue25()
        {
            ClearImageDisplay();
            SetBackgroundImage("11.png");
            SetChoiceButtons(nextChoice);
            PrintTextDialogue("Your cry succeeds in intimidating the two goblins.\n" +
                "They all look to each other in fear and run away.\n" +
                "You decide not pursue them since you’ve already won the battle.\n" +
                "\"That was some shout,\" you hear the soldier comment.");
            _currentExecutingLine++;
        }

        private void Prologue26()
        {
            AddForegroundImage("Soldier_scared1.png", 100, 120, 12, 640, 480);
            SetChoiceButtons(new Choices("Untie him", "Ask him why he’s tied up", "Leave him to the monsters",
                "Kill him and loot him"));
            PrintTextDialogue("\"Thank you.  My name is John Verdan.  Now quick, untie me!  More of those things could appear\"\n" +
                "The tied up soldier is now asking for your assistance.  His fate is in your hands.\n" +
                "What do you do?");
            _currentExecutingLine++;
        }

        private void Prologue27()
        {
            switch (_choicePicked)
            {
                case 1:
                    AddForegroundImage("Soldier_happy.png", 100, 120, 12, 640, 480);
                    SetChoiceButtons(nextChoice);
                    PrintTextDialogue("You decide to untie the ropes around the soldier's arms and legs.\n" +
                        "\"Thanks. Now, I’m gonna get out of here before more of those goblins show up." +
                        "\nI promise I’ll pay you back someday. The soldier rushes away, quick to leave the area.\""
                    );
                    Align++;
 
                    _currentExecutingLine = _currentExecutingLine + 2;
                    break;

                case 2:
                    ClearImageDisplay();
                    SetBackgroundImage("11.png");
                    AddForegroundImage("Soldier_scared2.png", 100, 120, 12, 640, 480);
                    SetChoiceButtons(new Choices("\"No\"", "\"Fine, fine.  I'll untie you.\""));
                    PrintTextDialogue("\"Why are you tied up?\"");
                    PrintTextDialogue("\"What? Can’t you just untie me first?\"");
                    _currentExecutingLine = _currentExecutingLine + 3;
                    break;

                case 3:
                    SetChoiceButtons(nextChoice);
                    ClearImageDisplay();
                    SetBackgroundImage("11.png");
                    AddForegroundImage("Soldier_scared2.png", 100, 120, 12, 640, 480);
                    PrintTextDialogue("You decide to leave the soldier tied up as you begin to leave." +
                        "\n\"What? Hey, you can't leave me here! Please, please don't let me die! I don't wanna die! " +
                        "Despite the soldier's cries, you leave and continue on your journey.");
                    _currentExecutingLine = _currentExecutingLine + 7;
                    Align--;
                    break;

                case 4:
                    SetChoiceButtons(nextChoice);
                    AddForegroundImage("Soldier_scared2.png", 100, 120, 12, 640, 480);
                    PrintTextDialogue("You slowly walk around the tired up soldier, inspecting him from behind.\n" +
                        "\"So... how about it? Free me please?\"\n " +
                        "You raise your sword and aim for a quick execution-style cut. \n" +
                        "\"What the - !What are you doing ? I…-\"");
                    _currentExecutingLine = _currentExecutingLine + 5;
                    Align--;
                    break;
            }
        }

        private void Prologue28()
        {
            switch (_choicePicked)
            {
                case 1:
                    AddForegroundImage("Soldier_happy.png", 100, 120, 12, 640, 480);
                    SetChoiceButtons(nextChoice);
                    PrintTextDialogue("You decide to untie the ropes around the soldier's arms and legs.\n" +
                        "\"Thanks. Now, I’m gonna get out of here before more of those goblins show up." +
                        "\nI promise I’ll pay you back someday. The soldier rushes away, quick to leave the area.\""
                    );
                    Align++;
                    _currentExecutingLine++;
                    break;

                case 2:
                    SetChoiceButtons(nextChoice);
                    ClearImageDisplay();
                    SetBackgroundImage("11.png");
                    AddForegroundImage("Soldier_scared2.png", 100, 120, 12, 640, 480);
                    PrintTextDialogue("You decide to leave the soldier tied up as you begin to leave." +
                        "\n \"What? Hey, you can't leave me here! Please, please don't let me die! I don't wanna die! " +
                        "Despite the soldier's cries, you leave and continue on your journey.");
                    _currentExecutingLine = _currentExecutingLine + 6;
                    break;

                case 3:
                    SetChoiceButtons(nextChoice);
                    AddForegroundImage("Soldier_scared2.png", 100, 120, 12, 640, 480);
                    PrintTextDialogue("You slowly walk around the tired up soldier, inspecting him from behind.\n" +
                        "\"So... how about it? Free me please?\"\n " +
                        "You raise your sword and aim for a quick execution-style cut. \n" +
                        "\"What the - !What are you doing ? I…-\"");
                    _currentExecutingLine = _currentExecutingLine + 4;
                    break;
            }
        }

        private void Prologue29()
        {
            SetChoiceButtons(nextChoice);
            PrintTextDialogue("With nothing more to do, you decide to continue with your journey.");
            _currentExecutingLine = _currentExecutingLine + 5;
        }

        private void Prologue30()
        {
            switch (_choicePicked)
            {
                case 1:
                    ClearImageDisplay();
                    SetBackgroundImage("11.png");
                    AddForegroundImage("Soldier_frustrated.png", 100, 120, 12, 640, 480);
                    SetChoiceButtons(nextChoice);
                    PrintTextDialogue("\"No.\"");
                    PrintTextDialogue("\"But I… Ugh, okay fine.  I’m tied up because I’m a deserter.\n" +
                        "I left the army because I’m a coward who doesn’t want to die.\n" +
                        "With so much political instability, nations aren’t so keen on sharing at the moment.\"");
                    _currentExecutingLine++;
                    break;

                case 2:
                    AddForegroundImage("Soldier_happy.png", 100, 120, 12, 640, 480);
                    SetChoiceButtons(nextChoice);
                    PrintTextDialogue("\"Fine, fine.\"");
                    PrintTextDialogue("You decide to untie the ropes around the soldier's arms and legs.\n" +
                        "\"Thanks. Now, I’m gonna get out of here before more of those goblins show up." +
                        "\nI promise I’ll pay you back someday. The soldier rushes away, quick to leave the area.\""
                    );
                    _currentExecutingLine = _currentExecutingLine + 4;
                    break;
            }
        }

        private void Prologue31()
        {
            ClearImageDisplay();
            SetBackgroundImage("11.png");
            AddForegroundImage("Soldier_neutral.png", 100, 120, 12, 640, 480);
            SetChoiceButtons(new Choices("Untie him", "Leave him to the monsters", "Kill him and loot him"));
            PrintTextDialogue("\"I’m not that nationalistic, but I needed money to buy food to survive.  \n" +
            "It’s hard making a living in this day and age.  I joined the army to make ends meet, but… well you know.\"");
            _currentExecutingLine = _currentExecutingLine - 3;
        }

        private void Prologue32()
        {
            ClearImageDisplay();
            SetBackgroundImage("11.png");
            SetChoiceButtons(nextChoice);
            PrintTextDialogue("You swing your sword and decapitate the soldier.\n" +
                "The soldier's head comes clean off and his body lands lifeless on the floor.\n" +
                "Unmoved by your recent murder, you search the soldier's body for loot.");
            Align--;
            _currentExecutingLine++;
        }

        private void Prologue33()
        {
            SetChoiceButtons(nextChoice);
            PrintTextDialogue("Unsurprisingly, the body has nothing of value.\nYou decide to continue on your journey.");
            _currentExecutingLine++;
        }

        private void Prologue34()
        {
            ClearImageDisplay();
            SetBackgroundImage("03.png");
            SetChoiceButtons(nextChoice);
            PrintTextDialogue("You finally arrive in Granberia. The town is decently sized compared to your expectations.\n" +
                "The town seemed to contain no more than 100 citizens and they ranged from children to the elderly.");
            _currentExecutingLine++;
        }

        private void Prologue35()
        {
            SetChoiceButtons(nextChoice);
            PrintTextDialogue("You begin exploring the village and eventually spot the village chief's house. \n" +
                "The door isn't locked, so you let yourself in.");
            _currentExecutingLine++;
        }

        private void Prologue36()
        {
            ClearImageDisplay();
            SetBackgroundImage("58.png");
            AddForegroundImage("Elder_neutral.png", 100, 120, 12, 640, 480);
            SetChoiceButtons(nextChoice);
            PrintTextDialogue("Upon entering, you meant a very elderly man. \n" +
                "He seemed a little anxious from his pacing back and forth.");
            _currentExecutingLine++;
        }

        private void Prologue37()
        {
            ClearImageDisplay();
            SetBackgroundImage("58.png");
            AddForegroundImage("Elder_neutral.png", 100, 120, 12, 640, 480);
            SetChoiceButtons(nextChoice);
            PrintTextDialogue("\"Ah, you must be a slayer who accepted the contract.  I can tell from your monster-slaying medallion.\n" +
            "\"Please have a seat.\" \nThe old man motions to a seat before him. \n\"My name is Merle.\"");
            _currentExecutingLine++;
        }

        private void Prologue38()
        {
            ClearImageDisplay();
            SetBackgroundImage("58.png");
            AddForegroundImage("Elder_neutral.png", 100, 120, 12, 640, 480);
            SetChoiceButtons(new Choices("\"Double the reward or I walk, old man.\" (Luck Check)", "\"I accept the contract.\""));
            PrintTextDialogue("\"As you know, our village is currently being attacked by an unknown monster.\n" +
                "It seems to happen at random times.  The most recent attack was near the stables of our village.\n" +
                "Please I beg you to help us.\nThe reward of 500 gold pieces.\"");
            _currentExecutingLine++;
        }

        private void Prologue39()
        {
            ClearImageDisplay();
            SetBackgroundImage("58.png");
            switch (_choicePicked)
            {
                case 1:
                    if (Int > Intelligence.Average)
                    {
                        AddForegroundImage("Elder_surprised.png", 100, 120, 12, 640, 480);
                        SetChoiceButtons(nextChoice);
                        PrintTextDialogue("\"Double the reward or I walk, old man.\"");
                        PrintTextDialogue("\"D-Double?!? But I... The village...\"\nThe village chief sighs.\n" +
                            "\"If it will save our village, I will pay any price.\nYou have a deal.\"");
                        _haggledReward = true;
                        _currentExecutingLine = _currentExecutingLine + 2;                       
                    }
                    else
                    {
                        AddForegroundImage("Elder_surprised.png", 100, 120, 12, 640, 480);
                        SetChoiceButtons(nextChoice);
                        PrintTextDialogue("\"Double the reward or I walk, old man.\"");
                        PrintTextDialogue("\"D-Double?!? I could easily hire 5 mercenaries for that kind of money.\n" +
                            "No deal!\"");
                        _currentExecutingLine = _currentExecutingLine + 1;
                    }
                    break;
                case 2:
                    AddForegroundImage("Elder_happy.png", 100, 120, 12, 640, 480);
                    SetChoiceButtons(nextChoice);
                    PrintLineTextDialogue("\"I accept the contract.\"");
                    PrintTextDialogue("\"Very good.\nPlease slay the beast and bring me it's head as proof." +
                        "\nOnly then will you be paid.\"\nThe old man motions you to leave as he has other matters to attend to.");
                    _currentExecutingLine = _currentExecutingLine + 2;
                    break;
            }
        }

        private void Prologue40()
        {
            ClearImageDisplay();
            SetBackgroundImage("58.png");
            AddForegroundImage("Elder_neutral.png", 100, 120, 12, 640, 480);
            SetChoiceButtons(new Choices("\"Fine, I'll do the deed for 500 gold.\""));
            PrintTextDialogue("The old man looks sternly back at you. It's unlikely he will change his mind.");
            _currentExecutingLine++;
        }

        private void Prologue41()
        {
            ClearImageDisplay();
            SetBackgroundImage("03.png");
            SetChoiceButtons(new Choices("Ask around the village marketplace for information.", "Ask for info around the center of town.", "Go to the most recent murder scene to search for clues."));
            PrintTextDialogue("With the deal set, you leave the village chief's house.\n" +
                "You need to slay the beast that's been killing all the villagers.\nHowever, you'll need to find the beast first.\nWhat do you do?");
            _currentExecutingLine++;
        }

        private void Prologue42()
        {
            switch (_choicePicked)
            {
                case 1:
                    SetChoiceButtons(nextChoice);
                    PrintTextDialogue("You decide to head to the marketplace to ask around for information.");
                    _currentExecutingLine++;
                    break;

                case 2:
                    SetChoiceButtons(nextChoice);
                    PrintTextDialogue("You decide to ask around the center of town.");
                    _currentExecutingLine = _currentExecutingLine + 7;
                    break;

                case 3:
                    SetChoiceButtons(nextChoice);
                    PrintTextDialogue("You decide to go to the area of town where the most recent villager death was.");
                    _currentExecutingLine = _currentExecutingLine + 13;
                    break;
            }
        }

        private void Prologue43()
        {
            ClearImageDisplay();
            SetBackgroundImage("20.png");
            SetChoiceButtons(nextChoice);
            PrintTextDialogue("The marketplace is bustling with people of all ages, buying and selling goods.\n" +
                "You spot one of the free shopkeepers and decide to ask them about.");
            _currentExecutingLine++;
        }

        private void Prologue44()
        {
            ClearImageDisplay();
            SetBackgroundImage("20.png");
            AddForegroundImage("Merchant_angry1.png", 100, 120, 12, 640, 480);
            SetChoiceButtons(nextChoice);
            PrintTextDialogue("\"Selling the finest clothes in all of Granberia! Get 'em quick before they're gone!\"\n"
                + "The store owner does'nt seems to notice you at first.");
            _currentExecutingLine = _currentExecutingLine + 2;
        }

        private void Prologue45()
        {
            SetChoiceButtons(nextChoice);
            PrintTextDialogue("Extra line");
            _currentExecutingLine++;
        }

        private void Prologue46()
        {
            ClearImageDisplay();
            SetBackgroundImage("20.png");
            AddForegroundImage("Merchant_sly1.png", 100, 120, 12, 640, 480);
            SetChoiceButtons(new Choices("\"I'm looking for information.\"", "\"How's business?\"", "\"...\""));
            PrintTextDialogue("\"Eh? Now what do you want?  I don't suppose you're gonna buy something.\"");
            _currentExecutingLine++;
        }

        /// <summary>
        /// Choice doesn't matter here, shopkeeper is uncooperative.
        /// </summary>
        private void Prologue47()
        {
            switch (_choicePicked)
            {
                case 1:
                    PrintTextDialogue("\"I'm looking for information.\"");
                    break;

                case 2:
                    PrintTextDialogue("\"How's business?\"");
                    break;
                case 3:
                    PrintTextDialogue("\"...\"");
                    break;
            }
            ClearImageDisplay();
            SetBackgroundImage("20.png");
            AddForegroundImage("Merchant_angry2.png", 100, 120, 12, 640, 480);
            SetChoiceButtons(new Choices("Ask for info around the center of town.", "Go to the most recent murder scene to search for clues."));
            PrintTextDialogue("\"I'm not here to make conversation, pal.  Either buy something or leave\"\n" +
                "Another wave of customers come by and the store owner immediately ignores you to tend to them.\n" +
                "Seems the marketplace is far too busy to get any useful information.\nWhat wilil you try next?");
            _currentExecutingLine++;
        }

        private void Prologue48()
        {
            ClearImageDisplay();
            SetBackgroundImage("20.png");
            switch (_choicePicked)
            {
                case 1:
                    SetChoiceButtons(nextChoice);
                    PrintTextDialogue("You decide to ask around the center of town.");
                    _currentExecutingLine++;
                    break;

                case 2:
                    SetChoiceButtons(nextChoice);
                    PrintTextDialogue("You decide to go to the area of town where the most recent villager death was.");
                    _currentExecutingLine = _currentExecutingLine + 7;
                    break;
            }
        }

        private void Prologue49()
        {
            ClearImageDisplay();
            SetBackgroundImage("27.png");
            SetChoiceButtons(nextChoice);
            PrintTextDialogue("The center of town fairly empty at the moment.\n" +
                "The only person you see are a halfling child playing with a softball.");
            _currentExecutingLine++;
        }

        private void Prologue50()
        {
            AddForegroundImage("Halfling_neutral.png", 100, 120, 12, 640, 480);
            SetChoiceButtons(new Choices("\"Sure!\"", "\"Beat it, kid\""));
            PrintTextDialogue("You are about to leave when the halfing child approaches you. " +
                "\"Hey, you wanna play ball? C'mon it'll be fun!\"");
            _currentExecutingLine++;
        }

        private void Prologue51()
        {
            ClearImageDisplay();
            SetBackgroundImage("27.png");
            switch (_choicePicked)
            {
                case 1:
                    PrintLineTextDialogue("\"Sure!\"");
                    AddForegroundImage("Halfling_happy.png", 100, 120, 12, 640, 480);
                    SetChoiceButtons(nextChoice);
                    PrintTextDialogue("You decide to play with the children for a bit.\n" +
                        "Despite the child's small size, the he's actually quite good.\n" +
                        "\"You're not bad. Best adult I've ever played with.\"");
                    Align++;
                    _currentExecutingLine++;
                    break;

                case 2:
                    PrintLineTextDialogue("\"Beat it, kid\"");
                    AddForegroundImage("Halfling_sad.png", 100, 120, 12, 640, 480);
                    SetChoiceButtons(new Choices("Ask around the village marketplace for information.", "Go to the most recent murder scene to search for clues."));
                    PrintTextDialogue("\"Aww, you're no fun. Adults are so boring.\"" +
                        "\nThe child leaves you. Seems there's nothing else here that will help you progress.\n" +
                        "Where should you head next?");
                    Align--;
                    _currentExecutingLine = _currentExecutingLine + 3;
                    break;
            }
        }

        private void Prologue52()
        {
            ClearImageDisplay();
            SetBackgroundImage("27.png");
            AddForegroundImage("Halfling_interested.png", 100, 120, 12, 640, 480);
            SetChoiceButtons(nextChoice);
            PrintTextDialogue("The child begins asking you about your sword, what you do for a living, etc.\n" +
                "\"A monster hunter? So cool.  Hope you can slay the one that's been attacking our village. " +
                "You should check by the stables, that's where the last monster attack was.\"" +
                "The child waves good-bye as he gets called back by his mother.");
            _currentExecutingLine++;
        }

        private void Prologue53()
        {
            ClearImageDisplay();
            SetBackgroundImage("27.png");
            SetChoiceButtons(nextChoice);
            PrintTextDialogue("The child made a good point about where you should search next. " +
                "You decide to take their advice and head towards the village stables.");
            _currentExecutingLine = _currentExecutingLine + 2;
        }

        private void Prologue54()
        {
            ClearImageDisplay();
            SetBackgroundImage("27.png");
            switch (_choicePicked)
            {
                case 1:
                    SetChoiceButtons(nextChoice);
                    PrintTextDialogue("You decide to head to the marketplace to ask around for information.");
                    _currentExecutingLine = _currentExecutingLine - 11;
                    break;

                case 2:
                    SetChoiceButtons(nextChoice);
                    PrintTextDialogue("You decide to go to the area of town where the most recent villager death was.");
                    _currentExecutingLine++;
                    break;
            }
        }

        private void Prologue55()
        {
            ClearImageDisplay();
            SetBackgroundImage("29.png");
            SetChoiceButtons(nextChoice);
            PrintTextDialogue("You arrive at the village stables.\nNothing seems out of the ordinary.\n" +
                "Lots of horses, hay and the occassional farmer.");
            _currentExecutingLine++;
        }

        private void Prologue56()
        {
            SetChoiceButtons(nextChoice);
            PrintTextDialogue("You notice, however that there is a faint trail of dried blood on the ground.\n" +
                "Curious, you begin to follow it as it leads you outside the village.");
            _currentExecutingLine++;
        }

        private void Prologue57()
        {
            SetBackgroundImage("14.png");
            SetChoiceButtons(nextChoice);
            PrintTextDialogue("The trail leads you deeper and deeper into the forest.\n" +
                "Eventually, the trail ends as you reach a large oak tree.");
            _currentExecutingLine++;
        }

        private void Prologue58()
        {
            SetChoiceButtons(nextChoice);
            PrintTextDialogue("The trail leads you deeper and deeper into the forest.\n" +
                "Eventually, the trail ends as you reach a large oak tree.\n" +
                "Everything seems to be very still, but somehow you feel uneasy.");
            _currentExecutingLine++;
        }

        private void Prologue59()
        {
            SetChoiceButtons(nextChoice);
            PrintTextDialogue("ROAR!");
            _currentExecutingLine++;
        }

        private void Prologue60()
        {
            AddForegroundImage("Monster_neutral.png", 100, 120, 12, 640, 480);
            SetChoiceButtons(nextChoice);
            PrintTextDialogue("Suddenly a behemoth of crashs down in front of you.\n" +
                "In it's jaws appears to be the leftover villager shirt of an unfortunate victim.");
            _currentExecutingLine++;
        }

        private void Prologue61()
        {
            SetChoiceButtons(new Choices("Slash it with your sword.", "Stab it with your sword.", "Attempt to run away.", "Stay on the defensive."));
            PrintTextDialogue("The beast must've used one of the villager's bodies to draw you here.\n" +
                "You're surprised it it's intelligence, but quickly draw your sword to defend yourself.\n"+
                "You notice the beast is searching around, looking for something to strike.");
            _currentExecutingLine++;
        }

        private void Prologue62()
        {
            switch(_choicePicked)
            {
                case 1:
                    SetChoiceButtons(nextChoice);
                    PrintTextDialogue("You attempt to slash the beast with your sword.\n"+
                        "You aim for it's torso, which seemed like a vital spot.");
                    _currentExecutingLine++;

                    break;
                case 2:
                    SetChoiceButtons(nextChoice);
                    PrintTextDialogue("You attempt to stab the beast with your sword.\n" +
                        "You aim for it's torso, which seemed like a vital spot.");
                    _currentExecutingLine++;
                    break;
                case 3:
                    SetChoiceButtons(nextChoice);
                    PrintTextDialogue("You realize this monster is far outside your pay grade and decide to run for it.");
                    _currentExecutingLine = _currentExecutingLine + 8;
                    break;
                case 4:
                    SetChoiceButtons(nextChoice);
                    PrintTextDialogue("You decide to stand your ground and not move.\n"+
                        "No sound is made as you ready yourself, waiting for the monster to strike first.");
                    _currentExecutingLine = _currentExecutingLine + 12;
                    break;
            }
        }

        private void Prologue63()
        {
            SetChoiceButtons(nextChoice);
            PrintLineTextDialogue("CLANK! CRACK!");
            _currentExecutingLine++;
        }

        private void Prologue64()
        {
            SetChoiceButtons(nextChoice);
            PrintLineTextDialogue("You reel back from your strike and your sword feels lighter for some reason.\n"+
                "You look down at your sword and realize that it is now broken in two.\n"+
                "The beast's hide is too tough for you to break.");
            _currentExecutingLine++;
        }

        private void Prologue65()
        {
            SetChoiceButtons(nextChoice);
            PrintLineTextDialogue("GRAWWWWWWR!");
            _currentExecutingLine++;
        }

        private void Prologue66()
        {
            SetChoiceButtons(nextChoice);
            PrintLineTextDialogue("The beast, now enraged, charges for you.\n"+
                "Unable to defend yourself, the beast easily eviscerates you and feasts on your flesh.");
            _currentExecutingLine++;
        }
        private void Prologue67()
        {
            ClearImageDisplay();
            //Need game over image
            //SetBackgroundImage("14.png");
            SetChoiceButtons(nextChoice);
            PrintLineTextDialogue("GAME OVER! \nReturning to Title Screen.");
            _currentExecutingLine++;

        }

        private void Prologue68()
        {
            SetChoiceButtons(nextChoice);
            _currentExecutingLine = _currentExecutingLine - 67;
        }

        private void Prologue69()
        {
            ClearForegroundImages();
            SetChoiceButtons(nextChoice);
            PrintLineTextDialogue("Running as fast as you can out of the forest, you lose the beast easily.");
            _currentExecutingLine++;
        }

        private void Prologue70()
        {
            SetChoiceButtons(nextChoice);
            PrintLineTextDialogue("After sprinting for a while, you begin to relax as the beast is out of sight.\n"+
                "Panting from exhaustion, you decide to rest by one of the forest trees.");
            _currentExecutingLine++;
        }

        private void Prologue71()
        {
            SetChoiceButtons(nextChoice);
            PrintLineTextDialogue("GRAWWRRR!");
            _currentExecutingLine++;
        }

        private void Prologue72()
        {
            AddForegroundImage("Monster_neutral.png", 100, 120, 12, 640, 480);
            SetChoiceButtons(nextChoice);
            PrintLineTextDialogue("Suddenly, the monster from before drops down from the tree and attacks you.\n"+
                "The shout surprises you and you're unable to grab your sword before the beast leaps down on you.");
            _currentExecutingLine++;
        }

        private void Prologue73()
        {
            SetChoiceButtons(nextChoice);
            PrintLineTextDialogue("The beast easily claws your vital organs and makes a quick meal of you.");
            _currentExecutingLine = _currentExecutingLine - 6;
        }

        private void Prologue74()
        {
            SetChoiceButtons(nextChoice);
            PrintLineTextDialogue("The beast doesn't seem to know where you are.\n"+
                "It lumbers around you, listening for any sudden movements.\n"+
                "It occurs to you that the monster is blind and relies on scent or sound to find it's prey.\n"+
                "The monster slowly inches towards you.");
            _currentExecutingLine++;
        }

        private void Prologue75()
        {
            //Larger
            ClearForegroundImages();
            AddForegroundImage("Monster_neutral.png", 100, 120, 12, 640, 480);
            SetChoiceButtons(new Choices("Slash it's body", "Stab it through it's mouth", "Throw your sword away as a distraction"));
            PrintLineTextDialogue("The beast's face is only inches away from yours.\n"+
                "It's mouth is gaping open, letting out foul vapours.\n"+
                "You can smell it's terrible breath and it nearly knocks you out.");
            _currentExecutingLine++;
        }

        private void Prologue76()
        {
            switch (_choicePicked)
            {
                case 1:
                    SetChoiceButtons(nextChoice);
                    PrintTextDialogue("You attempt to slash the beast with your sword.\n" +
                        "You aim for it's torso, which seemed like a vital spot.");
                    _currentExecutingLine = _currentExecutingLine - 13;

                    break;
                case 2:
                    SetChoiceButtons(nextChoice);
                    PrintTextDialogue("You aim your sword careful and use half-swording to pierce the monster through it's mouth");
                    _currentExecutingLine++;
                    break;
                case 3:
                    SetChoiceButtons(nextChoice);
                    PrintTextDialogue("You realize this monster is far outside your pay grade and decide to run for it.\n"+
                        "But first you need a distraction.");
                    _currentExecutingLine = _currentExecutingLine + 5;
                    break;
                
            }
        }

        private void Prologue77()
        {
            SetChoiceButtons(nextChoice);
            PrintLineTextDialogue("Your sword tastes squishy flesh as it digs deeper and deeper into the monster's body.\n"+
                "The monster begins frantically swipping like a feral beast as you refuse to let go of your advantageous position.\n"+
                "the monster gets a few wild scratches on you, but no serious damage. (-10 HP)");
            HP = HP -10;
            _currentExecutingLine++;
        }

        private void Prologue78()
        {
            SetChoiceButtons(nextChoice);
            PrintLineTextDialogue("AROoowwwww!");
            _currentExecutingLine++;
        }
        private void Prologue79()
        {
            ClearForegroundImages();
            SetChoiceButtons(nextChoice);
            PrintLineTextDialogue("The beast lets out one last howl before falling dead.\n"+
                "You pull out your sword from it's body and clean your blade.");
            _currentExecutingLine++;
        }

        private void Prologue80()
        {
            SetChoiceButtons(nextChoice);
            PrintLineTextDialogue("It was a tough fight, but you managed to defeat the Beast of Granberia.\n"+
                "You collect it's body pieces as proof for your reward.\n"+
                "You head back to Granberia.");
            _monsterSlain = true;
            _currentExecutingLine = _currentExecutingLine + 15;
        }

        private void Prologue81()
        {
            SetChoiceButtons(nextChoice);
            PrintLineTextDialogue("You throw your sword as far as you can. \n"+
                "It makes a loud sound as it lands into a nearby tree.");
            _currentExecutingLine++;
        }

        private void Prologue82()
        {
            ClearForegroundImages();
            if(Str > Strength.Average)
            {
                SetChoiceButtons(new Choices("Run away as fast as you can!", "Attempt a chokehold", "Stay very still"));
            }
            else
            {
                SetChoiceButtons(new Choices("Run away as fast as you can!", null, "Stay very still"));
            }
            
            PrintLineTextDialogue("The beast instantly notices the noise and dashes over to the tree, clawing it like a feral beast.\n"+
                "The beast now has it's back to you.  Despite the fact you are unarmed, you now have a golden opportunity.");
            _currentExecutingLine++;
        }

        private void Prologue83()
        {
            switch(_choicePicked)
            {
                case 1:
                    SetChoiceButtons(nextChoice);
                    PrintTextDialogue("You realize this monster is far outside your pay grade and decide to run for it.");
                    _currentExecutingLine = _currentExecutingLine - 14;
                    break;
                case 2:
                    SetChoiceButtons(nextChoice);
                    PrintTextDialogue("You realize this monster is far outside your pay grade and decide to run for it.");
                    _currentExecutingLine++;
                    break;
                case 3:
                    SetChoiceButtons(nextChoice);
                    PrintTextDialogue("You decide to stay very still.  Hoping the monster doesn't notice that you're still nearby.");
                    _currentExecutingLine = _currentExecutingLine + 7;
                    break;
            }
        }

        private void Prologue84()
        {
            AddForegroundImage("Monster_neutral.png", 100, 120, 12, 640, 480);
            SetChoiceButtons(nextChoice);
            PrintTextDialogue("You leap into the air and get a firm hold on the monsters.\n"+
                "Strangling the monster with your arm across it's neck, you squeeze as hard as you can.");
            _currentExecutingLine++;
        }

        private void Prologue85()
        {
            SetChoiceButtons(nextChoice);
            PrintTextDialogue("GRAWWWWRRRR! GRAWR! GRAWR!");
            _currentExecutingLine++;
        }

        private void Prologue86()
        {
            SetChoiceButtons(nextChoice);
            PrintTextDialogue("The monster begins frantically swinging it's claws trying to get you off.\n"+
                "You get clawed a couple times, but no serious injuries so far. (-10 HP)\n"+
                "You hold on for dear life, knowing that if it manages to shake you off, you're dead.");
            HP = HP - 10;
            _currentExecutingLine++;
        }

        private void Prologue87()
        {
            ClearForegroundImages();
            AddForegroundImage("Monster_scared.png", 100, 120, 12, 640, 480);
            SetChoiceButtons(nextChoice);
            PrintTextDialogue("Eventually, the monster begins to slow, it's voice begins to falter.\n"+
                "Nearly a minute passes, before you feel the monster's life slowly fade from it's body.");
            _currentExecutingLine++;
        }

        private void Prologue88()
        {
            ClearForegroundImages();
            SetChoiceButtons(nextChoice);
            PrintLineTextDialogue("The beast lets out one last howl before falling dead.\n" +
                "You pull out your sword from the tree you stuck it in.");
            _currentExecutingLine = _currentExecutingLine - 8;
        }

        private void Prologue89()
        {
            ClearForegroundImages();
            AddForegroundImage("Monster_scared.png", 100, 120, 12, 640, 480);
            SetChoiceButtons(nextChoice);
            PrintTextDialogue("Eventually, the monster begins to slow, it's voice begins to falter.\n" +
                "Nearly a minute passes, before you feel the monster's life slowly fade from it's body.");
            _currentExecutingLine++;
        }

        private void Prologue90()
        {
            SetChoiceButtons(nextChoice);
            PrintTextDialogue("The monster breaths heavily after destroying the tree that your sword was stuck in.\n"+
                "It makes one last look around your location, but can't sense exactly where you are.");
            _currentExecutingLine++;
        }

        private void Prologue91()
        {
            ClearForegroundImages();
            SetChoiceButtons(nextChoice);
            PrintTextDialogue("Suddenly you hear a squirrel in the distance and the monster immediately reacts.\n"+
                "The monster goes on all fours and runs off.");
            _currentExecutingLine++;
        }

        private void Prologue92()
        {
            SetChoiceButtons(nextChoice);
            PrintTextDialogue("You wait a few moments, before moving. You walk over to pick up your sword.\n"+
                "You survive the ordeal by the skin of your teeth.  However, the monster you were sent to kill has gotten away.");
            _currentExecutingLine++;
        }

        private void Prologue93()
        {
            SetChoiceButtons(nextChoice);
            PrintTextDialogue("The day is getting late, so you decide to head back to the village.");
            _currentExecutingLine++;
        }

        private void Prologue94()
        {
            ClearImageDisplay();
            SetBackgroundImage("03.png");
            SetChoiceButtons(nextChoice);
            PrintTextDialogue("Days pass, but you are unable to find any other signs of the monster after that day.\n" +
                "The bounty time the village chief gave you has expired and you are summoned to his tent.");
            _currentExecutingLine++;
        }

        private void Prologue95()
        {
            ClearImageDisplay();
            SetBackgroundImage("58.png");
            AddForegroundImage("Elder_neutral.png", 100, 120, 12, 640, 480);
            
            if(_monsterSlain)
            {
                SetChoiceButtons(new Choices("\"Yep, with ease.\"  Show him proof."));
            }
            else
            {
                SetChoiceButtons(new Choices(null, "(Lie) \"Yep, with ease.\""));
            }

            PrintTextDialogue("You enter the village chief's house and he's anxious to know if you succeeded or not.\n"+
                "\"So? Were you able to succeed in slaying the beast?\"");
            _currentExecutingLine++;
        }

        private void Prologue96()
        {
            switch (_choicePicked)
            {
                case 1:
                    PrintTextDialogue("\"Yep, with ease.\"\n"+
                        "You toss him a bag with the beast's head in it.");
                    Align++;
                    break;
                case 2:
                    PrintTextDialogue("\"Yep, with ease.\"\n" +
                        "You lie as convincingly as possible and toss a bag with a fake beast head in it.");
                    Align--;
                    break;
            }
            ClearForegroundImages();
            SetChoiceButtons(nextChoice);
            AddForegroundImage("Elder_surprised.png", 100, 120, 12, 640, 480);
            PrintTextDialogue("\"I-I-Incredible. I can't believe that you were able to slay the beast in such a short amount of time.\"");
            _currentExecutingLine++;
        }

        private void Prologue97()
        {
            ClearForegroundImages();
            AddForegroundImage("Elder_happy.png", 100, 120, 12, 640, 480);
            if(_haggledReward)
            {
                PrintTextDialogue("\"Here is your reward.\"\n" +
                "The elder hands you a bag of gold. (+1000 Gold)");
                Gold = Gold + 1000;
            }
            else
            {
                PrintTextDialogue("\"Here is your reward.\"\n" +
                "The elder hands you a bag of gold. (+500 Gold)");
                Gold = Gold + 500;
            }
            SetChoiceButtons(nextChoice);
            _currentExecutingLine++;
        }

        private void Prologue98()
        {
            ClearForegroundImages();
            AddForegroundImage("Elder_neutral.png", 100, 120, 12, 640, 480);
            PrintTextDialogue("You take the bag of gold and add it to your inventory.\n"+
                "\"Before you go, I have a letter for you from the royal family.\n"+
                "It seems they've already heard of your reputation.\"\n"+
                "The elder hands you a sealed envelope.  It's very decorated and clearly from some of a high position.\n"+
                "You say your farewells to the village chief and leave his house.");
            SetChoiceButtons(nextChoice);
            _currentExecutingLine++;
        }

        private void Prologue99()
        {
            ClearImageDisplay();
            SetBackgroundImage("03.png");
            PrintTextDialogue("You open the envelope and read the letter inside.\n"+
                "\"To the slayer of the Beast of Granberia, please report to your majesty as soon as possible.\n"
                +"We have a special need for your services.  You will be well compensated for your time.\"");
            SetChoiceButtons(nextChoice);
            _currentExecutingLine++;
        }

        private void Prologue100()
        {
            PrintTextDialogue("A royal invitation.\nA reward from this size would have you set for life.\n"+
                "You could buy... your own estate\nA new clothes\nNew weapons\netc.\nYou decide to take on the request and begin heading towards the capital.");
            SetChoiceButtons(nextChoice);
            _currentExecutingLine++;
        }

        #endregion Scripts
    }
}