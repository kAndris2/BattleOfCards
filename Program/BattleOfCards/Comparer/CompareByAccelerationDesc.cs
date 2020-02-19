using System;
using System.Collections.Generic;
using System.Text;

namespace BattleOfCards
{
    class CompareByAccelerationDesc : IComparer<Player>
    {
       
        public int Compare(Player x, Player y)
        {
            if (x.GetCards().GetTopCard().Acceleration == y.GetCards().GetTopCard().Acceleration)
            {
                return 0;
            }
            if (x.GetCards().GetTopCard().Acceleration > y.GetCards().GetTopCard().Acceleration)
            {
                return 1;
            }
            return -1;
        }
    }
}
