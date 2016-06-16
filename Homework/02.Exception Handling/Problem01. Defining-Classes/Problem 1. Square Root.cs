namespace SquareRoot
{
    using System;

    public class SquareRoot
    {
        public static void Main(string[] args)
        {
            try
            {                
                Console.WriteLine("Please enter a number :");
                long inputNumber = int.Parse(Console.ReadLine());
                if (inputNumber < 0)
                {
                    throw new ArgumentOutOfRangeException("Number should be positive");
                }

                Console.WriteLine("Result is {0}", Math.Sqrt(inputNumber));
            }
            catch (OverflowException e)
            {
                Console.WriteLine("Invalid number" + e.Message);
            }
            catch (FormatException e)
            {

                Console.WriteLine("Invalid number" + e.Message);
            }
            finally
            {
                Console.WriteLine("Good bye");
            }
        }
    }
}
