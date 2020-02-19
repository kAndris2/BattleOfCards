using System;
using System.Collections.Generic;
using System.Text;

namespace BattleOfCards
{
    public class CompareByCapacity : IComparer<Card>
    {
        public CompareByCapacity() { }
        public int Compare( Card x,  Card y)
        {
            if (x.Capacity == y.Capacity)
            {
                return 0;
            }
            if (x.Capacity > y.Capacity)
            {
                return 1;
            }
            return -1;
        }
    }
}
