using System;
using System.Collections.Generic;
using System.Text;

namespace PlayLibrary
{
    public class Card
    {
        public string Name { get; private set; }
        public double Acceleration { get; private set; }
        public int Speed { get; private set; }
        public int Weight { get; private set; }
        public int Capacity { get; private set; }
        public int HP { get; private set; }
        public int Id { get; private set; }

        public Card()
        {
            RandomProperty random = new RandomProperty();

            Name = random.SetName();
            Acceleration = random.SetAcceleration();
            Speed = random.SetSpeed(); 
            Capacity = random.SetCapacity();
            HP = random.SetHP();
            Weight = random.SetWeight();
        }

        public override string ToString()
        {
            return $"Name: {Name}\n" +
                   $"ID: {Id}\n" +
                   $"Acceleration: {Acceleration}sec\n" +
                   $"Speed: {Speed}KM/h\n" +
                   $"Weight: {Weight}KG\n" +
                   $"Capacity: {Capacity} CM3\n" +
                   $"HP: {HP}";
        }
    }
}
