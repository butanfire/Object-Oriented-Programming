using ComputerCatalog.Models;

namespace ComputerCatalog
{
    using System;
    using System.Collections.Generic;

    public class ComputerCatalog
    {
       public static void Main(string[] args)
        {
            var catalog = new List<Computer>();

            var Parts = new List<Components>();
            Parts.Add(new Components("GPU", 1055));
            Parts.Add(new Components("CPU", 5430));
            Parts.Add(new Components("HDD", 460));
            Parts.Add(new Components("RAM", 450));
            
            var Parts2 = new List<Components>();
            Parts2.Add(new Components("GPU", 7030));
            Parts2.Add(new Components("CPU", 3500));
            Parts2.Add(new Components("HDD", 5540));
            Parts2.Add(new Components("RAM", 1350));

            var Parts3 = new List<Components>();            
            Parts3.Add(new Components("GPU", 125));
            Parts3.Add(new Components("CPU", 97700));

            var Parts4 = new List<Components>();
            Parts4.Add(new Components("CPU", 9439,"The Best"));
            Parts4.Add(new Components("GPU", 9956000,"The Best"));

            
            catalog.Add(new Computer("Experiment", Parts4));
            catalog.Add(new Computer("IBM", Parts3));
            catalog.Add(new Computer("HP", Parts));
            catalog.Add(new Computer("DELL", Parts2));
            
            //Before sorting
            foreach (var computer in catalog)
            {
                Console.WriteLine(computer.ToString());
            }

            catalog.Sort();
            Console.WriteLine("-------------------After Sorting :-------------------\n");
            //After sorting
            foreach (var computer in catalog)
            {
                Console.WriteLine(computer.ToString());
            }
        }


    }

}
