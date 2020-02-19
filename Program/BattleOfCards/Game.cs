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
            int num, bot_count;

            while (true)
            {
                num = int.Parse(Display.PrintQuestion("How many players are involved in the game?"));

                if (num <= 1 || num > 8)
                {
                    Display.PrintError("Too much player, Max 8!");
                    continue;
                }

                bot_count = int.Parse(Display.PrintQuestion("How many bot participate in the game?"));

                if (bot_count > num)
                {
                    Display.PrintError("Bot count is greater than player count!");
                    continue;
                }
                break;
            }

            GInit = new GameInit(num);
            GInit.CreateDeck();

            RandomProperty random = new RandomProperty();

            for (int i = 0; i < num; i++)
            {
                if (bot_count > 0)
                {
                    GInit.CreatePlayer(new Bot(Display.PrintQuestion("BOT" + i), random.SetID()));
                    bot_count--;
                }
                else
                    GInit.CreatePlayer(new Human(Display.PrintQuestion("Enter your name:"), random.SetID()));
            }

            GInit.DealCards();
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
        public static int DefineRoundWinner(List<Card> cardList)
        {
            Comparer comparer1 = new Comparer();
            IComparer<Card> comparer = comparer1.ComparerByAttribute("Speed", cardList);
            if (comparer.Compare(cardList[1], cardList[0]) == 1)
            {
                return cardList[0].Id;
            }
            return 0;


        }
    }
}
