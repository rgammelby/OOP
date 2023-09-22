using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheFirm2
{
    internal abstract class Employee
    {
        protected double salary;
        protected string name;

        public virtual string Print()
        {
            return $"I am an employee. My name is {name} and I make {salary} kr. per month. \n";
        }
    }
}
