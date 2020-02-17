using System;
using System.Collections.Generic;
using System.Text;

namespace BattleOfCards
{
    class Card
    {
        public string Name { get; private set; }
        public double Acceleration { get; private set; }
        public int Speed { get; private set; }
        public int Weight { get; private set; }
        public int Capacity { get; private set; }

        public Card()
        {
            RandomProperty random = new RandomProperty();

            Name = random.SetName();
            Acceleration = random.SetAcceleration();
            Speed = random.SetSpeed(); 
            Capacity = random.SetCapacity();
        }

        public override string ToString()
        {
            return $"Name: {Name}\n" +
                   $"Acceleration: {Acceleration}\n" +
                   $"Speed: {Speed}\n" +
                   $"Weight: {Weight}\n" +
                   $"Capacity: {Capacity}";
        }
    }
}
