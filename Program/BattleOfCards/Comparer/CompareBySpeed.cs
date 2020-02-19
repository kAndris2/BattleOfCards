using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace BattleOfCards
{
    class CompareBySpeed : IComparer<Card>
    {
        public CompareBySpeed(){}

        public int Compare([AllowNull] Card x, [AllowNull] Card y)
        {
            if (x.Speed == y.Speed)
            {
                return 0;
            }
            if (x.Speed > y.Speed)
            {
                return 1;
            }
            return -1;
        }
            
        }
    }
