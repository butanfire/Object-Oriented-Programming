using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem02.Animals
{
    public class MainAnimals
    {
        public static void Main(string[] args)
        {
            List<Animals> someAnimals = new List<Animals>();

            someAnimals.Add(new Cat("f", 10, "Tisho"));
            someAnimals.Add(new Cat("f", 30, "Fisho"));

            someAnimals.Add(new Frog("m", 11, "Ivan"));
            someAnimals.Add(new Frog("m", 33, "Plamen"));

            someAnimals.Add(new Kitten("m", 6, "Dobromir"));
            someAnimals.Add(new Kitten("m", 10, "Dobrotir"));

            someAnimals.Add(new Dog("f", 22, "Lidia"));
            someAnimals.Add(new Dog("f", 44, "Onyxia"));

            someAnimals.Add(new Tomcat("m", 17, "Vlado"));
            someAnimals.Add(new Tomcat("m", 34, "Ilia"));

            //output all the animals sorted by age
            //someAnimals.Select(p => p.Age).ToList().ForEach(Console.WriteLine);

            //output the average age for each type of animal
            Console.WriteLine("=================================");
            Console.WriteLine("Average lifespan for each animal type:");

            List<Object> output = new List<object>(); //created a list which keeps the animal type in order to avoid duplication in the output
                                                      //the same can be performed for the Animal sounds too
            foreach (var animal in someAnimals) {
                if (output.Contains(animal.GetType())) continue; //if the animal type is added in the output - skip it
                output.Add(animal.GetType());             //otherwise add it to the list
                Console.WriteLine(someAnimals.OfType<Animals>().Where(o => o.GetType().Name == animal.GetType().Name).Average(s => s.Age).ToString() + " for " + animal.GetType().Name);
            }

            Console.WriteLine("=================================");
            Console.WriteLine("Sounds from the animals :");
            foreach (var animal in someAnimals) 
            {
                animal.ProduceSound();
                
            }
        }
    }
}
