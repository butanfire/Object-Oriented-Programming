namespace Problem01_Shapes.Shapes
{
    public class Rhombus : BasicShape
    {
        public Rhombus(double width, double height) : base(width, height) { }

        public override double CalculateArea()
        {
            return (this.Width * this.Height);
        }

        public override double CalculatePerimeter()
        {
            return (4 * Width);
        }
    }
}
