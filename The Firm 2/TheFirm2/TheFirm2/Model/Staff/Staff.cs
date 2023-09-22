using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheFirm2
{
    internal abstract class Staff : Employee
    {
        protected List<Employee> employees;

        public abstract List<Employee> GetEmployees();

        public override abstract string Print();
    }
}
