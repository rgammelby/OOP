using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENS
{
    /// <summary>
    /// Class <c>Car</c> models a car.
    /// </summary>
    public class Car
    {
        // Attribute declaration
        private byte _battery = BATTERY_CAPACITY;
        private int _metres = START_METRES;
        private ConsoleColor _colour;
        
        // Consts
        // 100!
        private const byte BATTERY_CAPACITY = 1;
        private const byte START_METRES = 0;

        // Properties
        public byte Battery
        {
            get { return _battery; }
            private set { _battery = value; }
        }

        public int Metres
        {
            get { return _metres; }
            private set { _metres = value; }
        }

        public ConsoleColor Colour
        {
            get { return _colour; }
            private set { _colour = value; }
        }

        // "Drives" the car; adds 20 to metres, subtracts 1% from battery
        public void Drive()
        {
            if (_battery != 0)
            {
                _metres += 20;
                _battery -= 1;
            }
            else
            {
                // Outputs an error if the user attempts to drive while the Car is at 0% power
                GUI error = new GUI();
                error.Error();
            }
        }

        // Recharges the battery of the car; resets to 100
        public void Recharge()
        {
            _battery = 100;
        }

        

        // Sets colour to 1 of 3 consolecolors
        public void SetColour()
        {
            while(true)
            {
                var selection = Console.ReadKey(true).Key;

                switch (selection)
                {
                    case ConsoleKey.D1:
                        _colour = ConsoleColor.Red;
                        return;

                    case ConsoleKey.D2:
                        _colour = ConsoleColor.Yellow;
                        return;

                    case ConsoleKey.D3:
                        _colour = ConsoleColor.Green;
                        return;

                    case ConsoleKey.Escape:
                        Environment.Exit(0);
                        return;
                }
            }
        }
    }
}
