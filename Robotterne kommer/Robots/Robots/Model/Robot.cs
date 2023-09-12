using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots
{
    public  class Robot
    {
        // all robots can sweep
        // sweep-only bots are small and cannot contain microchips
        // all robots have 1 of 2 microchips; RX54667 (cleans windows); QT8339 (changes tyres)
        // some, but not all, robots have WIFI
        // robots WITHOUT COLOUR do NOT have batteries
        // robots WITH colour DO have batteries (capacity 0 > 255)
        // cleaning robots have a soap container (capacity of 2.3 litres)
        // cleaning robots can NOT have batteries, and CAN have colours
        // what the fuck
        // lille default robot kan kun feje gulv og har (trods opgavebeskrivelsen) ingen ekstrachip

        // WIFI OPTIONAL FOR ALL ROBOTS

        private bool _battery;  // only WHITE robots
        private bool _colour;
        private bool _microchip;  // if no microchip, robot small
        private bool _microchipType;  // RX / QT | True / False
        private bool _soap;  // cleaning robots
        private bool _sweeps;  // ALL robots
        private bool _wheels;
        private bool _wifi;  // sÆrLiG rObOtTyPe

        private const bool RX54667 = true;
        private const bool QT8339 = false;

        // every robot has the ability to sweep
        public Robot()
        {
            _sweeps = true;
        }

        // (colour = false) means the robot is white. if the robot is coloured (colour = true), the robot has no battery
        public Robot(bool colour) : this()
        {
            _colour = colour;

            if (colour)
                _battery = false;
        }

        // robot wifi activation
        public Robot(bool colour, bool wifi) : this(colour)
        {
            _wifi = wifi;
        }

        // if constructor is called with microchip = true, the robot has wheels. if false, the robot has no wheels.
        public Robot(bool colour, bool wifi, bool microchip) : this(colour, wifi)
        {
            _microchip = microchip;

            if (microchip)
                _wheels = true;
            else
                _wheels = false;
        }

        // if constructor is called with a microchip type, it (obviously) has a microchip, and 
        public Robot(bool colour, bool wifi, bool microchip, bool microchipType) : this(colour, wifi, microchip)
        {
            // microchip type true = RX, false = QT
            if (microchipType == RX54667)
                _soap = true;
            else if (microchipType == QT8339)
                _soap = false;

            // less readable, but still accurate: _soap = microchipType;
        }

        public bool Battery 
        { 
            get { return _battery; } 
            private set { _battery = value; } 
        }

        public bool Colour
        { get { return _colour; }
        private set { _colour = value; } }

        public bool Microchip
        { 
            get { return _microchip; }
            private set { _microchip = value; }
        }
        public bool MicrochipType
        {
            get { return _microchipType; }
            private set { _microchipType = value; }
        }
        public bool Soap
        {
            get { return _soap; }
            private set { _soap = value; }
        }
        public bool Sweeps
        {
            get { return _sweeps; }
            private set { _sweeps = value; }
        }
        public bool Wheels
        {
            get { return _wheels; }
            private set { _wheels = value; }
        }
        public bool Wifi
        {
            get { return _wifi; }
            private set { _wifi = value; }
        }
    }
}
