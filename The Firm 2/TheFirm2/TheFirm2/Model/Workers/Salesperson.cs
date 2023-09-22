using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheFirm2.Model
{
    internal class Salesperson : Employee
    {
        protected int id;

        public Salesperson(string sName, double dSalary, int iId)
        {
            name = sName;
            salary = dSalary;
            id = iId;
        }

        public override string Print()
        {
            return $"I am a salesperson. \nName: {name} \nSalary: {salary} \n";
        }
    }
}
