using System;

namespace BattleOfCards

{
    public class Bot : Player
    {
        public BotLogic logic;

        public Bot(String name, int id) : base(name, id)
        {
            logic = new BotLogic();
        }

        public void AddDeck(Deck deck)
        {
            logic.SetDeck(deck);
        }

        public override Attribute ChooseAttribute()
        {
            string choose = logic.GetBestChoose(GetCards().GetTopCard());
            foreach (Attribute attr in Enum.GetValues(typeof(Attribute)))
            {
                if (choose.Contains(attr.ToString()))
                {
                    return attr;
                }
            }
            
            throw new ArgumentException($"There is no such option! - ('{choose}')");
            /*
            Random random = new Random();
            Array temp = Enum.GetValues(typeof(Attribute));
            return (Attribute)temp.GetValue(random.Next(temp.Length));
            */
        }
    }
}
