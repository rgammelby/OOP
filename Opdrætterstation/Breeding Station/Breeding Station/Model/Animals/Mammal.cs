using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Breeding_Station
{
    internal abstract class Mammal : Animal
    {
        protected string furtype;

        public override abstract string PrintAnimal();
    }
}
