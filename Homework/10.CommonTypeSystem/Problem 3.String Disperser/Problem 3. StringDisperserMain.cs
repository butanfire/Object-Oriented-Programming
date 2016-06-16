namespace StringDisperser
{
    using System;

    public class StringDispenserMain
    {
        public static void Main(string[] args)
        {
            StringDisperser stringDisperser = new StringDisperser("ivan");
            StringDisperser stringDisperser2 = new StringDisperser("ivan");

            // foreach
            foreach (var ch in stringDisperser)
            {
                Console.Write(ch + " ");
            }

            Console.WriteLine();

            // check if equal
            Console.WriteLine(stringDisperser.Equals(stringDisperser2)); // true

            // check if equal with opearator != & ==
            Console.WriteLine(stringDisperser != stringDisperser2); // true
            Console.WriteLine(stringDisperser == stringDisperser2); // false

            // clone and check if reference is the same
            var stringDisperser3 = (StringDisperser)stringDisperser.Clone();
            Console.WriteLine(ReferenceEquals(stringDisperser, stringDisperser3)); // false

            // compare two StringDispersers
            var stringDisperser4 = new StringDisperser("pesho", "gosho", "vanio");
            Console.WriteLine(stringDisperser.CompareTo(stringDisperser4));
        }
    }
}
