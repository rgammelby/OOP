using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingHat
{
    enum Houses { Gryffindor, Ravenclaw, Hufflepuff, Slytherin }

    public class Hat
    {
        private string _house;

        public string House
        {
            get { return _house; }
            private set { _house = value; }
        }

        public Random r = new Random();
        public string SetHouse()
        {
            var house = r.Next(0, 4);
            return ((Houses)house).ToString();
        }
    }
}
