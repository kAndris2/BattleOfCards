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
            Cards = LoadCardsFromXml();
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

        private List<Card> LoadCardsFromXml()
        {
            XmlSerializer reader = new XmlSerializer(typeof(List<Card>));
            List<Card> i;

            using (FileStream readfile = File.OpenRead("Cards.xml"))
            {
                i = (List<Card>)reader.Deserialize(readfile);
            }
            return i;
        }
    }
}
