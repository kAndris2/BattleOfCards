using System;
using System.Collections.Generic;
using System.Text;

namespace PlayLibrary
{
    public class Human : Player
    {
        public override string ChooseAttribute(List<string> options)
        {
            //ShowOptions
            string input = Console.ReadLine();

            if (!options.Contains(input))
                throw new ArgumentException($"There is no such option! - ('{input}')");

            return input;
        }
    }
}
