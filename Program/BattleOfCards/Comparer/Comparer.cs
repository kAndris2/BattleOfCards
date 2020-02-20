using System;
using System.Collections.Generic;
using System.Text;

namespace BattleOfCards
{
    public class Comparer
    {
        public IComparer<Player> ComparerByAttribute(String att, List<Player> PlayerList)
        {
            if (att.ToLower() == "Speed".ToLower())
            {
                PlayerList.Sort(new CompareBySpeed());
                return new CompareBySpeed();

            }
            else if (att.ToLower() == "Acceleration".ToLower())
            {
                PlayerList.Sort(new CompareByAcceleration());
                PlayerList.Reverse();
                return new CompareByAccelerationDesc();
            }
            else if (att.ToLower() == "Capacity".ToLower())
            {
                PlayerList.Sort(new CompareByCapacity());
                return new CompareByCapacity();
            }
            else if (att.ToLower() == "HP".ToLower())
            {
                PlayerList.Sort(new CompareByHorsePower());
                return new CompareByHorsePower();
            }
            else if (att.ToLower() == "Weight".ToLower())
            {
                PlayerList.Sort(new CompareByWeight());
                PlayerList.Reverse();
                return new CompareByWeightDesc();
            }
            else if (att.ToLower() == "Cylinder".ToLower())
            {
                PlayerList.Sort(new CompareByNumberOfCylinders());
                return new CompareByNumberOfCylinders();
            }
            else
            {
                throw new Exception();
            }
        }
    }
}
