using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace BattleOfCards
{
    class ConsoleUI
    {
        Diplay diplay = new Diplay();
        public void DisplayRound(Player StarterPlayer)
        {
            
            string detail = StarterPlayer.GetCards().GetTopCard().ToString();
            string[] a = detail.Split('\n');
            diplay.PrintMenu(new string[] { StarterPlayer.GetName() },"");
            diplay.PrintLine();
            for (int i = 0; i < a.Length; i++)
            {
                diplay.PrintRow(a[i]);
            }
            diplay.PrintLine();
            diplay.PrintFooter(new string[] { "Remaining cards: "+Convert.ToString(StarterPlayer.GetCards().Cards.Count) });
            diplay.PrintLine();

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
                    Console.WriteLine("{0} played with: {1} and the value of {2}",p.GetName(),choose,actCard.GetType().GetProperty(choose).GetValue(actCard, null));
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
