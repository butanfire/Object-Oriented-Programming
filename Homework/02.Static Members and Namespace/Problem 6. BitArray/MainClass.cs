namespace Problem_6.BitArray
{
    using System;

    public class MainClass
    {
        public static void Main(string[] args)
        {
            BitArray testNumber = new BitArray(20);
            testNumber[3] = 1;
            testNumber[13] = 1;
            Console.WriteLine(testNumber);
        }
    }
}
