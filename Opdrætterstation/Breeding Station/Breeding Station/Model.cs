using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Breeding_Station
{
    internal class Model
    {
        public const byte FEMALE = 0;
        public const byte MALE = 1;

        public const byte MAMMAL = 0;
        public const byte BIRD = 1;

        BreedingStation bs = new BreedingStation();

        public void InitializeAnimals()
        {
            Animal d = new Dog(FEMALE, MAMMAL, true, 4, 3, "long");
            Animal r = new Rabbit(MALE, MAMMAL, true, 4, 2, "short");
            Animal c = new Chicken(FEMALE, BIRD, false, 2, 5);

            bs.AddAnimal(d);
            bs.AddAnimal(r);
            bs.AddAnimal(c);

            bs.PrintAllAnimals();
        }
    }
}
