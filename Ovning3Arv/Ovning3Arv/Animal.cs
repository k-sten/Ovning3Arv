using System;
using System.Collections.Generic;
using System.Text;

namespace Ovning3Arv
{
    abstract class Animal
    {
        public Animal(string name, double weight, int age)
        {
            Name = name;
            Weight = weight;
            Age = age;
        }

        public string Name { get; set; }
        public double Weight { get; set; }
        public int Age { get; set; }

        public abstract string Stats();
        public virtual string GoodBoy()
        { return null; }
    }
}