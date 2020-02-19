using System;
using System.Collections.Generic;
using System.Text;

namespace BattleOfCards
{
    class CompareByWeightDesc : IComparer<Player>
    {
        public int Compare(Player x, Player y)
        {
            if (x.GetCards().GetTopCard().Weight == y.GetCards().GetTopCard().Weight)
            {
                return 0;
            }
            if (x.GetCards().GetTopCard().Weight > y.GetCards().GetTopCard().Weight)
            {
                return 1;
            }
            return -1;
        }
    }
}
