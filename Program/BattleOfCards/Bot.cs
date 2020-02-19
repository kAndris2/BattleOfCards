using System;
using System.Collections.Generic;
using System.Text;

namespace BattleOfCards

{
    public class Bot : Player
    {
        public Bot(String name, int id) : base(name, id)
        {
        }

        public override Attribute ChooseAttribute()
        {
            Random random = new Random();
            Array temp = Enum.GetValues(typeof(Attribute));
            return (Attribute)temp.GetValue(random.Next(temp.Length));
        }
    }
}
