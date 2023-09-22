using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheFirm2
{
    internal class ITManager : Manager
    {
        public ITManager(string sName, double dSalary, string phone)
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

        public List<Employee> GetEmployees()
        {
            return employees;
        }

        public override void EmployeeEval(Employee e)
        {

        }

        public override string Print()
        {
            return $"I am an IT manager. \nName: {name} \nSalary: {salary} \n";
        }
    }
}
