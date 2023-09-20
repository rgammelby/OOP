using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Breeding_Station
{
    /// <summary>
    /// The abstract class <c>Animal</c> provides the baseline for all animals created in the program.
    /// 'Animal's attributes are characteristics that apply to all animals, and all animals inherit the PrintAnimal() method.
    /// </summary>
   
    internal abstract class Animal
    {
        protected string sex;
        protected string type;
        protected bool fur;  // true = has fur, false = has no fur
        protected byte legs;  // leg amount
        protected byte age;  // (human) years

        protected enum Sex { Female, Male }

        protected enum Class { Mammal, Bird }

        public abstract string PrintAnimal();
    }
}
