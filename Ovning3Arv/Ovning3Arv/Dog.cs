using System;
using System.Collections.Generic;
using System.Text;

namespace Ovning3Arv
{
    class Dog : Animal
    {
        public Dog(string name, double weight, int age, bool isplayful) : base(name, weight, age)
        {
            IsPlayful = isplayful;
        }

        public bool IsPlayful { get; set; }

        public override string Stats()
        {
            string stats = $"Name: {Name} Weight: {Weight} Age: {Age} Is playful: {(IsPlayful ? "Yes" : "No")}";
            return stats;
        }

        public override string GoodBoy()
        {
            return $"{Name} is a good boy!";
        }
    }
}
