using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Breeding_Station
{
    internal class Chicken : Animal
    {
        public Chicken(byte bSex, byte bClass, bool bFur, byte bLegs, byte bAge)
        {
            sex = ((Sex)bSex).ToString();
            type = ((Class)bClass).ToString();
            fur = bFur;
            legs = bLegs;
            age = bAge;
        }

        public override string PrintAnimal()
        {
            return $"I am a chicken. \n" +
                $"Sex: {sex} \n" +
                $"Class: {type} \n" +
                $"Legs #: {legs} \n" +
                $"Fur: {fur} \n" +
                $"Age: {age} years \n";
        }
    }
}
