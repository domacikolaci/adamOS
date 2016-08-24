using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adamOS.adventureGame
{
    
    public class adventureGameMain
    {   
        public static string playerName = "";
        public static int playerHP = 20;
        public static int playerAttack = 5;

        public static void gameMain()
        {
            //var playerName = new player.playerN();
            //player playerName;

            Console.Write("Welcome adventurer! Please, state thy name!\n");
            playerName = Console.ReadLine();
            Console.WriteLine(playerName + "! You are about to embark on an amazing journey!");
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
