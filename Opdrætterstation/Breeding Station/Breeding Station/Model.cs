using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Breeding_Station
{
    /// <summary>
    /// The class <c>Model</c> contains a method for initializing one of each animal.
    /// This is where data is handled, and the animals are passed into the BreedingStation.
    /// </summary>
   
    internal class Model
    {
        public const byte FEMALE = 0;
        public const byte MALE = 1;

        public const byte MAMMAL = 0;
        public const byte BIRD = 1;

        public const byte SHORT = 0;
        public const byte LONG = 1;

        BreedingStation bs = new BreedingStation();

        public void InitializeAnimals()
        {
            // sex, type (class), fur, legs #, years #, fur length (if any)
            Animal d = new Dog(FEMALE, MAMMAL, true, 4, 3, LONG);
            Animal r = new Rabbit(MALE, MAMMAL, true, 4, 2, SHORT);
            Animal c = new Chicken(FEMALE, BIRD, false, 2, 5);

            bs.AddAnimal(d);
            bs.AddAnimal(r);
            bs.AddAnimal(c);

            bs.PrintAllAnimals();
        }
    }
}
