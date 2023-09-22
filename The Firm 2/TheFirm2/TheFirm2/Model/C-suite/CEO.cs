using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheFirm2
{
    internal class CEO : CSuite
    {
        protected List<HR> hrReps;
        protected List<Admin> admins;

        public CEO(string sName, double dSalary, Car vehicle)
        {
            name = sName;
            salary = dSalary;
            car = vehicle;
            hrReps = new List<HR>();
            admins = new List<Admin>();
        }

        public void AddStaff(Staff s)
        {
            if (s is HR)
                hrReps.Add((HR)s);
            else if (s is Admin)
                admins.Add((Admin)s);
        }

        public override void AddDirector(Director d) { }

        public override string Print()
        {
            return $"I am the CEO. \nName: {name} \nSalary: {salary} \n";
        }
    }
}
