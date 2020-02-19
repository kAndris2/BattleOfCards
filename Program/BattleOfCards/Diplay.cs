using System;
using System.Collections.Generic;
using System.Text;

namespace BattleOfCards
{
    public class Diplay
    {
        static int tableWidth = 25;
        public static void PrintLine()
        {
            Console.WriteLine("o{0}o",new string('-', tableWidth-1));
        }
        public static void PrintRow(params string[] columns)
        {
            int width = (tableWidth - columns.Length) / columns.Length;
            string row = "|";

            foreach (string column in columns)
            {
                row += AlignCentre(column, width) + "|";
            }

            Console.WriteLine(row);
        }
        public static string AlignCentre(string text, int width)
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

        public static void PrintMenu(string[] options, string title)
        {
            //Console.WriteLine(title + ":");
            string tabs = new String('-', tableWidth-1);
            Console.WriteLine("o{0}o", tabs);
            for (int i = 0; i < options.Length; i++)
            {
                //Console.WriteLine("|\t{0}. {1}{2}|", i + 1, options[i],new string(' ',10));
                Console.WriteLine("|{0}|",AlignCentre(options[i], tableWidth-1));
            }
            //Console.WriteLine("\tq. Quit");
        }
    }
}
