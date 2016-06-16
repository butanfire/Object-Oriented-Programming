using LaptopShop.Models;

namespace LaptopShop
{
    using System;

    public class LaptopShop
    {
        public static void Main(string[] args)
        {
            Laptop NextGenNew = new Laptop("Proliant1000", 50000, "HP", "56", "Gforce", new Battery(10.5, "Li-Ion, 4-cells, 2550 mAh"));
            Console.WriteLine(NextGenNew.ToString());

            Laptop Lap1 = new Laptop("IBM", 100);
            Console.WriteLine(Lap1.ToString());

            Laptop Lap2 = new Laptop("IBM", 101, "IBM");
            Console.WriteLine(Lap2.ToString());

            Laptop Lap3 = new Laptop("IBM", 102, " ");
            Console.WriteLine(Lap3.ToString());

            Laptop TestFail = new Laptop("TestFail", -1000, "HP", "55", "AMD", new Battery(10.05, "Some Battery"));
            Console.WriteLine(TestFail.ToString());
        }
    }
}
