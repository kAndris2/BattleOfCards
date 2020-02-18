using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace BattleOfCards
{
    class CardComparer : IComparer<Card>
    {
        public CardComparer()
        {
        }

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
            //public override int Compare([AllowNull] Card x, [AllowNull] Card y)
            //{
            //    if (x.Speed == y.Speed)
            //    {
            //        return 0;
            //    }
            //    if (x.Speed > y.Speed)
            //    {
            //        return 1;
            //    }
            //    return -1;
            //}

        }
    }
