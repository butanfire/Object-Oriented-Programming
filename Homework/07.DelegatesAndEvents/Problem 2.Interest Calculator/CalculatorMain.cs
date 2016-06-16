namespace InterestCalc
{
    using System;

    public class CalculatorMain
    {
        public static double GetSimpleInterest(double sum, double interest, int years)
        {
            return sum * (1 + (interest / 100) * years);
        }

        public static double GetCompoundInterest(double sum, double interest, int years)
        {
            return sum * (Math.Pow((1 + (interest / 100) / 12), years * 12));
        }

        static void Main(string[] args)
        {
            InterestCalculator compoundOutput = new InterestCalculator(500, 5.6, 10, GetCompoundInterest);
            Console.WriteLine(compoundOutput);

            InterestCalculator simpleOutput = new InterestCalculator(2500, 7.2, 15, GetSimpleInterest);
            Console.WriteLine(simpleOutput);
        }
    }
}
