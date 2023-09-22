using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheFirm2
{
    internal abstract class CSuite : Employee
    {
        protected Car car;

        public abstract void AddDirector(Director d);

        public override abstract string Print();
    }
}
