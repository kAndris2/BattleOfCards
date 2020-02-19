﻿using System;
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

            RandomProperty random = new RandomProperty();

            for (int i = 0; i < num; i++)
            {
                if (bot_count > 0)
                {
                    GInit.CreatePlayer(new Bot("BOT" + i, random.SetID()));
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

                for (int i = 0; i < temp.Count; i++)
                {
                    GInit.RemovePlayer(temp[i]);
                }

                if (id != 0)
                {
                    StarterPlayer = GInit.GetPlayerById(id);
                    StarterPlayer.GetCards().AddCards(Table.GetCards());
                    Table.ClearCards();
                }
            }
            Display.DisplayEndOfGame(GInit.GetPlayers()[0]);
        }

        public void ShowCard(Player player)
        {
            Console.WriteLine(player.GetCards().GetTopCard().ToString());
        }

        public void ShowCards()
        {
            foreach (Player player in GInit.GetPlayers())
            {
                Display.DisplayRound(player);
            }
        }

        private bool CheckWinner()
        {
            return GInit.GetPlayers().Count == 1;
        }
        public int DefineRoundWinner(List<Player> cardList, string Attribute)
        {
            Comparer comparer1 = new Comparer();
            IComparer<Player> comparer = comparer1.ComparerByAttribute(Attribute, cardList);
            if (comparer.Compare(cardList[1], cardList[0]) == 1)
            {
                return cardList[0].GetId();
            }
            return 0;


        }
    }
}
