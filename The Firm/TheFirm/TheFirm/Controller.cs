using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheFirm
{
    internal class Controller
    {
        public void Start()
        {
            // creates new employee and prints their data
            Employee e = new Employee("123456-9999", "Jesper", "Jespersen");
            Console.WriteLine(e.ToString());

            // creates new manager and prints their data
            Manager m = new Manager("120677-1963", "Jes", "Jessen", "12051422");
            Console.WriteLine(m.ToString());

            // creates new project manager and prints their data
            ProjectManager p = new ProjectManager("251367-9125", "Iben", "Holt", "52918355", "ih@firma.dk");
            Console.WriteLine(p.ToString());

            // empty projectmanager / default profile, no input
            ProjectManager pm = new ProjectManager();
            Console.WriteLine(pm.ToString());

            Console.ReadLine();
        }
    }
}
