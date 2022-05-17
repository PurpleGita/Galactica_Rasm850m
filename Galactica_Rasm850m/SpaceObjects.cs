using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Galactica_Rasm850m;

namespace Galactica_Rasm850m
{
    internal class SpaceObjects
    {
        internal int Id { get; set; }

        internal string Name { get; set; }

        internal enum StarType 
        {
            YellowDwarf, 
            White, 
            BlueNeutron, 
            RedGiant
        }

        public class Position
        {
            internal int X { get; set; }
            internal int Y { get; set; }

            public override string ToString()
            {

                return "(" + X + ":" + Y + ")" ;
            }
        }
    }

    internal class Star : SpaceObjects
    {
        internal StarType Type { get; set; }

        internal int temputure { get; set; }

        internal List<Planet> Planets { get; set; }

        internal int posX = 0;

        internal int posY = 0;

    }

    internal class Planet : SpaceObjects
    {

        internal enum PlanetType
        {
            Terrestial,
            Giant,
            Dwarf,
            Gas_Giant
        }

        internal PlanetType type { get; set; } 
        internal int Diameter_m { get; set; }

        internal int RotationPeriod_t { get; set; }
        internal int RevolutionPeriod_d { get; set; }
        internal List<Moon> Moons { get; set; }

        internal int posX;

        internal int posY;
    }




    internal class Moon : Planet
    { 
        internal Planet Orbiting { get; set; }

        

    }

}
