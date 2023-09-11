using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENS
{
    public class GUI
    {
        public void Welcome()
        {
            Console.Clear();
            Console.WriteLine("Welcome. \nPlease create a car. \n");
        }

        public void SecondCar()
        {
            Console.WriteLine("Please create another car. \n");
        }

        public void Select()
        {
            Console.WriteLine("Run the first or the second car? \n" +
                    "(1) The first car \n" +
                    "(2) The second car \n");
        }
        
        // 0% power Error
        public void Error()
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine($"Battery is at 0%! You cannot continue driving before the car has been recharged. \n");
            Task.Delay(1000).Wait();
            Console.ResetColor();
        }

        // Writes battery level and metres to console
        public void Display(Car car)
        {
            Console.ForegroundColor = car.Colour;
            Console.WriteLine($"Battery level is at {car.Battery}%. \nMetres driven: {car.Metres}. \n");
            Console.ResetColor();
        }

        public void ColourSelection()
        {
            Console.WriteLine("Please choose the colour of your vehicle: \n" +
            "(1) Red \n" +
            "(2) Yellow \n" +
            "(3) Green \n");
        }
    }
}
