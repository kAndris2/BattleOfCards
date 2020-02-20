using System;
using System.Collections.Generic;
using System.Text;

namespace BattleOfCards
{
    public class Diplay
    {
        static readonly int tableWidth = 45;
        public void PrintLine()
        {
            Console.WriteLine("o{0}o",new string('-', tableWidth-1));
        }
        public void PrintRow(params string[] columns)
        {
            int width = (tableWidth - columns.Length) / columns.Length;
            string row = "|";

            foreach (string column in columns)
            {
                row += AlignCentre(column, width) + "|";
            }
            Console.WriteLine(row);
        }
        public void PrintMenu(string[] options, string title)
        {
            string tabs = new String('-', tableWidth-1);
            Console.WriteLine("o{0}o", tabs);

            for (int i = 0; i < options.Length; i++)
            {
                Console.WriteLine("|{0}|",AlignCentre(options[i], tableWidth-1));
            }
        }
        public void PrintFooter(string[] options)
        {
            string tabs = new String('-', tableWidth - 1);

            for (int i = 0; i < options.Length; i++)
            {
                Console.WriteLine("|{0}|", AlignCentre(options[i], tableWidth - 1));
            }
        }
        private string AlignCentre(string text, int width)
        {
            text = text.Length > width ? text.Substring(0, width - 3) + "..." : text;

            if (string.IsNullOrEmpty(text))
            {
                return new string(' ', width);
            }
            else
            {
                return text.PadRight(width - (width - text.Length) / 2).PadLeft(width);
            }
        }
    }
}
