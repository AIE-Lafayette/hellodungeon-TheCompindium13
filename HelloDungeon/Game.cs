using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloDungeon
{
    class Game
    {
        //Stats Menu
        void PrintStats(string name, float health, float intel, float strength, float charisma, float luck, float stamina, float percept)
        {
            while()
            {
                Console.WriteLine("Courior Name = " + name);
                Console.WriteLine("Health = " + health);
                Console.WriteLine("Smarts = " + intel);
                Console.WriteLine("Strength = " + strength);
                Console.WriteLine("Stamina = " + stamina);
                Console.WriteLine("Charisma = " + charisma);
                Console.WriteLine("Luck = " + luck);
                Console.WriteLine("Perception = " + percept);
            }
            
        }
        
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
                    if (PlayerChoice == "4" && option4 != "")
                    {
                        continue;
                    }
                    if (PlayerChoice == "5" && option5 != "")
                    {
                        continue;
                    }
                    if (PlayerChoice == "6" && option6 != "")
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


        public void Run()
        {
          
            

            //Starting Strings

            string DogName = "Rex";
            string PlayerName = "";
            string PlayerChoice = "";
            bool IsAlive = true;
            float IntelPoints = 10.00f;
            float StrengthPoints = 10.00f;
            float CharismaPoints = 10.00f;
            float StaminaPoints = 10.00f;
            float LuckPoints = 10.00f;
            float PerceptionPoints = 10.00f;
            float HealthPoints = 32.76f * 2;
            int AreaNumber = 0;
            bool GameIsOn = true;
            



            //Game Start
            while (GameIsOn == true)
            {
                

                while (PlayerChoice != "1")
                {
                    Console.ReadKey();
                    Console.WriteLine("Tales of a Well Traveled Courior");
                    Console.ReadLine();
                    Console.WriteLine("'What is your name?'");
                    Console.Write(">");

                    //Name
                    string firstname = Console.ReadLine();
                    string lastname = Console.ReadLine();
                    PlayerName = firstname + lastname;

                    //First Player Choice
                    PlayerChoice = DisplayMenu("'Your name is " + PlayerName + " correct?'", "Yes", "No", "", "", "", "");
                    PlayerChoice = Console.ReadLine();
                    Console.Clear();
                    if (PlayerChoice == "2")
                    {
                        Console.WriteLine("'I am sorry please can you repeat it?'");

                    }
                    else if (PlayerChoice == "1")
                    {
                        Console.WriteLine("'Great now let's begin'");

                    }
                    else
                    {
                        Console.WriteLine("ERROR ERROR INVALID INPUT DETECTED TRY AGAIN!!!");
                        Console.ReadKey(true);

                    }
                }


                //String Code

                PlayerChoice = Console.ReadLine();

                //Worldbuilding
                
                Console.WriteLine("'Welcome to the Lone Star Courior Service " + PlayerName + " glad to have you aboard.'");
                Console.ReadLine();
                Console.WriteLine("You dust the sands of the desert from your stiched up and raggedy old pants.");
                Console.WriteLine("Hitching a ride with a traveling caravan heading towards New Opealousas.");
                Console.WriteLine("You have been tasked by your employer to deliver a series of packages too");
                Console.WriteLine("various areas across the southwest wasteland.");
                Console.WriteLine("You are to be paid on delivery. Your first delivery is in the town Lafayette");
                Console.WriteLine("The caravan is stopping for a moment to refuel.");
                Console.ReadLine();

                    //First Action
                    PlayerChoice = DisplayMenu("To pass the time you...", "Talk with a caravan hand", "Barter with the dog trader", "Take a nap", "Sleep", "Wait around", "Check stats");

                //while (PlayerChoice != "1" && PlayerChoice != "2" && PlayerChoice != "3" && PlayerChoice != "4" && PlayerChoice != "5" && PlayerChoice != "6")
                //{
                //    //Story Start
                    
                //    //Console.ReadLine();
                //    //Console.WriteLine("1. Talk with a caravan hand");
                //    //Console.WriteLine("2. Barter with the dog trader");
                //    //Console.WriteLine("3. Take a nap");
                //    //Console.WriteLine("4. Sleep");
                //    //Console.WriteLine("5. Wait around");
                //    //Console.WriteLine("6. Check stats");
                    
                    //Conversation Start
                    if (PlayerChoice == "1")
                    {
                        Console.WriteLine("You learn about a local legend about a strange armored devil.");

                    }
                    else if (PlayerChoice == "2")
                    {
                        Console.WriteLine("You walk over to the hunched over trader and buy a Cyberdog named Rex for $1,000.");

                    }
                    else if (PlayerChoice == "3" && PlayerName == "Link")
                    {
                        Console.WriteLine("You lay down in one of the empty carts and doze off for longer then you thought.");

                    }
                    else if (PlayerChoice == "3" || PlayerChoice == "4")
                    {
                        Console.WriteLine("You lay down in one of the empty carts and doze off.");

                    }
                    else if (PlayerChoice == "5" || PlayerChoice == "Wait")
                    {
                        Console.WriteLine("You wait a few hours untill the caravan starts moving again.");

                    }
                    else if (PlayerChoice == "6")
                    {
                        PrintStats(PlayerName, HealthPoints, IntelPoints, StrengthPoints, CharismaPoints, LuckPoints, StaminaPoints, PerceptionPoints);
                    }
                    Console.ReadLine();
                    Console.Clear();

                    //TimeSkip

                    Console.ReadLine();
                    Console.WriteLine("//                                   One Week Later                                 //");
                    Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine("As you enter thru the imposing metal gate that creates a protective shell of the city.");
                    Console.WriteLine("You have finally arrived at your first point of delivery... the city of Lafayette.");
                    Console.WriteLine("The instructions on the parcel says to bring the package to Old Ann's Church");
                    Console.WriteLine(" but no other directions are stated... Strange.");
                    

























                    //PlayerChoice = DisplayMenu("Restart?", " Yes", " No", "", "", "", "");

                    //    if (PlayerChoice == "1")
                    //    {
                    //        GameIsOn = true;
                    //    }
                    //    else if (PlayerChoice == "2");
                    //    {
                    //        Console.WriteLine("Goodbye");
                    //        GameIsOn = false;
                    //    }

            }
        }
    }
}
