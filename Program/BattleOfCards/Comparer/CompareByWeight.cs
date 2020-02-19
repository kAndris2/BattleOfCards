using System;
using System.Collections.Generic;
using System.Text;

namespace BattleOfCards
{
    public class CompareByWeight : IComparer<Player>
    {
        public CompareByWeight() { }
        public int Compare(Player x, Player y)
        {
            if (x.GetCards().GetTopCard().Weight == y.GetCards().GetTopCard().Weight)
            {
                return 0;
            }
            if (x.GetCards().GetTopCard().Weight < y.GetCards().GetTopCard().Weight)
            {
                return 1;
            }
            return -1;
        }
    }
}
