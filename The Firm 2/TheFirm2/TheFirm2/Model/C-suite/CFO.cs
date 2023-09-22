using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheFirm2
{
    internal class CFO : CSuite
    {
        protected List<Director> directors;

        public CFO(string sName, double dSalary, Car vehicle)
        {
            name = sName;
            salary = dSalary;
            car = vehicle;
            directors = new List<Director>();
        }

        public override void AddDirector(Director d)
        {
            directors.Add(d);
        }

        public void AssignFunds()
        {

        }

        public override string Print()
        {
            return $"I am the CFO. \nName: {name} \nSalary: {salary} \n";
        }
    }
}
