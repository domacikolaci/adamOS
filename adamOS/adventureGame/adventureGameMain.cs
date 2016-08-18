using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adamOS.adventureGame
{
    
    public class adventureGameMain
    {   
        //public static string playerName = "";

        public static void gameMain()
        {
            string playerName = player.playerName();

            Console.Write("Welcome adventurer! Please, state thy name!\n");
            playerName = Console.ReadLine();
            Console.Write(playerName + "! You are about to embark on an amazing journey!/n");
            Console.Write("It will involve all sorts of cool and fun quests!/n");
            Console.Write("Are you ready?/n");
            var playerReady = Console.ReadLine();
            if (playerReady == "yes")
            {
                level1.main();
            }
            else
            {
                //Will go back to "main.cs" which will be added later.....
                Console.WriteLine("lol k");
                Console.ReadLine();
            }
        }
    }
}
