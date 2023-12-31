﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Breeding_Station
{
    /// <summary>
    /// The class <c>BreedingStation</c> is used for storing and printing information about the program's Animal objects.
    /// </summary>
  
    internal class BreedingStation
    {
        protected List<Animal> animals;
        protected List<Dog> dogs;
        protected List<Rabbit> rabbits;
        protected List<Chicken> chickens;

        public BreedingStation()
        {
            animals = new List<Animal>();
            dogs = new List<Dog>();
            rabbits = new List<Rabbit>();
            chickens = new List<Chicken>();
        }

        // adds a new animal to the breeding station's overall animal directory
        // automatically adds the animal to its own type list
        public void AddAnimal(Animal animal)
        {
            animals.Add(animal);

            if (animal is Dog)
            {
                dogs.Add((Dog)animal);
            }
            else if (animal is Rabbit)
            {
                rabbits.Add((Rabbit)animal);
            }
            else if (animal is Chicken)
            {
                chickens.Add((Chicken)animal);
            }
        }

        // prints the contents of the breeding station's general animal directory
        public void PrintAllAnimals()
        {
            foreach (Animal a in animals)
            {
                Console.WriteLine($"{a.PrintAnimal()}");
            }
        }

        // prints all dogs
        public void PrintAllDogs()
        {
            foreach (Dog d in dogs)
            {
                Console.WriteLine(d.PrintAnimal());
            }
        }

        // prints all rabbits
        public void PrintAllRabbits()
        {
            foreach (Rabbit r in rabbits)
            {
                Console.WriteLine(r.PrintAnimal());
            }
        }

        // prints all chickens
        public void PrintAllChickens()
        {
            foreach (Chicken c in chickens)
            {
                Console.WriteLine(c.PrintAnimal());
            }
        }
    }
}
