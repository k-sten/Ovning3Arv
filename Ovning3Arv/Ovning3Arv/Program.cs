using System;
using System.Collections.Generic;

namespace Ovning3Arv
{
    class Program
    {
        static void Main(string[] args)
        {
            Pelican dinkle = new Pelican { Name = "Dinkle", Weight = 20, Age = 5, NrOfFeathers = 100, BeakVolume = 20 };
            Horse hubert = new Horse { Age = 10, Name = "Hubert", RacesWon = 2, Weight = 800 };
            Dog bert = new Dog { Age = 2, Weight = 50, Name = "Bert", IsPlayful = true };
            Dog charlie = new Dog { Age = 8, Weight = 60, Name = "Charlie", IsPlayful = false };
            Worm macke = new Worm { Age = 1, Length = 9, Name = "Macke", Weight = 0.01 };

            List<Animal> Animals = new List<Animal>
            {
                dinkle,
                hubert,
                bert,
                macke,
                charlie
            };

            foreach (var animal in Animals)
            {
                Console.WriteLine(animal.Name);
            }

            List<Dog> dogs = new List<Dog>();

            //dogs.Add(hubert);


            foreach (var animal in Animals)
            {
                Console.WriteLine(animal.Stats());
                if (animal is Dog) Console.WriteLine(animal.GoodBoy());
            }
            // ARV
            // 3.2 8 Birds-klassen
            // 3.2 9 Animals-klassen


            // POLYMORFISM
            // 3.3.7 De tillhör olika subklasser

            // 3.3.8 Animal, den högtsa klassen som innehåller båda två

            // 3.3.11 Programmet hämtar listan på alla djur i listan 'Animals'. Sen tar den varje djur och använder den abstrakta metoden 'Stats()'
            // Varje subklass har en override som körs och hämtar alla properties och sammanfogar dem i en string

            // 3.3.15 För att komma åt den måste man använda 'Dog'subklassen. Hade man lagt den i 'Animal' så kunde alla komma åt den men det går inte åt andra hållet.

            // 3.3.16 La till en virtual i 'Animals' som returnerar null i de andra subklasserna och en override i 'Dog'. La också till en if som kollar om det är en 'Dog' innan
            // den gör den Console.WriteLine
        }
    }
}
