﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BattleOfCards
{
    public class Human : Player
    {
        public Human(String name, int id) : base(name, id)
        {
        }

        public override Attribute ChooseAttribute()
        {
            ConsoleUI ui = new ConsoleUI();
            string input = ui.PrintQuestion("Choose an option.");

            foreach (Attribute attr in Enum.GetValues(typeof(Attribute)))
            {
                if (input.ToLower() == attr.ToString().ToLower())
                {
                    return attr;
                }
            }
            new ConsoleUI().ClearScreen();
            throw new ArgumentException($"There is no such option! - ('{input}')");
        }
    }
}
