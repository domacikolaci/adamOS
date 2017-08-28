using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adamOS
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

            Console.Write("Welcome adventurer! Please, state thy name!");
            Console.WriteLine(">:");
            playerName = Console.ReadLine();
            Console.WriteLine(playerName + "! You are about to embark on an amazing journey!");
            Console.WriteLine("It will involve all sorts of cool and fun quests!");
            Console.WriteLine("Are you ready?");
            Console.WriteLine(">:");
            var playerReady = Console.ReadLine();
            if (playerReady == "yes")
            {
                adamOS.level1.main();
            }
            else
            {
                //Returns user back to Kernel.cs
                Console.WriteLine("Now returning back to adamOS");
                Console.ReadLine();
            }
        }
        
    }
}
