using System;
using System.Collections.Generic;
using System.Text;

namespace BattleOfCards
{
    class Game
    {
        private GameInit GInit;
        private Table Table;
        private ConsoleUI Display;
        private Player StarterPlayer;

        public Game()
        {
            Display = new ConsoleUI();
        }

        public void Start()
        {
            Table = new Table();
            GInit = new GameInit(int.Parse(Display.PrintQuestion("How many players are involved in the game?")));
            StarterPlayer = GInit.GetPlayers()[0];

            while (!CheckWinner())
            {
                Display.DisplayRound(StarterPlayer);
            }
        }

        public void ShowCard(Player player)
        {
            Console.WriteLine(player.GetCards().GetTopCard().ToString());
        }

        public void ShowCards()
        {
            foreach (Player player in GInit.GetPlayers())
            {
                Console.WriteLine(player.GetCards().GetTopCard().ToString());
            }
        }

        private bool CheckWinner()
        {
            return GInit.GetPlayers().Count == 1;
        }
    }
}
