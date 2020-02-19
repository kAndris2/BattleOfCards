using System;
using System.Collections.Generic;
using System.Text;

namespace BattleOfCards
{
    public class Comparer
    {
        public IComparer<Player> ComparerByAttribute(String att, List<Player> cardList)
        {
            if (att == "Speed")
            {
                cardList.Sort(new CompareBySpeed());
                return new CompareBySpeed();

            }
            else if (att == "Acceleration")
            {
                cardList.Sort(new CompareByAcceleration());
                cardList.Reverse();
                return new CompareByAccelerationDesc();
            }
            else if (att == "Capacity")
            {
                cardList.Sort(new CompareByCapacity());
                return new CompareByCapacity();
            }
            else if (att == "HP")
            {
                cardList.Sort(new CompareByHorsePower());
                return new CompareByHorsePower();
            }
            else if (att == "Weight")
            {
                cardList.Sort(new CompareByWeight());
                cardList.Reverse();
                return new CompareByWeightDesc();
            }
            else
            {
                throw new Exception();
            }
        }
    }
}
