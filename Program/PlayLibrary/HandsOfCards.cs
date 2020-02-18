using System;
using System.Collections.Generic;
using System.Text;

namespace PlayLibrary
{
    public class HandsOfCards
    {
        public Queue<Card> Cards { get; set; } = new Queue<Card>();

        public void AddCards(List<Card> cards)
        {
            foreach (var card in cards)
            {
                Cards.Enqueue(card);
            }
            
        }
        public Card GetTopCard()
        {
            return Cards.Peek();
        }
        
    }
}
