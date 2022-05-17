using Galactica_Rasm850m;


Planet Mecury = new();
Planet Earth = new();
Planet Venus = new();
Planet Jupiter = new();
Planet Saturn = new();
Planet Uranus = new();
Planet Neptune = new();
Star sun = new();
Moon Luna = new();
Luna.Name = "Luna";
Moon Titan = new();
Titan.Name = "Titan";
Moon Phobos = new();
Phobos.Name = "Phobos";
Moon Europe = new();
Europe.Name = "Europe";
Moon Demios = new();
Demios.Name = "Demios";
Moon Ganymedes = new();
Ganymedes.Name = "Ganymedes";
Moon Io = new();
Io.Name = "Io";
Moon Mimas = new();
Mimas.Name = "Mimas";

    Mecury.type = Planet.PlanetType.Terrestial;
    Mecury.Diameter_m = 2001;
    Mecury.RotationPeriod_t = 20102;
    Mecury.RevolutionPeriod_d = 23132;
    Mecury.posX = 23;
    Mecury.posY = 93;
    Mecury.Name = "Mecury";


    Venus.type = Planet.PlanetType.Terrestial;
    Venus.Diameter_m = 2341;
    Venus.RotationPeriod_t = 44102;
    Venus.RevolutionPeriod_d = 63132;
    Venus.posX = 33;
    Venus.posY = 23;
    Venus.Name = "Venus";

    Earth.type = Planet.PlanetType.Giant;
    Earth.Diameter_m = 53444;
    Earth.RotationPeriod_t = 5672;
    Earth.RevolutionPeriod_d = 4902;
    Earth.posX = 52;
    Earth.posY = 66;
    Earth.Name = "Earth";

    Jupiter.type = Planet.PlanetType.Dwarf;
    Jupiter.Diameter_m = 734;
    Jupiter.RotationPeriod_t = 472;
    Jupiter.RevolutionPeriod_d = 3305;
    Jupiter.posX = 72;
    Jupiter.posY = 126;
    Jupiter.Name = "Jupiter";

    Saturn.type = Planet.PlanetType.Gas_Giant;
    Saturn.Diameter_m = 734;
    Saturn.RotationPeriod_t = 472;
    Saturn.RevolutionPeriod_d = 3305;
    Saturn.posX = 201;
    Saturn.posY = 306;
    Saturn.Name = "Saturn";

    Uranus.type = Planet.PlanetType.Giant;
    Uranus.Diameter_m = 53444;
    Uranus.RotationPeriod_t = 5672;
    Uranus.RevolutionPeriod_d = 4902;
    Uranus.posX = 75;
    Uranus.posY = 45;
    Uranus.Name = "Uranus";

    Neptune.type = Planet.PlanetType.Terrestial;
    Neptune.Diameter_m = 401;
    Neptune.RotationPeriod_t = 6102;
    Neptune.RevolutionPeriod_d = 3632;
    Neptune.posX = 56;
    Neptune.posY = 35;
    Neptune.Name = "Neptune";


    sun.Type = SpaceObjects.StarType.YellowDwarf;
    sun.temputure = 100000;

Tools.AddPlanets(sun, Mecury, Venus, Earth, Jupiter, Saturn, Uranus, Neptune);
Tools.AddMoons(sun, Luna, Titan, Phobos, Europe, Demios, Ganymedes, Io, Mimas);


int i= 0;
int j;
foreach (var planetamount in sun.Planets)
{
    j = 0;
    Console.WriteLine(sun.Planets[i].Name + ":" + "     Type:" + sun.Planets[i].type + "    Afstand til solen:" + Tools.Distance(sun, sun.Planets[i]));
    foreach (var moons in sun.Planets[i].Moons)
    {
        Console.WriteLine("Måne:" + sun.Planets[i].Moons[j].Name + "  afstand fra planet:" + Tools.Distance(sun.Planets[i], sun.Planets[i].Moons[j]));
        j++;
    }
    Console.WriteLine("");

    i++;
}