using System;
using System.Collections.Generic;
using System.Text;

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
