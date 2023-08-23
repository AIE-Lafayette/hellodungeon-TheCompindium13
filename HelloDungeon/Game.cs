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
            Console.WriteLine("Fin Yah");
            Console.WriteLine("'Drem yol lok Adventurer Wo are You?'");
            
            //Name
            string firstname = Console.ReadLine();
            string lastname = Console.ReadLine();
            PlayerName = firstname + lastname;

            //Printed name
            Console.WriteLine("'Drem yol lok great Hun " + PlayerName + ".'");

        }
    }
}
