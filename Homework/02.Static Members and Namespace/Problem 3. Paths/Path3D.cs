namespace Problem_3.Paths
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using Problem01.Point3D;

    public class Path3D
    {
        public List<Point> points;

        public Path3D(List<Point> points)
        {
            this.Points = points;
        }

        public List<Point> Points
        {
            get
            {
                return this.points;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentException("Path3D : List points cannot be null");
                }

                this.points = value;
            }
        }

        public void AddPoint(Point X)
        {
            this.Points.Add(X);
        }

        public override string ToString()
        {
            StringBuilder s = new StringBuilder();
            foreach(Point x in this.Points)
            {
                s.Append(x.ToString() + '\n');
            }
            return s.ToString();
        }
    }
}
