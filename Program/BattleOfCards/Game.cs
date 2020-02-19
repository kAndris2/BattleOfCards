using System;
using System.Collections.Generic;
using System.Text;

namespace BattleOfCards
{
    class Game
    {
        GameInit Ginit;
        Table Table;
        ConsoleUI Display;

        public Game()
        {
            Display = new ConsoleUI();
        }

        public void Start()
        {

        }

        public void ShowCard(Player player)
        {
            Console.WriteLine(player.GetCards().GetTopCard().ToString());
        }

        public void ShowCards()
        {
            foreach (Player player in Ginit.GetPlayers())
            {
                Console.WriteLine(player.GetCards().GetTopCard().ToString());
            }
        }

        private bool CheckWinner()
        {
            return false;
        }
    }
}
