namespace Problem01.Point3D
{
    public class Point
    {
        public static readonly Point StartingPoint = new Point(0, 0, 0);

        public Point(int x, int y, int z)
        {
            this.PointX = x;
            this.PointY = y;
            this.PointZ = z;
        }

        public int PointX { get; set; }

        public int PointY { get; set; }

        public int PointZ { get; set; }

        public static Point Start => StartingPoint;

        public override string ToString()
        {
            return string.Format("{0},{1},{2}", this.PointX, this.PointY, this.PointZ);
        }
    }
}
