using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheFirm2
{
    internal class HR : Staff
    {
        public HR(string sName, double dSalary)
        {
            name = sName;
            salary = dSalary;
            employees = new List<Employee>();
        }

        public override List<Employee> GetEmployees() { return employees; }

        public void AddEmployee(Employee employee)
        {
            employees.Add(employee);
        }

        public void RecruitNewEmployee()
        {

        }

        public override string Print()
        {
            return $"I work in HR. \nName: {name} \nSalary: {salary} \n";
        }
    }
}
