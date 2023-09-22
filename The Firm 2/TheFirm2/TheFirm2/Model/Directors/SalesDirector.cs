using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheFirm2
{
    internal class SalesDirector : Director
    {
        public SalesDirector(string sName, double dSalary, string mail)
        {
            name = sName;
            salary = dSalary;
            email = mail;
            managers = new List<Manager>();
        }

        public override void AddManager(Manager manager)
        {
            managers.Add(manager);
        }

        public override void WriteReport()
        {

        }

        public override string Print()
        {
            return $"I am a sales director. \nName: {name} \nSalary: {salary} \n";
        }
    }
}
