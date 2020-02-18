using System;
using System.Collections.Generic;
using System.Text;

namespace BattleOfCards
{
    public class Human : Player
    {
        public override Attribute ChooseAttribute()
        {
            ConsoleUI ui = new ConsoleUI();
            string input = ui.PrintQuestion("Choose an option.");

            foreach (Attribute attr in Enum.GetValues(typeof(Attribute)))
            {
                if (input == attr.ToString())
                {
                    return attr;
                }
            }
            throw new ArgumentException($"There is no such option! - ('{input}')");
        }
    }
}
