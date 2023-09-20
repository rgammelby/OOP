using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheFirm
{
    internal class Manager : Employee
    {
        protected string telephone;

        protected Manager()
        {
            telephone = "12345678";
        }

        public Manager(string cprNo, string fName, string lName, string phone) : base(cprNo, fName, lName)
        { 
            telephone = phone;
        }

        public override string ToString()
        {
            return $"{base.ToString()}Telephone number: {telephone} \n";
        }
    }
}
