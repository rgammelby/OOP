using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingHat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Hat h = new Hat();
                var house = h.SetHouse();

                Console.WriteLine(house);
                Console.ReadLine();
            }            
        }
    }
}
