using System;
using System.Collections.Generic;
using System.Text;

namespace BattleOfCards
{
    class CompareByNumberOfCylinders : IComparer<Player>
    {
        public int Compare(Player x, Player y)
        {
            if (x.GetCards().GetTopCard().Cylinder == y.GetCards().GetTopCard().Cylinder)
            {
                return 0;
            }
            if (x.GetCards().GetTopCard().Cylinder < y.GetCards().GetTopCard().Cylinder)
            {
                return 1;
            }
            return -1;
        }
    }
}
