using System;
using System.Collections.Generic;
using System.Text;
using Sys = Cosmos.System;
namespace adamOS
{
    /// <summary>
    /// This project is based off Cosmos, and is written by Adam "domacikolaci" Knezevic
    /// 
    /// TODO:
    /// IMPORTANT
    /// -Begin basic commands
    /// --Help
    /// -Begining code of basic game
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
            
        }

        //This is the "help" command
        void help()
        {
            Console.Write("lmao");
            Console.ReadLine();
        }
    }
}
