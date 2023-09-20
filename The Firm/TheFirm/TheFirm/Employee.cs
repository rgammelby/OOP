using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheFirm
{
    internal class Employee
    {
        protected string cpr;
        protected string firstName;
        protected string lastName;

        protected Employee()
        {
            cpr = "123456-9999";
            firstName = "John";
            lastName = "Doe";
        }

        public Employee(string cprNo, string fName, string lName) : this()
        {
            cpr = cprNo;
            firstName = fName;
            lastName = lName;
        }

        public override string ToString()
        {
            return $"CPR: {cpr} \nFirst name: {firstName} \nLast name: {lastName} \n";
        }
    }
}
