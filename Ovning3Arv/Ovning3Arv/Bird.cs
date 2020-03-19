using System;
using System.Collections.Generic;
using System.Text;

namespace Ovning3Arv
{
    class Bird : Animal
    {
        public int NrOfFeathers { get; set; }

        public override string Stats()
        {

            string stats = $"Name: {Name} Weight: {Weight} Age: {Age} Number of feathers: {NrOfFeathers}";
            return stats;
        }
        public override string GoodBoy() { return null; }
    }

    class Pelican : Bird
    {
        public int BeakVolume { get; set; }
    }

    class Flamingo : Bird
    {
        public int NeckLength { get; set; }
    }

    class Swan : Bird
    {
        public bool IsFlying { get; set; }
    }
}
