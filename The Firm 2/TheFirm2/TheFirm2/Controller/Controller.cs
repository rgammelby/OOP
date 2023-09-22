using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheFirm2.Model;

namespace TheFirm2
{
    internal class Controller
    {
        Company c = new Company();
        View v = new View();

        public void Start()
        {
            c.InitializeEmployees();
            HR Hr = (HR)c.hr;
            v.PrintEmployees(Hr.GetEmployees());
        }
    }
}
