using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheFirm2
{
    internal class Car
    {
        private string _brand;
        private string _model;

        public Car(string brand, string model)
        {
            _brand = brand;
            _model = model;
        }

        public string Brand
        {
            get { return _brand; }
            private set { _brand = value; }
        }

        public string Model
        {
            get { return _model; }
            private set { _model = value; }
        }

    }
}
