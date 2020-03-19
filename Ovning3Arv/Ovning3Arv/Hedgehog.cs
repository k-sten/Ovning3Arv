using System;
using System.Collections.Generic;
using System.Text;

namespace Ovning3Arv
{
    class Hedgehog : Animal
    {
        public int CurrentRings { get; set; }

        public override string Stats()
        {

            string stats = $"Name: {Name} Weight: {Weight} Age: {Age} Current rings: {CurrentRings}";
            return stats;
        }
        public override string GoodBoy() { return null; }
    }
}
