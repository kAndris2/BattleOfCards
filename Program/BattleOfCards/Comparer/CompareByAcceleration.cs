using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace BattleOfCards
{
    public class CompareByAcceleration : IComparer<Player>
    {
        public CompareByAcceleration() { }
        public int Compare( Player x, Player y)
        {
            if (x.GetCards().GetTopCard().Acceleration == y.GetCards().GetTopCard().Acceleration)
            {
                return 0;
            }
            if (x.GetCards().GetTopCard().Acceleration < y.GetCards().GetTopCard().Acceleration)
            {
                return 1;
            }
            return -1;
        }
    }
}
