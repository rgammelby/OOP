using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Breeding_Station
{
    internal class Controller
    {
        Model m = new Model();

        public void Start()
        {
            m.InitializeAnimals();
        }
    }
}
