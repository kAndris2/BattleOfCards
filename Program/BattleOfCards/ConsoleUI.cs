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
            string detail = StarterPlayer.GetCards().GetTopCard().ToString();
            string[] a = detail.Split('\n');
            Diplay.PrintMenu(new string[] { StarterPlayer.GetName() },"");
            Diplay.PrintLine();
            Diplay.PrintRow(a[0]);
            Diplay.PrintRow(a[1]);
            Diplay.PrintRow(a[2]);
            Diplay.PrintRow(a[3]);
            Diplay.PrintRow(a[4]);
            Diplay.PrintRow(a[5]);
            Diplay.PrintRow(a[6]);
            Diplay.PrintLine();

        }

        public void DisplayEndOfGame(Player player)
        {
            Console.WriteLine("The winner is:{0}",player.GetName());
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
