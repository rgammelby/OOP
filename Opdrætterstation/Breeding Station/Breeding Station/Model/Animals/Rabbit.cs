using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Breeding_Station
{
    /// <summary>
    /// The class <c>Rabbit</c> contains a constructor to create a rabbit,
    /// and a method that allows the user to see all given characteristics of the rabbit.
    /// </summary>

    internal class Rabbit : Mammal
    {
        public Rabbit(byte bSex, byte bClass, bool bFur, byte bLegs, byte bAge, byte sFurType)
        {
            sex = ((Sex)bSex).ToString();
            type = ((Class)bClass).ToString();
            fur = bFur;
            legs = bLegs;
            age = bAge;
            furType = ((Fur)sFurType).ToString();
        }

        public override string PrintAnimal()
        {
            return $"I am a rabbit. \n" +
                $"Sex: {sex} \n" +
                $"Class: {type} \n" +
                $"Legs #: {legs} \n" +
                $"Fur: {fur} \n" +
                $"Age: {age} years \n" +
                $"Fur length: {furType} \n";
        }
    }
}
