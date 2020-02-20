using System;
using System.Collections.Generic;
using System.IO;

namespace BattleOfCards
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                new Game().Start();
            }
            catch (FileNotFoundException e)
            {

                Console.WriteLine(e.Message);
            }
            Console.ReadLine();
        }
        
    }
}
