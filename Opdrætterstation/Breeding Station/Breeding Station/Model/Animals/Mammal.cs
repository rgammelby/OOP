using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Breeding_Station
{
    /// <summary>
    /// The abstract class <c>Mammal</c> passes on its base PrintAnimal() method,
    /// and provides the extra characteristic of fur type to animals of the 'Mammal' type.
    /// </summary>
 
    internal abstract class Mammal : Animal
    {
        protected string furType;

        protected enum Fur {  Short, Long }

        public override abstract string PrintAnimal();
    }
}
