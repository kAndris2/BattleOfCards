using System;
using System.Collections.Generic;
using System.Text;

namespace BattleOfCards
{
    public abstract class Player
    {
        HandsOfCards Cards;
        String Name { get; set; }
        int Id { get; set; }

        public abstract Attribute ChooseAttribute();

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

        public HandsOfCards GetCards()
        {
            return Cards;
        }

        public override string ToString()
        {
            return $"ID: {Id}\n" +
                   $"Name: {Name}";
        }

        public enum Attribute
        {
            Name, Acceleration, Speed, Weight, Capacity, Hp, Id
        }
    }
}
