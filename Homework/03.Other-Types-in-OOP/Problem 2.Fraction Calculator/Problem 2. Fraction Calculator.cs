namespace FractionCalculator
{
    using System;

    public class FractionCalculator
    {
        static void Main(string[] args)
        {
            Fraction fraction1 = new Fraction(22, 7);
            Fraction fraction2 = new Fraction(40, 4);
            Fraction result = fraction1 + fraction2;
            Console.WriteLine(result.Numerator);
            Console.WriteLine(result.Denominator);
            Console.WriteLine(result);

            Fraction fraction3 = new Fraction(-9223372036854775808, 9223372036854775807);
            Console.WriteLine(fraction3);
        }
    }
}
