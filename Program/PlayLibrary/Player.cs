using System;
using System.Collections.Generic;
using System.Text;

namespace PlayLibrary
{
    public abstract class Player
    {
        HandsOfCards Cards;
        String Name { get; set; }
        int Id { get; set; }

        public abstract String ChooseAttribute();

        public String GetName() { return Name; }
        public int GetId() { return Id; }
        
        public void AddHandOfCards()
        {
            Cards = new HandsOfCards();
        }

        public void AddCardToHand(Card card)
        {
            Cards.AddCard(card);
        }

        public override string ToString()
        {
            return $"ID: {Id}\n" +
                   $"Name: {Name}";
        }
    }
}
