using System;
using System.Collections.Generic;
using System.Text;

namespace Ovning3Arv
{
    class Worm : Animal
    {
        public Worm(string name, double weight, int age, int length) : base(name, weight, age)
        {
            Length = length;
        }

        public int Length { get; set; }

        public override string Stats()
        {
            string stats = $"Name: {Name} Weight: {Weight} Age: {Age} Lenght: {Length}";
            return stats;
        }
    }
}
