using System;
using System.Collections.Generic;
using System.Text;

namespace BattleOfCards
{
    class Player
    {
        List<Card> Cards = new List<Card>();
        String Name { get; set; }

        public Player()
        {
        }

        public List<Card> GetCards() { return Cards; }
        public String GetName() { return Name;  }
    }
}
