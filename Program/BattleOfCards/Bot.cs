using System;
using System.Collections.Generic;
using System.Text;

namespace BattleOfCards

{
    public class Bot : Player
    {
        public override string ChooseAttribute(List<string> options)
        {
            Random random = new Random();
            return options[random.Next(options.Count)];
        }
    }
}
