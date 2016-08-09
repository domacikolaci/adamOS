using System;
using System.Collections.Generic;
using System.Text;
using Sys = Cosmos.System;
using adamOS.adventureGame;

namespace adamOS
{
    /// <summary>
    /// This project is based off Cosmos, and is written by Adam "domacikolaci" Knezevic
    /// 
    /// TODO:
    /// IMPORTANT
    /// -Begin basic commands
    /// --Help
    /// -Begining code of basic game CURRENTLY BROKEN, NOT BOTHERING FOR NOW
    /// --Text adventure game
    /// </summary>
    public class Kernel : Sys.Kernel
    {
        protected override void BeforeRun()
        {
            Console.WriteLine("adamOS booted successfully. Please enter a command bellow.");
            Console.WriteLine("If your not sure what to type, type help for a list of commands!");
        }

        protected override void Run()
        {
            Console.Write("Input: ");
            var input = Console.ReadLine();
            //Checks if the help command has been run
            if (input == "help")
            {
                help();
            }
            else
            //Loads the game
                if (input == "game")
            {
                adventureGameMain.gameMain();
            }
            
        }

        //This is the "help" command
        void help()
        {
            Console.Write("Here are a list of avalible commands:");
            Console.Write("help - shows a list of avalible commands");
            Console.ReadLine();
        }
    }
}
