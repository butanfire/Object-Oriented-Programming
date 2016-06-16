namespace GalacticGPS
{
    using System;

    public class GalacticGPS
    {
        static void Main(string[] args)
        {
            Location home = new Location(18.037986, 28.870097, Planets.Earth);
            Console.WriteLine(home);
        }
    }
}
