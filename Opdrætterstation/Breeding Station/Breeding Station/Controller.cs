using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Breeding_Station
{
    /// <summary>
    /// The class <c>Controller</c> kicks off the program by initializing animals through the Model.
    /// </summary>
    
    internal class Controller
    {
        Model m = new Model();

        public void Start()
        {
            m.InitializeAnimals();
        }
    }
}
