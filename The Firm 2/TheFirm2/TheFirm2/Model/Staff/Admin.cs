using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheFirm2
{
    internal class Admin : Staff
    {
        public Admin(string sName, double dSalary)
        {
            name = sName;
            salary = dSalary;
            employees = new List<Employee>();
        }

        public override List<Employee> GetEmployees() { return employees; }

        public void SendMemo(string memo, Employee employee)
        {

        }

        public override string Print()
        {
            return $"I work in administration. \nName: {name} \nSalary: {salary} \n";
        }
    }
}
