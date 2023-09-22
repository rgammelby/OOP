using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheFirm2
{
    internal abstract class Director : Employee
    {
        protected string email;
        protected List<Manager> managers;

        public abstract void AddManager(Manager manager);

        public abstract void WriteReport();

        public override abstract string Print();
    }
}
