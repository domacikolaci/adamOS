using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adamOS.adventureGame
{
    
    public class adventureGameMain
    {
        public static string playerName;

        public static void gameMain()
        {
            Console.Write("Welcome adventurer! Please, state thy name!");
            var playerName = Console.ReadLine();
            testWew();
        }

        //Shits breaking here.... Will investigate later
        public static void testWew()
        {
            Console.Write(playerName);
            Console.ReadLine();
        }
    }
}
