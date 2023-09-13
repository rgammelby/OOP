using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planets
{
    public class Model
    {
        public List<Planet> Planets = new List<Planet>();

        public List<Planet> GetPlanets()
        {
            return Planets;
        }

        // returns planets with a mean temperature below zero degrees celsius
        public List<Planet> GetPlanetsBelowZero()
        {
            List<Planet> p = new List<Planet>();

            foreach (Planet planet in Planets)
            {
                if (planet.Temperature < 0)
                    p.Add(planet);
            }

            return p;
        }

        // returns planets with a diameter of between 10.000 and 50.000 kilometres
        public List<Planet> GetPlanetsBetween10And50()
        {
            List<Planet> p = new List<Planet>();

            foreach (Planet planet in Planets)
            {
                if (planet.Diameter > 10000 && planet.Diameter < 50000)
                    p.Add(planet);
            }

            return p;
        }
    }
}
