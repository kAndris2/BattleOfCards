using System;
using System.Collections.Generic;

namespace BattleOfCards
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            List<Card> cardList = new List<Card>();
            Card c1 = new Card();
            Card c2 = new Card();
            cardList.Add(c1);
            cardList.Add(c2);
            foreach (var item in cardList)
            {
                Console.WriteLine(item);

            }
            Console.ReadLine();
            //CardComparer compare = new CardComparer();
            cardList.Sort(new CardComparer());
            foreach (var item in cardList)
            {
                Console.WriteLine(item);

            }
            Console.ReadLine();
        }
    }
}
