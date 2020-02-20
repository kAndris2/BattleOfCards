using System;
using System.Collections.Generic;
using System.Text;

namespace BattleOfCards
{
    public class CardStat
    {
        Dictionary<string, double> Stat = new Dictionary<string, double>
        {
            { "Max_Capacity", 0 },     { "Min_Capacity", 9999 },
            { "Max_Cylinder", 0 },     { "Min_Cylinder", 9999 },
            { "Max_Weight", 0 },       { "Min_Weight", 9999 },
            { "Max_Acceleration", 0 }, { "Min_Acceleration", 9999 },
            { "Max_HP", 0 },           { "Min_HP", 9999 },
            { "Max_Speed", 0 },        { "Min_Speed", 9999 }
        };

        public CardStat(List<Card> cards)
        {
            foreach (Card card in cards)
            {
                if (card.Capacity > Stat["Max_Capacity"])
                    Stat["Max_Capacity"] = card.Capacity;
                if (card.Capacity < Stat["Min_Capacity"])
                    Stat["Min_Capacity"] = card.Capacity;

                if (card.Cylinder > Stat["Max_Cylinder"])
                    Stat["Max_Cylinder"] = card.Cylinder;
                if (card.Cylinder < Stat["Min_Cylinder"])
                    Stat["Min_Cylinder"] = card.Cylinder;

                if (card.Weight > Stat["Max_Weight"])
                    Stat["Max_Weight"] = card.Weight;
                if (card.Weight < Stat["Min_Weight"])
                    Stat["Min_Weight"] = card.Weight;

                if (card.Acceleration > Stat["Max_Acceleration"])
                    Stat["Max_Acceleration"] = card.Acceleration;
                if (card.Acceleration < Stat["Min_Acceleration"])
                    Stat["Min_Acceleration"] = card.Acceleration;

                if (card.HP > Stat["Max_HP"])
                    Stat["Max_HP"] = card.HP;
                if (card.HP < Stat["Min_HP"])
                    Stat["Min_HP"] = card.HP;

                if (card.Speed > Stat["Max_Speed"])
                    Stat["Max_Speed"] = card.Speed;
                if (card.Speed < Stat["Min_Speed"])
                    Stat["Min_Speed"] = card.Speed;
            }
        }

        public Dictionary<string, double> GetStat()
        {
            return Stat;
        }
    }
}
