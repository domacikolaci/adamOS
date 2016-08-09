using System;
using System.Collections.Generic;
using System.Text;

namespace adamOS
{
    internal class help
    {
        public static void helpList()
        {
            Console.Write("Here are a list of avalible commands:");
            Console.Write("help - shows a list of avalible commands");
            Console.Write("game - loads a text based adventure game");
            Console.ReadLine();
        }
    }
}