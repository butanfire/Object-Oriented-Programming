namespace EnterNumbers
{
    using System;
    using System.Collections.Generic;

    public class EnterNumbers
    {
        private const int startNumber = 1;
        private const int endNumber = 100;
        private static int maxNumbers = 5;

        static void Main(string[] args)
        {
            List<int> numberList = new List<int>();
            while (numberList.Count < maxNumbers)
            {
                try
                {
                    numberList.Add(ReadNumber(startNumber, endNumber));
                }
                catch (OverflowException e)
                {
                    Console.WriteLine("Overflow exception" + e.Message);
                }
                catch (ArgumentOutOfRangeException e)
                {
                    Console.WriteLine("Invalid value" + e.Message);
                }
                catch (FormatException e)
                {
                    Console.WriteLine("Invalid format" + e.Message);
                }
            }

            Console.WriteLine("Numbers entered : {0}", string.Join(", ", numberList));
        }

        private static int ReadNumber(int start, int end)
        {
            Console.WriteLine("Please enter number :");
            int inputNumber = int.Parse(Console.ReadLine());
            if (inputNumber > endNumber || inputNumber < startNumber)
            {
                throw new ArgumentOutOfRangeException("Cannot write a number less than" + startNumber + "or higher than " + endNumber);
            }

            return inputNumber;
        }
    }
}
