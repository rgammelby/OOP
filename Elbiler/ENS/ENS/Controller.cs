using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace ENS
{
    public class Controller
    {
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

        public Car CreateCar()
        {
            Car car = new Car();
            GUI gui = new GUI();
            gui.ColourSelection();
            car.SetColour();

            return car;
        }

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
