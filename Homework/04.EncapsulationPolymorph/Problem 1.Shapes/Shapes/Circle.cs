namespace Problem01_Shapes.Shapes
{
    using Interfaces;
    using System;

    public class Circle : IShape
    {
        private double radius;

        public Circle(double radius)
        {
            this.Radius = radius;
        }

        public double Radius
        {
            get
            {
                return this.radius;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Radius cannot be negative");
                }

                this.radius = value;
            }
        }

        public double CalculateArea()
        {
            return (Math.PI * Math.Pow(this.Radius, 2));
        }

        public double CalculatePerimeter()
        {
            return (2 * Math.PI * this.Radius);
        }
    }
}
