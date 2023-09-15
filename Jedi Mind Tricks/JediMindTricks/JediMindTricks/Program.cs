using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JediMindTricks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Part 1

            Dictionary<string, int> people = new Dictionary<string, int>();
            people.Add("Rasmus", 26);

            // Part 2

            Dictionary<string, bool> characters = new Dictionary<string, bool>()
            {
                { "Luke", true },
                { "Han", false },
                { "Chewbacca", false }
            };

            if (people.ContainsKey("Rasmus"))
                Console.WriteLine(people["Rasmus"]);

            // Part 3

            if (characters.ContainsKey("Han"))
                characters.Remove("Han");

            // Part 4

            foreach (var kvp in characters)
            {
                Console.WriteLine("Key = {0}, Value = {1} ", kvp.Key, kvp.Value);
            }
        }
    }
}
