﻿using System;
using System.IO;

namespace BattleOfCards
{
    class Program
    {
        static void Main(string[] args)
        {
            bool exit = false;
            bool err = false;
            try
            {
                do
                {
                    if (!err)
                    {
                        new Game().Start();
                    }

                    string ans = new ConsoleUI().PrintQuestion("Do you want to play another? (y/n)");

                    if (ans.ToLower() == "y")
                    {
                        err = false;
                        continue;
                    }
                    else if (ans.ToLower() == "n")
                    {
                        exit = true;
                    }
                    else
                    {
                        new ConsoleUI().PrintError("No such option! (y/n)");
                        err = true;
                    }
                } while (!exit);
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
