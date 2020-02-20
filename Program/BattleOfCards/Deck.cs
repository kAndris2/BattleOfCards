using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;
using System.IO;

namespace BattleOfCards
{
    public class Deck
    {
        private List<Card> Cards = new List<Card>();
        public CardStat cardstat;

        public Deck()
        {
            Cards = ShuffleCards(LoadCardsFromXml());
            cardstat = new CardStat(Cards);
        }

        public List<Card> GetCards()
        {
            return Cards;
        }

        public void RemoveCard(Card card)
        {
            Cards.Remove(card);
        }

        public int GetNumOfDeck()
        {
            return Cards.Count;
        }

        private List<Card> ShuffleCards(List<Card> cards)
        {
            Random random = new Random();
            List<Card> temp = new List<Card>();

            while (temp.Count != 32)
            {
                int temp_id = random.Next(cards.Count);

                if (!temp.Contains(cards[temp_id]))
                    temp.Add(cards[temp_id]);
            }
            return temp;
        }

        private List<Card> LoadCardsFromXml()
        {
            string Filename = "Cards.xml";

            if (!File.Exists(Filename))
                throw new FileNotFoundException($"File not found! - ('{Filename}')");

            XmlSerializer reader = new XmlSerializer(typeof(List<Card>));
            List<Card> i;

            using (FileStream readfile = File.OpenRead(Filename))
            {
                i = (List<Card>)reader.Deserialize(readfile);
            }
            return i;
        }
    }
}
