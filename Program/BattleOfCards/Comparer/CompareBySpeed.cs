using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace BattleOfCards
{
    class CompareBySpeed : IComparer<Player>
    {
        public CompareBySpeed(){}

        public int Compare(Player x, Player y)
        {
            if (x.GetCards().GetTopCard().Speed == y.GetCards().GetTopCard().Speed)
            {
                return 0;
            }
            if (x.GetCards().GetTopCard().Speed < y.GetCards().GetTopCard().Speed)
            {
                return 1;
            }
            return -1;
        }
            
        }
    }
