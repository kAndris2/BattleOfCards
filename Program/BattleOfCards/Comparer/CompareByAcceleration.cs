using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace BattleOfCards
{
    public class CompareByAcceleration : IComparer<Card>
    {
        public CompareByAcceleration() { }
        public int Compare( Card x, Card y)
        {
            if (x.Acceleration == y.Acceleration)
            {
                return 0;
            }
            if (x.Acceleration < y.Acceleration)
            {
                return 1;
            }
            return -1;
        }
    }
}
