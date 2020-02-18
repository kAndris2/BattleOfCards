using System;
using System.Collections.Generic;
using System.Text;
using PlayLibrary;

namespace BattleOfCards
{
    class ConsoleUI
    {
        public void DisplayRound()
        {

        }

        public void DisplayEndOfGame()
        {
            
        }
        public void GetProperties(Card card)
        {
            List<Card> cardProperties = new List<Card>();
            cardProperties.Add(card);
            Type t = typeof(Card);
            int i = 0;
            foreach (var prop in t.GetProperties())
            {
                if (i % 2 == 0)
                {
                    Console.Write(prop.Name);
                }
                else { Console.WriteLine("\t{0} ", prop.Name); }
                i++;
            }
        }

        public string PrintQuestion(string question)
        {
            string answer;
            WriteGreen(question);
            answer = Console.ReadLine();
            return answer;
        }

        public void PrintError(string error)
        {
            WriteRed(error);
        }
        private void WriteGreen(string value)
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(value.PadRight(Console.WindowWidth - 1));
            Console.ResetColor();
        }

        private void WriteRed(string value)
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(value.PadRight(Console.WindowWidth - 1));
            Console.ResetColor();
        }


    }
}
