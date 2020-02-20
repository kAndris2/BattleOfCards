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
                num = 0;
                int.TryParse(Display.PrintQuestion("How many players are involved in the game?"), out num);

                if (num <= 1 )
                {
                    Display.PrintError("Too few players, min 2!");
                    continue;
                }

                if (num > 8)
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

            for (int i = 0; i < num; i++)
            {
                if (bot_count > 0)
                {
                    GInit.CreatePlayer(new Bot("BOT_" + i, i+1));
                    bot_count--;
                }
                else
                    GInit.CreatePlayer(new Human(Display.PrintQuestion("Enter your name:"), i));
            }
            Display.ClearScreen();
            GInit.DealCards();
            StarterPlayer = GInit.GetPlayers()[0];

            while (!CheckWinner())
            {
                try
                {
                    Display.DisplayRound(StarterPlayer);
                    string choose = StarterPlayer.ChooseAttribute().ToString();

                    int id = DefineRoundWinner(GInit.GetPlayers(), choose);
                    List<Player> temp = new List<Player>();

                    foreach (Player player in GInit.GetPlayers())
                    {
                        Display.GetCardsData(player, choose);
                        Table.AddCard(player.GetCards().GetTopCard());
                        player.GetCards().RemoveCard();

                        if (player.GetCards().Cards.Count == 0)
                            temp.Add(player);
                        
                    }

                    if (id != 0)
                    {
                        StarterPlayer = GInit.GetPlayerById(id);
                        StarterPlayer.GetCards().AddCards(Table.GetCards());
                        Table.ClearCards();
                        Display.PrintGreen(Display.PrintRoundWinner(StarterPlayer));
                        Display.WaitForKeypress();
                        Display.ClearScreen();
                    }
                    else
                    {
                        Display.PrintGreen("Döntetlen!");
                        Display.WaitForKeypress();
                        Display.ClearScreen();
                    }

                    foreach (Player player in temp)
                    {
                        if (player.GetCards().Cards.Count == 0)
                        {
                            Display.PrintPlayerOut(player);
                            GInit.RemovePlayer(player);
                        }
                    }
                }
                catch (ArgumentException inputError)
                {
                    Display.PrintError(inputError.Message);
                }
            }
            Display.DisplayEndOfGame(GInit.GetPlayers()[0]);
        }

        private bool CheckWinner()
        {
            return GInit.GetPlayers().Count == 1;
        }
        public int DefineRoundWinner(List<Player> PlayerList, string Attribute)
        {
            Comparer comparer1 = new Comparer();
            IComparer<Player> comparer = comparer1.ComparerByAttribute(Attribute, PlayerList);
            if (comparer.Compare(PlayerList[1], PlayerList[0]) == 1)
            {
                return PlayerList[0].GetId();
            }
            return 0;
        }
    }
}
