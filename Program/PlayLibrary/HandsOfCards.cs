using System;
using System.Collections.Generic;
using System.Text;

namespace PlayLibrary
{
    public class HandsOfCards
    {
        public List<Card> Cards { get; set; } = new List<Card>();

        public void AddCards(List<Card> cards)
        {
            foreach (var card in cards)
            {
                Cards.Add(card);
            }
            
        }
        public Card GetTopCard()
        {

        }
        
    }
}
