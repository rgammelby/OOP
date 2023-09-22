using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheFirm2
{
    internal class FloorManager : Manager
    {
        public FloorManager(string sName, double dSalary, string phone)
        {
            name = sName;
            salary = dSalary;
            telephone = phone;
            employees = new List<Employee>();
        }

        public override void AddEmployee(Employee employee)
        {
            employees.Add(employee);
        }

        public override void EmployeeEval(Employee e)
        {

        }

        public override string Print()
        {
            return $"I am a floor manager. \nName: {name} \nSalary: {salary} \n";
        }
    }
}
