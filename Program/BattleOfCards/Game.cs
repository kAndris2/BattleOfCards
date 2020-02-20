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
        int Bot_count { get; set; } = 0;
        int NumberOfPlayers { get; set; } = 0;
        public Game()
        {
            Display = new ConsoleUI();
        }

        public void Start()
        {
            Table = new Table();
            
            DefineNumberOfPlayers();
            GInit = new GameInit(NumberOfPlayers);
            DefinePlayerNames();
            Display.ClearScreen();
            GInit.DealCards();
            StarterPlayer = GInit.GetPlayers()[0];
            PlayRound();
            
            Display.DisplayEndOfGame(GInit.GetPlayers()[0]);
        }
        public void DefineNumberOfPlayers()
        {
            while (true)
            {
                int numberOfPlayers = 0;
                int.TryParse(Display.PrintQuestion("How many players are involved in the game?"), out numberOfPlayers);
                NumberOfPlayers = numberOfPlayers;
                if (NumberOfPlayers <= 1)
                {
                    Display.PrintError("Too few players, min 2!");
                    continue;
                }
                if (NumberOfPlayers > 8)
                {
                    Display.PrintError("Too much player, Max 8!");
                    continue;
                }
                int bot_count = 0;
                if (int.TryParse(Display.PrintQuestion("How many bot participate in the game?"), out bot_count))
                {
                    Bot_count = bot_count;
                }
                else
                {
                    Display.PrintError("Wrong input");
                    continue;
                }
                
                if (Bot_count > NumberOfPlayers)
                {
                    Display.PrintError("Bot count is greater than player count!");
                    continue;
                }
                
                break;
            }
        }
        public void DefinePlayerNames()
        {
            for (int i = 0; i < NumberOfPlayers; i++)
            {
                if (Bot_count > 0)
                {
                    GInit.CreatePlayer(new Bot("BOT_" + (i + 1), i + 1));
                    Bot_count--;
                }
                else
                {
                    string uInput = Display.PrintQuestion("Enter your name: ");
                    if (uInput.Equals(""))
                    {
                        uInput = "Player" + (i + 1);
                    }
                    GInit.CreatePlayer(new Human(uInput, i + 1));
                }
            }
        }
        public void PlayRound()
        {
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
                        Display.PrintGreen("Tie!");
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
