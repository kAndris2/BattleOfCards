using System;
using System.Collections.Generic;
using System.Text;

namespace BattleOfCards
{
    public class BotLogic
    {
        Deck deck;

        public void SetDeck(Deck deck)
        {
            this.deck = deck;
        }

        public String GetBestChoose(Card card)
        {
            Dictionary<string, double> stat = deck.cardstat.GetStat();
            Dictionary<string, double> chance = new Dictionary<string, double>();
            chance.Add("Capacity" , (card.Capacity - stat["Min_Capacity"]) / (stat["Max_Capacity"] - stat["Min_Capacity"])*100);
            chance.Add("Cylinder", 100-((card.Cylinder - stat["Min_Cylinder"]) / (stat["Max_Cylinder"] - stat["Min_Cylinder"])) * 100);
            chance.Add("Weight", 100-((card.Weight - stat["Min_Weight"]) / (stat["Max_Weight"] - stat["Min_Weight"])) * 100);
            chance.Add("Acceleration", 80-((card.Acceleration - stat["Min_Acceleration"]) / (stat["Max_Acceleration"] - stat["Min_Acceleration"])) * 100);
            chance.Add("HP", (card.HP - stat["Min_HP"]) / (stat["Max_HP"] - stat["Min_HP"]) * 100);
            chance.Add("Speed", (card.Speed - stat["Min_Speed"]) / (stat["Max_Speed"] - stat["Min_Speed"]) * 100);
            
            double max = 0;
            string name = "";
            foreach (var item in chance)
            {
                if (item.Value > max)
                {
                    max = item.Value;
                    name = item.Key;
                }
            }

            return name;

        }
    }
}
