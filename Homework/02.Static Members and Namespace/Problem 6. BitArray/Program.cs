using System;
using System.Numerics;

namespace Problem06
{
    class Program
    {
        static void Main(string[] args)
        {
            BitArray number = new BitArray(20);
            number[5] = 1;
            number[10] = 1;
            Console.WriteLine(number);
        }
    }
}
