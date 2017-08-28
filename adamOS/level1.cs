using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using adamOS.adventureGame;

namespace adamOS
{
    public class level1
    {
        public static int goblinHP = 10;
        public static int goblinAttack = 1;
        //adventureGame.adventureGameMain player;

        public static void main()
        {
            Console.WriteLine("You are walking down the road to a local township when suddenly, you hear something move/n");
            Console.WriteLine("Its a goblen! Kill it quick!");
            goblenFight();
        }

        static void goblenFight()
        {
            Console.WriteLine("Type attack to swing at the goblin!");
            var playerMove = Console.ReadLine();
            if(playerMove == "attack")
            {
                goblinHP = -adventureGameMain.playerAttack;
                Console.WriteLine(goblinHP);
                Console.ReadLine();
            }
        }
    }
}
