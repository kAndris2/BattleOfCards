using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace PlayLibrary
{
    public class CompareByAcceleration : IComparer
    {
        public CompareByAcceleration() { }
        public int Compare(object obj1, object obj2)
        {
            Card card1 = (Card)obj1;
            Card card2 = (Card)obj2;

            return Compare(card1.Acceleration, card2.Acceleration);
        }
    }
}
