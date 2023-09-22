using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheFirm2.Model
{
    internal class Supporter : Employee
    {
        protected string telephone;

        public Supporter(string sName, double dSalary, string phone)
        {
            name = sName;
            salary = dSalary;
            telephone = phone;
        }

        public override string Print()
        {
            return $"I am a supporter. \nName: {name} \nSalary: {salary} \n";
        }
    }
}
