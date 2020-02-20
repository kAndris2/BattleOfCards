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
            Deck = new Deck();
        }

        public List<Player> GetPlayers()
        {
            return Players;
        }

        public Player GetPlayerById(int id)
        {
            foreach(Player player in Players)
            {
                if (player.GetId() == id)
                    return player;
            }
            return null;
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
            foreach (Player player in Players)
            {
                player.AddHandOfCards();
                for (int i = 0; i < Deck.GetNumOfDeck() / HeadCount; i++)
                {
                    player.AddCardToHand(Deck.GetCards()[0]);
                    Deck.RemoveCard(Deck.GetCards()[0]);
                }
            }
        }
    }
}
