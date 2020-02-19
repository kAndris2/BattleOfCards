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
            int num = int.Parse(Display.PrintQuestion("How many players are involved in the game?"));

            if (num <= 1 || num > 8)
                throw new ArgumentException("Too much player, Max 8!");

            GInit = new GameInit(num);
            StarterPlayer = GInit.GetPlayers()[0];

            while (!CheckWinner())
            {
                Display.DisplayRound(StarterPlayer);
                Display.GetProperties(StarterPlayer);
                string choose = StarterPlayer.ChooseAttribute().ToString();
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
