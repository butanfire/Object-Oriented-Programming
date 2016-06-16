namespace DistanceCalculator
{
    using System;
    using Problem01.Point3D;

    public static class DistanceCalculator
    {
        public static double Distance(Point X, Point X1)
        {
            double distance = Math.Sqrt(Math.Pow(X1.PointX - X.PointX, 2) + Math.Pow(X1.PointY - X.PointY, 2) + Math.Pow(X1.PointZ - X.PointZ, 2));
            return distance;
        }
    }
}
