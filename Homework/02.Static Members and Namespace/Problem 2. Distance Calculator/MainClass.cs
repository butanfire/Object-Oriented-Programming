using Problem01.Point3D;

namespace DistanceCalculator
{
    using System;

    public class MainClass
    {
        public static void Main(string[] args)
        {
            Point A = new Point(1, 2, 3);
            Point B = new Point(4, 5, 6);
            Console.WriteLine(DistanceCalculator.Distance(A, B));
        }
    }
}
