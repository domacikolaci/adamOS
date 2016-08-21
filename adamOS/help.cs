using System;
using System.Collections.Generic;
using System.Text;

namespace adamOS
{
    internal class help
    {
        public static void helpList()
        {
            Console.WriteLine("Here are a list of avalible commands:");
            Console.WriteLine("help - shows a list of avalible commands");
            Console.WriteLine("game - loads a text based adventure game");
            Console.ReadLine();
        }
    }
}