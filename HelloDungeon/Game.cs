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

            string DogName = "Rex";
            string PlayerName = "";
            bool IsAlive = true;
            int IntelPoints = 10;
            float HealthPoints = 32.76f;
            int AreaNumber = 0;
            
            Console.WriteLine("Fin Yah");
            Console.WriteLine("'Drem yol lok Adventurer Wo are You?'");
            
            string firstname = Console.ReadLine();
            string lastname = Console.ReadLine();
            PlayerName = firstname + lastname;

            Console.WriteLine("'Drem yol lok great Hun " + PlayerName + ".'");

        }
    }
}
