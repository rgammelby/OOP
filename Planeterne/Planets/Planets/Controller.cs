using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planets
{
    public class Controller
    {
        Model m = new Model();
        View v = new View();

        public void Start()
        {
            // Part 2
            CreatePlanets();

            // Part 3
            v.PrintPlanets(m.Planets);

            // Part 4
            m.Planets.Insert(1, new Planet(464, 12104, 2, "Venus"));

            // Part 5
            v.PrintPlanets(m.Planets);

            // Part 6
            for (int i = 0; i < m.Planets.Count; i++)
            {
                if (m.Planets[i].Name == "Pluto")
                    m.Planets.RemoveAt(i);
            }

            v.PrintPlanets(m.Planets);

            // Part 7
            m.Planets.Add(new Planet(-232, (float)2376.6, 2, "Pluto"));
            v.PrintPlanets(m.Planets);

            // Part 8
            v.PrintPlanetCount(m.Planets);

            // Part 9
            List<Planet> planetsBelowZero = m.GetPlanetsBelowZero();
            v.PrintPlanets(planetsBelowZero);

            // Part 10
            List<Planet> planetsBetween10And50 = m.GetPlanetsBetween10And50();
            v.PrintPlanets(planetsBetween10And50);

            // Part 11
            m.Planets.Clear();
            v.PrintPlanets(m.Planets);

            Console.ReadLine();
        }

        public void CreatePlanets()
        {
            m.Planets.Add(new Planet(167, (float)4879.4, 2, "Mercury"));  // Mercury
            //m.Planets.Add(new Planet(464, 12104, 2, "Venus"));  // Venus
            m.Planets.Add(new Planet(15, 12742, 2, "Earth"));  // Earth
            m.Planets.Add(new Planet(-65, 6779, 2, "Mars")); // Mars
            m.Planets.Add(new Planet(-110, 139820, 0, "Jupiter"));  // Jupiter
            m.Planets.Add(new Planet(-140, 116460, 0, "Saturn"));  // Saturn
            m.Planets.Add(new Planet(-195, 50724, 1, "Uranus"));  // Uranus
            m.Planets.Add(new Planet(-200, 49244, 1, "Neptune"));  // Neptune
            m.Planets.Add(new Planet(-232, (float)2376.6, 2, "Pluto"));  // Pluto
        }
    }
}
