using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheFirm2
{
    internal class ITDirector : Director
    {
        public ITDirector(string sName, double dSalary, string mail)
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

        public List<Manager> GetEmployees()
        {
            return managers;
        }

        public override void WriteReport()
        {

        }

        public override string Print()
        {
            return $"I am an IT director. \nName: {name} \nSalary: {salary} \n";
        }
    }
}
