using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace BattleOfCards
{
    class ConsoleUI
    {
        public void DisplayRound(Player StarterPlayer)
        {
            Console.WriteLine(StarterPlayer.GetCards().GetTopCard().ToString());
            //PrintQuestion("Wich property would u wanna play with?");
        }

        public void DisplayEndOfGame()
        {
            
        }
        public void GetCardsData(Player p, string choose)
        {
            HandsOfCards cards = p.GetCards();
            Card actCard = cards.GetTopCard();
           
            foreach (var propertyInfo in actCard.GetType().GetProperties())
            {
                if (propertyInfo.Name.Equals(choose))
                {
                    Console.WriteLine("{0} : {1}",choose,actCard.GetType().GetProperty(choose).GetValue(actCard, null));
                    
                    continue;
                }
                
            }
        }
        
        public void PrintCommand(string command)
        {
            Console.WriteLine(command);
        }
        
        public string PrintQuestion(string question)
        {
            
            string answer;
            WriteGreen(question);
            Console.Write("Ans: ");
            answer = Console.ReadLine();           
            return answer;
        }

        public void PrintError(string error)
        {
            string err = "ERROR: ";
            WriteRed(err+error);
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
