using System;
using System.Collections.Generic;
using System.Text;

namespace Ovning3Arv
{
    abstract class Animal
    {

        private string name;
        private double weight;
        private int age;
        public string Name { get => name; set => name = value; }
        public double Weight { get => weight; set => weight = value; }
        public int Age { get => age; set => age = value; }

        public abstract string Stats();
        public virtual string GoodBoy()
        { return null; }
    }
}