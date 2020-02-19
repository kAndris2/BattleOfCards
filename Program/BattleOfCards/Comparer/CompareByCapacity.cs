using System;
using System.Collections.Generic;
using System.Text;

namespace BattleOfCards
{
    public class CompareByCapacity : IComparer<Player>
    {
        public CompareByCapacity() { }
        public int Compare(Player x, Player y)
        {
            if (x.GetCards().GetTopCard().Capacity == y.GetCards().GetTopCard().Capacity)
            {
                return 0;
            }
            if (x.GetCards().GetTopCard().Capacity < y.GetCards().GetTopCard().Capacity)
            {
                return 1;
            }
            return -1;
        }
    }
}
