using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Breeding_Station
{
    internal class Dog : Mammal
    {
        public Dog(byte bSex, byte bClass, bool bFur, byte bLegs, byte bAge, string sFurType)
        {
            sex = ((Sex)bSex).ToString();
            type = ((Class)bClass).ToString();
            fur = bFur;
            legs = bLegs;
            age = bAge;
            furtype = sFurType;
        }

        public override string PrintAnimal()
        {
            return $"I am a dog. \n" +
                $"Sex: {sex} \n" +
                $"Class: {type} \n" +
                $"Legs #: {legs} \n" +
                $"Fur: {fur} \n" +
                $"Age: {age} years \n" +
                $"Fur length: {furtype} \n";
        }
    }
}
