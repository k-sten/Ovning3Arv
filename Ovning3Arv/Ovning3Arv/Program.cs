using System;
using System.Collections.Generic;

namespace Ovning3Arv
{
    class Program
    {
        static void Main(string[] args)
        {
            Pelican pelle = new Pelican("Pelle", 20, 5, 100, 20);
            Horse hubert = new Horse("Hubert", 800, 10, 2);
            Dog bert = new Dog("Bert", 50, 2, true);
            Dog charlie = new Dog("Charlie", 60, 8, false);
            Worm macke = new Worm("Macke", 0.01, 1, 9);
            Hedgehog sune = new Hedgehog("Sune", 5, 3, 96);
            Swan pippi = new Swan("Pippi", 20, 6, 120, true);
            Flamingo snorken = new Flamingo("Snorken", 17, 9, 51, 44);

            List<Animal> Animals = new List<Animal>
            {
                pelle,
                hubert,
                bert,
                macke,
                charlie,
                sune,
                pippi,
                snorken
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
