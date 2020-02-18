using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace PlayLibrary
{
    class CardComparer : Comparer<Card>
    {
        public override int Compare([AllowNull] Card x, [AllowNull] Card y)
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
