using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace PlayLibrary
{
    public class HandsOfCards : IComparable
    {
        public Queue<Card> Cards { get; set; } = new Queue<Card>();

        public void AddCard(Card card)
        {
            Cards.Enqueue(card);
        }
        public void AddCards(List<Card> cards)
        {
            foreach (var card in cards)
            {
                AddCard(card);
            }
            
        }
        public Card GetTopCard()
        {
            return Cards.Peek();
        }
        public int CompareTo(object a)
        {
            throw new NotImplementedException();
        }
    }
}
