﻿using System;
using System.Collections.Generic;
using System.Text;
using Sys = Cosmos.System;
using adamOS.adventureGame;
//using CoreOSFiles;

namespace adamOS
{
    /// <summary>
    /// This project is based off Cosmos, and is written by Adam "domacikolaci" Knezevic
    /// 
    /// TODO:
    /// IMPORTANT
    /// -Use the kernel as a kernel
    /// --Migrate everything to seperate projects
    /// --Currently not building....
    /// -Begin basic commands
    /// --Help
    /// -Begining code of basic game CURRENTLY BROKEN, NOT BOTHERING FOR NOW
    /// --Text adventure game
    /// -Learn how to do a basic file system
    /// --Make my own version of Vim
    /// --Read/write to files/folders
    /// </summary>
    public class Kernel : Sys.Kernel
    {
        protected override void BeforeRun()
        {
            //Need to install devkit for this to work
            //var fs = new Sys.FileSystem.CosmosVFS();
            //Sys.FileSystem.VFS.VFSManager.RegisterVFS(fs);

            Console.WriteLine("Kernel succesully booted");
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
                //Loads help.cs and talks to the helpList method
                help.helpList();
            }
            else
            //Loads the game - Currently not working
            //Game will load, but did get a crash once u progress
                if (input == "game")
            {
                adventureGameMain.gameMain();
            }
            else
                if (input == "main")
            {
                //CoreOSFiles.mainOSClass.mainClass();
            }
        }
    }
}
