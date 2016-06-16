namespace Problem01_Shapes
{
    using System;
    using System.Collections.Generic;
    using Interfaces;
    using Shapes;

    public class Shape
    {
        public static void Main(string[] args)
        {
            List<IShape> Output = new List<IShape>();

            Output.Add(new Circle(2));
            Output.Add(new Rhombus(2, 4));
            Output.Add(new Rectangle(4, 4));

            foreach(IShape s in Output)
            {
                Console.WriteLine("Perimeter for {0} {1:F2}", s.GetType().Name, s.CalculatePerimeter());
                Console.WriteLine("Area for {0} {1:F2}", s.GetType().Name, s.CalculateArea());
            }
        }
    }
}
