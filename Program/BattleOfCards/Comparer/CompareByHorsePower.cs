using System;
using System.Collections.Generic;
using System.Text;

namespace BattleOfCards
{
    public class CompareByHorsePower : IComparer<Card>
    {
        public CompareByHorsePower() { }
        public int Compare( Card x, Card y)
        {
            if (x.HP == y.HP)
            {
                return 0;
            }
            if (x.HP > y.HP)
            {
                return 1;
            }
            return -1;
        }
    }
}
