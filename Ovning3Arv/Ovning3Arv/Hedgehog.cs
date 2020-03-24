using System;
using System.Collections.Generic;
using System.Text;

namespace Ovning3Arv
{
    class Hedgehog : Animal
    {
        public Hedgehog(string name, double weight, int age, int currentrings) : base(name, weight, age)
        {
            CurrentRings = currentrings;
        }

        public int CurrentRings { get; set; }

        public override string Stats()
        {
            string stats = $"Name: {Name} Weight: {Weight} Age: {Age} Current rings: {CurrentRings}";
            return stats;
        }
    }
}
