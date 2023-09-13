using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planets
{
    public class View
    {
        // Prints name, temperature, diameter and type of each planet in a list
        public void PrintPlanets(List<Planet> l)
        {
            Console.Clear();

            if (l.Count == 0)
                EmptyListError();
            else
            {
                foreach (Planet p in l)
                {
                    Console.WriteLine($"{p.Name} \nAverage temperature of {p.Temperature} degrees Celsius \n" +
                        $"Diameter of {p.Diameter} KM \n" +
                        $"Type: {p.Type} \n");
                }
            }

            Console.ReadLine();
        }

        // Prints number of planets in a list
        public void PrintPlanetCount(List<Planet> l)
        {
            Console.WriteLine($"This list contains {l.Count} planets. \n");
        }

        // Prints error if user attempts to print contents of an empty list
        public static void EmptyListError()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("This list is empty!");
            Console.ResetColor();
        }
    }
}
