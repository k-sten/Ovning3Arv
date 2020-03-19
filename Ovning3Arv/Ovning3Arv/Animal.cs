using System;
using System.Collections.Generic;
using System.Text;

namespace Ovning3Arv
{
    abstract class Animal
    {
        //3.2 8 Birds-klassen
        //3.2 9 Animals-klassen
        private string name;
        private double weight;
        private int age;
        public string Name { get => name; set => name = value; }
        public double Weight { get => weight; set => weight = value; }
        public int Age { get => age; set => age = value; }

        public abstract string Stats();
        public abstract string GoodBoy();
    }
}