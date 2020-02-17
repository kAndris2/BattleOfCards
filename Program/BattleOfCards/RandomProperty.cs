using System;
using System.Collections.Generic;
using System.Text;

namespace BattleOfCards
{
    class RandomProperty
    {
        private static Random random = new Random();

        public String SetName()
        {
            var brand_list = new List<string>() { "Fiat", "Nissan", "Toyota", "Mitsubishi", "Bmw", "Audi", "Mercedes", "Volkswagen", "Opel", "Mazda",
                                                  "Hyundai", "Hummer", "Corvette", "Crysler", "Ferrari", "Lamborghini", "Bugatti", "Koenigsegg", "Kia",
                                                  "Mclaren", "Trabant", "Jeep", "Volvo", "Subaru", "Mini", "Dodge", "Suzuki", "Porsche", "Acura", "Lada",
                                                  "Peugeot", "Renault", "Ford", "Jaguar", "Maserati", "Saab", "Honda", "Lexus", "Daewoo", "Lancia", "Bentley",
                                                  "Infiniti", "Citroen", "Aston Martin", "Alfa Romeo", "Gmc", "Cadillac", "Land Rover", "Pagani", "Rolls Royce",
                                                  "Tesla", "Dacia", "Chevrolet", "Lincoln", "Lotus", "Mg", "Seat", "Skoda", "Smart"};

            return brand_list[random.Next(brand_list.Count)];
        }

        public double SetAcceleration()
        {
            return random.NextDouble() * (11.42 - 2.11) + 2.11;
        }

        public int SetSpeed()
        {
            return random.Next(100, 290);
        }

        public int SetCapacity()
        {
            return random.Next(1000, 5000);
        }

        public int SetWeight()
        {
            return random.Next(800, 2300);
        }

        public int SetHP()
        {
            return random.Next(80, 300);
        }
    }
}
