using System;
using System.Collections.Generic;
using System.Text;

namespace BattleOfCards
{
    class Deck
    {
        private const int NumOfDeck = 32;
        private List<Card> Cards = new List<Card>();

        public Deck()
        {
            for (int i = 0; i < NumOfDeck; i++)
            {
                Cards.Add(new Card());
            }
        }

        public List<Card> GetCards()
        {
            return Cards;
        }

        public void RemoveCard(Card card)
        {
            Cards.Remove(card);
        }

        public int GetNumOfDeck()
        {
            return NumOfDeck;
        }
    }
}
