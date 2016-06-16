using Problem03.CompanyHierarchy.People;
using Problem03.CompanyHierarchy.Valuables;

namespace Problem03.CompanyHierarchy
{
    using System;
    using System.Collections.Generic;

    public class CompanyHierarchy
    {
        static void Main(string[] args)
        {
            List<Person> somePeople = new List<Person>();

            somePeople.Add(new Manager("3335998", "Valio", "Tsibrov", "Production", 5000));
            somePeople.Add(new SalesEmployee("1222476", "Ivan", "Stratsimirov", "Sales", 7000));
            somePeople.Add(new Developer("5554236", "Lusko", "Berberov", "Marketing", 5000));

            Manager merindjey = new Manager("5534355", "Nasko", "Sirakov", "Sales", 10);
            merindjey.EmpList.Add(new Employee("1131311", "Evtin", "Petrov", "Sales", 500));
            merindjey.EmpList.Add(new Employee("1131312", "Skyp", "Svinarov", "Sales", 500));

            Developer DevOps = new Developer("221221", "Svetlyo", "Manov", "Production", 50);
            DevOps.AddProject(new Project("Some Project", "No Details", "open", new DateTime(2015, 10, 25)));
            DevOps.AddProject(new Project("Protecting Brands", "To be announced", "closed", new DateTime(2014, 11, 11)));

            SalesEmployee SaleGuy = new SalesEmployee("553545", "Sales", "Star", "Sales", 55555);
            SaleGuy.AddSale(new Sale("Hair Cleaner", 10, new DateTime(2015, 10, 15)));
            SaleGuy.AddSale(new Sale("Nail Polisher", 50, new DateTime(2013, 09, 22)));

            somePeople.Add(merindjey);
            somePeople.Add(DevOps);
            somePeople.Add(SaleGuy);

            foreach (var person in somePeople)
            {
                Console.WriteLine(person.GetType().Name);
                Console.WriteLine(person.ToString());
                Console.WriteLine();
            }
        }
    }
}
