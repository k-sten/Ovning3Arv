using System;
using System.Collections.Generic;
using System.Text;

namespace Ovning3Arv
{
    class Horse : Animal
    {
        public Horse(string name, double weight, int age, int raceswon) : base(name, weight, age)
        {
            RacesWon = raceswon;
        }

        public int RacesWon { get; set; }

        public override string Stats()
        {
            string stats = $"Name: {Name} Weight: {Weight} Age: {Age} Races won: {RacesWon}";
            return stats;
        }
    }
}
