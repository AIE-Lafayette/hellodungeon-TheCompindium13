using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloDungeon
{
    class Game
    {
        //Starting Strings
        string DogName = "Rex";
        string PlayerName = "";
        string PlayerChoice = "";
        int CurrentScene = 0;
        bool GameOver = false;

        //DisplayMenu
        string DisplayMenu(string prompt, string option1, string option2, string option3, string option4, string option5, string option6)
        {
            string PlayerChoice = "";

            while (PlayerChoice != "1" && PlayerChoice != "2" && PlayerChoice != "3" && PlayerChoice != "4" && PlayerChoice != "5" && PlayerChoice != "6")
            {
                //Display Prompt
                Console.Clear();
                Console.WriteLine(prompt);

                //Display All Options
                Console.WriteLine("1." + option1);
                Console.WriteLine("2." + option2);
                if (option3 != "")
                {
                    Console.WriteLine("3." + option3);
                }
                if (option4 != "")
                {
                    Console.WriteLine("4." + option4);
                }
                if (option5 != "")
                {
                    Console.WriteLine("5." + option5);
                }
                if (option6 != "")
                {
                    Console.WriteLine("6." + option6);
                }
                //Get Player Input
                Console.Write("<");
                PlayerChoice = Console.ReadLine();

                //If Not Then...
                if (PlayerChoice != "1" && PlayerChoice != "2")
                {
                    if (PlayerChoice == "3" && option3 != "")
                    {
                        continue;
                    }
                    else if (PlayerChoice == "4" && option4 != "")
                    {
                        continue;
                    }
                    else if (PlayerChoice == "5" && option5 != "")
                    {
                        continue;
                    }
                    else if (PlayerChoice == "6" && option6 != "")
                    {
                        continue;
                    }


                    //...Display ERROR Message
                    Console.Clear();
                    Console.WriteLine("Wrong");
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey(true);
                    PlayerChoice = "";
                }
            }
            return PlayerChoice;
        }
        //Main Menu
        void DisplayMainMenu()
        {


            PlayerChoice = "";
            Console.Clear();
            Console.WriteLine("Tales of a Well Traveled Courier");
            Console.ReadLine();
            Console.WriteLine("'What is your name?'");
            Console.Write(">");

            

            //First Player Choice
                //Name
                string firstname = Console.ReadLine();
                string lastname = Console.ReadLine();
                PlayerName = firstname + lastname;

                PlayerChoice = DisplayMenu("'Your name is " + PlayerName + " correct?'", "Yes", "No", "End Game", "", "", "");
                Console.Clear();
                if (PlayerChoice == "2")
                {
                    Console.ReadKey(true);
                    Console.WriteLine("'I am sorry please can you repeat it?'");
                    Console.ReadKey(true);

                }
                else if (PlayerChoice == "1")
                {
                    Console.WriteLine("'Great now let's begin'");
                    Console.ReadKey(true);
                    Console.Clear();
                    CurrentScene = 1;
                }
                else if (PlayerChoice == "3")
                {
                    ShowGameOverScreen();
                }
                else
                {
                    Console.WriteLine("ERROR ERROR INVALID INPUT DETECTED TRY AGAIN!!!");
                    Console.ReadKey(true);

                }




            
        }
        //This Is Scene Number Two
        void DisplaySceneTwo()
        {
            //TimeSkip
            PlayerChoice = "";
            while (PlayerChoice != "1" && PlayerChoice != "2" && PlayerChoice != "3")
            {
                PlayerChoice = "";
                Console.ReadLine();
                Console.Clear();
                Console.ReadLine();
                Console.WriteLine("//                                   One Week Later                                 //");
                Console.ReadLine();
                Console.Clear();
                Console.WriteLine("As you enter thru the imposing metal gate that creates a protective shell of the city.");
                Console.WriteLine("You have finally arrived at your first point of delivery... the city of Lafayette.");
                Console.WriteLine("The instructions on the parcel says to bring the package to Old Ann's Church");
                Console.WriteLine("but no other directions are stated... Strange.");
                Console.ReadLine();

                //Where To Move
                PlayerChoice = DisplayMenu("What will you do now to find the location?", "Ask a local shopkeeper where the church is.", "Wander around", "End Game", "", "", "");
                if (PlayerChoice == "1")
                {
                    Console.WriteLine("You walk into a charming little general store called 'Tina's Terrific Trinkets'.");
                    Console.WriteLine("At the counter you see a older lady whom you assume is the stores namesake.");
                    Console.WriteLine("You ask her where Old Ann's Church is.");
                    Console.WriteLine("She gives you some slightly confusing directions but you eventually get what she tells you and you leave the store");
                    Console.WriteLine("and start toward the church.");
                    //Ending Text
                    Console.ReadLine();
                    Console.WriteLine("You are standing infront of a(n) imposing cathedral with a feeling of dread in your stomach.");
                    Console.WriteLine("A nun walks up to you and asks for the package.");
                    Console.WriteLine("You hand it to her as she hands you your money.");
                    Console.ReadLine();
                    Console.Clear();

                    Console.ReadLine();
                    Console.WriteLine("The End");
                    Console.ReadKey(true);
                }
                else if (PlayerChoice == "2")
                {
                    Console.WriteLine("You wander for almost a full day before you finally find the church.");
                    
                    //Ending Text
                    Console.ReadLine();
                    Console.WriteLine("You are standing infront of a(n) imposing cathedral with a feeling of dread in your stomach.");
                    Console.WriteLine("A nun walks up to you and asks for the package.");
                    Console.WriteLine("You hand it to her as she hands you your money.");
                    Console.ReadLine();
                    Console.Clear();

                    Console.ReadLine();
                    Console.WriteLine("The End");
                    Console.ReadKey(true);
                }
                else if (PlayerChoice == "3")
                {
                    ShowGameOverScreen();
                }
                CurrentScene = 3;


            }

        }
            
        //Game Over
        void ShowGameOverScreen()
        {
            PlayerChoice = "";
            while(PlayerChoice != "1" && PlayerChoice != "2")
            {
                CurrentScene = 0;
                PlayerChoice = DisplayMenu("Restart?", " Yes", " No", "", "", "", "");

                Console.ReadLine();
                if (PlayerChoice == "1")
                {
                    Console.ReadLine();
                    Console.WriteLine("Well let's do it one more time.");
                    Console.ReadLine();
                    CurrentScene = 0;
                }
                else if (PlayerChoice == "2")
                {
                    Console.WriteLine("Goodbye");
                    GameOver = true;
                }
                CurrentScene = 0;
            }

            



        }
        //Show First Scene
        void DisplaySceneOne()
        {



            //Conversation Start
            PlayerChoice = "";
            while (PlayerChoice != "1" && PlayerChoice != "2" && PlayerChoice != "3" && PlayerChoice != "4" && PlayerChoice != "5" && PlayerChoice != "6")
            {
                //String Code
                PlayerChoice = "";
                PlayerChoice = Console.ReadLine();

                //Worldbuilding
                Console.WriteLine("'Welcome to the Lone Star Courier Service " + PlayerName + " glad to have you aboard.'");
                Console.ReadLine();
                Console.WriteLine("You dust the sands of the desert from your stiched up and raggedy old pants.");
                Console.WriteLine("Hitching a ride with a traveling caravan heading towards New Opealousas.");
                Console.WriteLine("You have been tasked by your employer to deliver a package too");
                Console.WriteLine("an area in the southwest wasteland.");
                Console.WriteLine("You are to be paid on delivery. Your delivery is in the town Lafayette");
                Console.WriteLine("The caravan is stopping for a moment to refuel.");
                Console.ReadLine();

                //First Action
                PlayerChoice = DisplayMenu("To pass the time you...", "Talk with a caravan hand", "Barter with the dog trader", "Take a nap", "Sleep", "End Game", "Leave and return to main menu");
                Console.ReadKey(true);
                if (PlayerChoice == "1")
                {
                    Console.Clear();
                    Console.WriteLine("You learn a local legend about a strange armored devil.");
                    CurrentScene = 2;

                }
                else if (PlayerChoice == "2")
                {
                    Console.Clear();
                    Console.WriteLine("You walk over to the hunched over trader and buy a Cyberdog named " + DogName + " for $1,000.");
                    Console.ReadKey(true);
                    Console.Clear();
                    PlayerChoice = "";

                }
                else if (PlayerChoice == "3" && PlayerName == "Link")
                {
                    Console.Clear();
                    Console.WriteLine("You lay down in one of the empty carts and doze off for longer then you thought.");
                    CurrentScene = 2;
                }
                else if (PlayerChoice == "3" || PlayerChoice == "4")
                {
                    Console.Clear();
                    Console.WriteLine("You lay down in one of the empty carts and doze off.");
                    CurrentScene = 2;
                }
                else if (PlayerChoice == "5" || PlayerChoice == "End")
                {
                    ShowGameOverScreen();
                }
                else if (PlayerChoice == "6")
                {
                    CurrentScene = 0;
                }

            }
        }

        public void Run()
        {
            //Game Start
            while (GameOver == false)
            {
                if (CurrentScene == 0)
                {
                    DisplayMainMenu();
                }
                else if (CurrentScene == 1)
                {
                    DisplaySceneOne();
                }
                else if (CurrentScene == 2)
                {
                    DisplaySceneTwo();
                }
                else if (CurrentScene == 3)
                {
                    ShowGameOverScreen();
                }
            }
        }
    }
}
