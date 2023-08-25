using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloDungeon
{
    class Game
    {
        public void Run()
        {
            
            //Starting strings
            string DogName = "Rex";
            string PlayerName = "";
            bool IsAlive = true;
            int IntelPoints = 10;
            float HealthPoints = 32.76f * 2;
            int AreaNumber = 0;
            
            //Start writing
            Console.WriteLine("Tales of a Well Traveled Courior");
            Console.WriteLine("'What is your name?'");
            
            //Name
            string firstname = Console.ReadLine();
            string lastname = Console.ReadLine();
            PlayerName = firstname + lastname;

            //Printed name
            Console.WriteLine("'Welcome to the Lone Star Courior Service " + PlayerName + " glad to have you aboard.'");

            //String code
            string PlayerChoice = Console.ReadLine();

            // Worldbuilding
            Console.WriteLine("You dust the sands of the desert from your stiched up and raggedy old pants.");
            Console.WriteLine("Hitching a ride with a traveling caravan heading towards New Opealousas.");
            Console.WriteLine("You have been tasked by your employer to deliver a series of packages too");
            Console.WriteLine("various areas across the southwest wasteland.");
            Console.WriteLine("You are to be paid on delivery. Your first delivery is in the town Lafayette");
            Console.WriteLine("The caravan is stopping for a moment to refuel.");
            Console.WriteLine("To pass the time you...");
            Console.ReadKey();

            //First action
            Console.ReadLine();
            Console.WriteLine("1. Talk with a caravan hand");
            Console.WriteLine("2. Barter with the dog trader");
            Console.WriteLine("3. Take a nap");
            Console.WriteLine("4. Sleep");
            Console.WriteLine("5. Wait around");
            // Conversation start
            PlayerChoice = Console.ReadLine();
            Console.Clear();
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
        }
    }
}
