using System;
using System.Collections.Generic;
using System.Text;

namespace BattleOfCards
{
    class GameInit
    {
        private List<Player> Players = new List<Player>();
        public Deck Deck { get; private set; }
        private int HeadCount;

        public GameInit(int count)
        {
            HeadCount = count;
        }

        public void CreateDeck()
        {
            Deck = new Deck();
        }

        public List<Player> GetPlayers()
        {
            return Players;
        }

        public void CreatePlayer(Player player)
        {
            Players.Add(player);
        }

        public void RemovePlayer(Player player)
        {
            Players.Remove(player);
        }

        public void DealCards()
        {
            Random random = new Random();

            foreach (Player player in Players)
            {
                player.AddHandOfCards();
                for (int i = 0; i < Deck.GetNumOfDeck() / HeadCount; i++)
                {
                    int CardID = random.Next(Deck.GetCards().Count);
                    player.AddCardToHand(Deck.GetCards()[CardID]);
                    Deck.RemoveCard(Deck.GetCards()[CardID]);
                }
            }
        }
    }
}
