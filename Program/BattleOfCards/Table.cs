using System;
using System.Collections.Generic;
using System.Text;
using PlayLibrary;

namespace BattleOfCards
{
    class Table
    {
        List<Card> Cards = new List<Card>();

        public List<Card> GetCards()
        {
            return Cards;
        }

        public void AddCard(Card card)
        {
            Cards.Add(card);
        }

        public void ClearCards()
        {
            Cards.Clear();
        }
    }
}
