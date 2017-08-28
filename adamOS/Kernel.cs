using System;
using System.Collections.Generic;
using System.Text;
using adamOS.adventureGame;
using Sys = Cosmos.System;

namespace adamOS
{
    public class Kernel: Sys.Kernel
    {
        protected override void BeforeRun()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("adamOS booted successfully. Please enter a command bellow.");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("WARNING - THIS OS IS VERY MUCH ALPHA, ENJOY");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("If your not sure what to type, type help for a list of commands!");
        }
        
        protected override void Run()
        {
            Console.Write(">: ");
            var input = Console.ReadLine();
            if (input == "help")
            {
                //Loads help.cs and talks to the helpList method
                help.helpList();
            }
            else
            //Loads the game adventureGame
                if (input == "game")
            {
                adventureGameMain.gameMain();
            }
            else
                if (input == "newText") //CURRENTLY BROKEN
            {
                Console.WriteLine("Please enter some text");
                var txt = Console.ReadLine();
                //Console.WriteLine("Please give the file a name");
                //var fileName = Console.ReadLine();
                //File.WriteAllText(@"0:\" + fileName + ".txt", txt);
                //File.WriteAllText(@"0:\meme.txt", txt);
            }
            else
                if (input == "readText") //ALSO DOSNT WORK
            {
                //var output = ReadText.ReadText();

            }
        }
    }
}
