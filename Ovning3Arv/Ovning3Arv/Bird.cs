using System;
using System.Collections.Generic;
using System.Text;

namespace Ovning3Arv
{
    class Bird : Animal
    {
        public Bird(string name, double weight, int age, int nroffeathers) : base(name, weight, age)
        {
            NrOfFeathers = nroffeathers;
        }

        public int NrOfFeathers { get; set; }

        public override string Stats()
        {
            string stats = $"Name: {Name} Weight: {Weight} Age: {Age} Number of feathers: {NrOfFeathers}";
            return stats;
        }
    }

    class Pelican : Bird
    {
        public Pelican(string name, double weight, int age, int nroffeathers, int beakvolume) : base(name, weight, age, nroffeathers)
        {
            BeakVolume = beakvolume;
        }

        public int BeakVolume { get; set; }
    }

    class Flamingo : Bird
    {
        public Flamingo(string name, double weight, int age, int nroffeathers, int necklength) : base(name, weight, age, nroffeathers)
        {
            NeckLength = necklength;
        }

        public int NeckLength { get; set; }
    }

    class Swan : Bird
    {
        public Swan(string name, double weight, int age, int nroffeathers, bool isflying) : base(name, weight, age, nroffeathers)
        {
            IsFlying = isflying;
        }

        public bool IsFlying { get; set; }
    }
}
