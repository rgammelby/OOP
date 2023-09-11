using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace ENS
{
    /// <summary>
    /// Class <c>Controller</c> calls out to the GUI class and runs the program.
    /// </summary>
    public class Controller
    {
        // runs all necessary processes for the program to run
        public void Start()
        {
            GUI gui = new GUI();

            gui.Welcome();

            Car car = CreateCar();

            gui.SecondCar();

            Car car2 = CreateCar();

            gui.Select();
            CarSelection(car, car2);
        }

        // lets user pick which car to run the program with
        public void CarSelection(Car car, Car car2)
        {
            while (true)
            {
                var selection = Console.ReadKey(true).Key;

                switch (selection)
                {
                    // Create Car
                    case ConsoleKey.D1:
                        Run(car);
                        break;

                    // Initiate Run
                    case ConsoleKey.D2:
                        Run(car2);
                        break;
                }
            }
        }

        // creates and returns a car object
        public Car CreateCar()
        {
            GUI gui = new GUI();
            gui.ColourSelection();

            Car car = new Car();
            car.SetColour();

            return car;
        }

        // run loop for driving & recharging a car
        public void Run(Car car)
        {
            GUI gui = new GUI();

            while (true)
            {
                Console.Clear();

                gui.Display(car);
                var selection = Console.ReadKey(true).Key;

                switch (selection)
                {
                    case ConsoleKey.D1:
                        car.Drive();
                        break;

                    case ConsoleKey.D2:
                        car.Recharge();
                        break;

                    case ConsoleKey.Escape:
                        Environment.Exit(0);
                        return;
                }
            }
        }
    }
}
