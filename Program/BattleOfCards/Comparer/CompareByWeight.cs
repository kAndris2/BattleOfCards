using System;
using System.Collections.Generic;
using System.Text;

namespace BattleOfCards
{
    public class CompareByWeight : IComparer<Card>
    {
        public CompareByWeight() { }
        public int Compare(Card x, Card y)
        {
            if (x.Weight == y.Weight)
            {
                return 0;
            }
            if (x.Weight > y.Weight)
            {
                return 1;
            }
            return -1;
        }
    }
}
