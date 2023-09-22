using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheFirm2.Model
{
    internal class View
    {
        public void PrintEmployees(List<Employee> employees)
        {
            foreach (Employee e in employees)
            {
                Console.WriteLine(e.Print());
            }
        }
    }
}
