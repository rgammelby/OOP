using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheFirm2
{
    internal class Employee
    {
        protected double salary;
        protected string name;

        protected Employee()
        {
            salary = 0;
            name = "New Employee";
        }

        protected Employee(double dSalary, string sName) : this()
        {
            salary = dSalary;
            name = sName;
        }
    }
}
