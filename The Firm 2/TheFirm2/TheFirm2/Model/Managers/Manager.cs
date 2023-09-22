using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheFirm2
{
    internal abstract class Manager : Employee
    {
        protected string telephone;
        protected List<Employee> employees;

        public abstract void AddEmployee(Employee employee);

        public abstract void EmployeeEval(Employee e);

        public override abstract string Print();
    }
}
