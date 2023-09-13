using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planets
{
    public class Planet
    {
        // Part 1

        private string _name;
        private short _temperature;  // Celsius
        private float _diameter;  // KM
        private string _type;

        enum Types { Gas, Ice, Terrestrial }

        public string Name
        {
            get { return _name; }
            private set { _name = value; }
        }

        public short Temperature
        {
            get { return _temperature; }
            private set { _temperature = value; }
        }

        public float Diameter
        {
            get { return _diameter; }
            private set { _diameter = value; }
        }

        public string Type
        {
            get { return _type; }
            private set { _type = value; }
        }

        // scaffolding not strictly necessary, but you can never be too sure

        public Planet()
        {
            _temperature = 0;
            _diameter = 0;
            _type = ((Types)0).ToString();
        }

        public Planet(short temperature) : this()
        {
            _temperature = temperature;
        }

        public Planet(short temperature, float diameter) : this(temperature)
        {
            _diameter = diameter;
        }

        public Planet(short temperature, float diameter, byte type) : this(temperature, diameter)
        {
            _type = ((Types)type).ToString();
        }

        public Planet(short temperature, float diameter, byte type, string name) : this(temperature, diameter, type)
        {
            _name = name;
        }
    }
}
