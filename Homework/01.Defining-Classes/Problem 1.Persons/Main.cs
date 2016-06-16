namespace Persons
{
    using System;

    public class PersonsExample
    {
        public static void Main(string[] args)
        {
            Persons Pesho = new Persons("Pesho", 18, "test@abv.bg");
            Persons Ivan = new Persons("Ivan", 20);
            Console.WriteLine("{0}\n{1}", Pesho, Ivan);

            Persons TestInput = new Persons("Test", 1, "test123");
            Console.WriteLine(TestInput.ToString());
        }
    }
}
