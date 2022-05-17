using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galactica_Rasm850m
{
    internal class Tools
    {

        public static double Distance(Star star, Planet planet)
        {
            double distance = Math.Sqrt((star.posX - planet.posX) ^ 2 + (star.posY - planet.posY) ^ 2);
            return distance;
        }

        public static double Distance(Planet planet, Moon moon)
        {
            double distance = Math.Sqrt((planet.posX - moon.posX) ^ 2 + (planet.posY - moon.posY) ^ 2);
            return distance;
        }

        public static void AddPlanets(Star sun, Planet Mecury, Planet Venus, Planet Earth, Planet Jupiter ,Planet Saturn,Planet Uranus,Planet Neptune)
        {
            sun.Planets = new List<Planet>();
            sun.Planets.Add(Mecury);
            sun.Planets.Add(Venus);
            sun.Planets.Add(Earth);
            sun.Planets.Add(Jupiter);
            sun.Planets.Add(Saturn);
            sun.Planets.Add(Uranus);
            sun.Planets.Add(Neptune);
        }

        public static void AddMoons(Star sun, Moon Luna, Moon Titan , Moon Phobos , Moon Europe , Moon Demios, Moon Ganymedes , Moon Io , Moon Mimas) 
        {
            int i = 0;
            foreach (var item in sun.Planets)
            {
                sun.Planets[i].Moons = new List<Moon>();
                i++;
            }
            sun.Planets[0].Moons.Add(Luna);
            sun.Planets[1].Moons.Add(Titan);
            sun.Planets[2].Moons.Add(Phobos);
            sun.Planets[3].Moons.Add(Europe);
            sun.Planets[4].Moons.Add(Demios);
            sun.Planets[5].Moons.Add(Ganymedes);
            sun.Planets[6].Moons.Add(Io);
            sun.Planets[6].Moons.Add(Mimas);
        }
    }

    
}
