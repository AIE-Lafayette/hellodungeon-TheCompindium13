using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloDungeon
{
    class Game
    {
        void PrintStats(string name, float health, float intel, float strength, float charisma, float luck, float stamina, float percept)
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
        
        string DisplayMenu(string prompt, string option1, string option2, string option3)
        {
            string PlayerChoice = "";
            
            while (PlayerChoice != "1" && PlayerChoice != "2" && PlayerChoice != "3")
            {
                //Display Prompt
                Console.Clear();
                Console.WriteLine(prompt);

                //Display All Options
                Console.WriteLine("1." + option1);
                Console.WriteLine("2." + option2);
                Console.WriteLine("3." + option3);
                
                //Get Player Input
                Console.Write("<");
                PlayerChoice = Console.ReadLine();

                //If Not Then...
                if (PlayerChoice != "1" && PlayerChoice != "2" && PlayerChoice != "3")
                {
                    //...Display ERROR Message
                    Console.Clear();
                    Console.WriteLine("Wrong");
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey(true);


                }
            }
            return PlayerChoice;
        }


        public void Run()
        {
          
            

            //Starting Strings

            string DogName = "Rex";
            string PlayerName = "";
            string Playerchoice = "";
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
            




            while (GameIsOn == true)
            {
                

                Playerchoice = "";
                while (Playerchoice != "1")
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

                    Console.WriteLine("'Your name is " + PlayerName + " correct?'");

                    //Confirming The Choice
                    
                    Console.WriteLine("1. Yes");
                    Console.WriteLine("2. No");

                    Playerchoice = Console.ReadLine();
                    Console.Clear();
                    if (Playerchoice == "2")
                    {
                        Console.WriteLine("'I am sorry please can you repeat it?'");

                    }
                    else if (Playerchoice == "1")
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
                
                string PlayerChoice = Console.ReadLine();

                //Worldbuilding
                
                Console.WriteLine("'Welcome to the Lone Star Courior Service " + PlayerName + " glad to have you aboard.'");
                Console.ReadLine();
                Console.WriteLine("You dust the sands of the desert from your stiched up and raggedy old pants.");
                Console.WriteLine("Hitching a ride with a traveling caravan heading towards New Opealousas.");
                Console.WriteLine("You have been tasked by your employer to deliver a series of packages too");
                Console.WriteLine("various areas across the southwest wasteland.");
                Console.WriteLine("You are to be paid on delivery. Your first delivery is in the town Lafayette");
                Console.WriteLine("The caravan is stopping for a moment to refuel.");
                Console.WriteLine("To pass the time you...");

                //First Action
                PlayerChoice = DisplayMenu("To pass the time you...", "1. Talk with a caravan hand", "2. Barter with the dog trader", "3. Take a nap");

                while (PlayerChoice != "1" && PlayerChoice != "2" && PlayerChoice != "3" && PlayerChoice != "4" && PlayerChoice != "5" && PlayerChoice != "6")
                {
                    //Story Start
                    
                    //Console.ReadLine();
                    //Console.WriteLine("1. Talk with a caravan hand");
                    //Console.WriteLine("2. Barter with the dog trader");
                    //Console.WriteLine("3. Take a nap");
                    //Console.WriteLine("4. Sleep");
                    //Console.WriteLine("5. Wait around");
                    //Console.WriteLine("6. Check stats");
                    
                    //Conversation Star
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

                    PlayerChoice = "";
                    while(PlayerChoice != "1" && PlayerChoice != "2")
                    {
                        Console.WriteLine("Restart?");
                        Console.WriteLine("1. Yes");
                        Console.WriteLine("2. No");
                        Console.Write("<");

                        if (PlayerChoice == "1")
                        {
                            GameIsOn = true;
                        }
                        else if (PlayerChoice == "2");
                        {
                            Console.WriteLine("Goodbye");
                            GameIsOn = false;
                        }
                    }
                         
                }  
            }
        }
    }
}
