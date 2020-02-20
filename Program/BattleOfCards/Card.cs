using System;
using System.Collections.Generic;
using System.Text;

namespace BattleOfCards
{
    public class Card
    {
        public string Name { get; set; }
        public double Acceleration { get; set; }
        public int Speed { get; set; }
        public int Weight { get; set; }
        public int Capacity { get; set; }
        public int HP { get; set; }
        public string Id { get; set; }
        public int Cylinder { get; set; }

        public Card() { }

        public override string ToString()
        {
            return $"Name: {Name}\n" +
                   $"ID: #{Id}\n" +
                   $"Acceleration: {Acceleration}sec\n" +
                   $"Speed: {Speed}KM/h\n" +
                   $"Weight: {Weight}KG\n" +
                   $"Capacity: {Capacity}CM3\n" +
                   $"HP: {HP}\n" +
                   $"Cylinder: {Cylinder}\n";
        }
    }
}
