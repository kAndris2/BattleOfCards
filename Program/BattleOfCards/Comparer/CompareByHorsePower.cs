using System;
using System.Collections.Generic;
using System.Text;

namespace BattleOfCards
{
    public class CompareByHorsePower : IComparer<Player>
    {
        public CompareByHorsePower() { }
        public int Compare(Player x, Player y)
        {
            if (x.GetCards().GetTopCard().HP == y.GetCards().GetTopCard().HP)
            {
                return 0;
            }
            if (x.GetCards().GetTopCard().HP < y.GetCards().GetTopCard().HP)
            {
                return 1;
            }
            return -1;
        }
    }
}
