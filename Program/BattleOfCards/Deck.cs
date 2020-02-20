using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;
using System.IO;

namespace BattleOfCards
{
    class Deck
    {
        private List<Card> Cards = new List<Card>();

        public Deck()
        {
            Cards = ShuffleCards(LoadCardsFromXml());
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

            for (int i = 0; i < cards.Count; i++)
            {
                int temp_id = random.Next(cards.Count);
                temp.Add(cards[temp_id]);
                cards.RemoveAt(temp_id);
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
