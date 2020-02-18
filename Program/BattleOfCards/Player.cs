using System;
using System.Collections.Generic;
using System.Text;

namespace BattleOfCards
{
    abstract class Player
    {
        List<Card> Cards = new List<Card>();
        String Name { get; set; }
        int Id { get; set; }

        public abstract String ChooseAttribute();

        public List<Card> GetCards() { return Cards; }
        public String GetName() { return Name; }
        public int GetId() { return Id; }
    }
}
