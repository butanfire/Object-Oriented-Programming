namespace Problem1.HumanStudentWorker
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class HumanStudentWorker
    {
        public static void Main(string[] args)
        {
            List<Student> studentList = new List<Student>();
            studentList.Add(new Student("Pesho", "Peshev", "123456"));
            studentList.Add(new Student("Ivan", "Ivanov", "234560"));
            studentList.Add(new Student("Georgi", "Georgiev", "345670"));
            studentList.Add(new Student("Petur", "Petrov", "334567"));
            studentList.Add(new Student("Simeon", "Simeonov", "444567"));
            studentList.Add(new Student("Petur", "Simeonov", "223567"));
            studentList.Add(new Student("Yavor", "Yavorov", "222567"));
            studentList.Add(new Student("Petur", "Beron", "332456"));
            studentList.Add(new Student("Richard", "Petrov", "112334"));
            studentList.Add(new Student("Kristian", "Anderson", "445545"));

            Console.WriteLine("Students ordered by faculty number :");
            studentList.OrderBy(p => p.FacultyNumber).ToList().ForEach(Console.WriteLine);


            List<Worker> workerList = new List<Worker>();
            workerList.Add(new Worker("Stamat", "Stamatov", 2000, 20));
            workerList.Add(new Worker("Ivan", "Manolov", 1430, 11));
            workerList.Add(new Worker("Rosiqn", "Rusev", 6220, 33));
            workerList.Add(new Worker("Rusi", "Rusev", 2200, 21));
            workerList.Add(new Worker("Boqn", "Petrov", 4780, 25));
            workerList.Add(new Worker("Vlado", "Mishev", 5350, 28));
            workerList.Add(new Worker("Chris", "Toren", 550, 10));
            workerList.Add(new Worker("Niko", "Rosberg", 2760, 22));
            workerList.Add(new Worker("Ivaylo", "Fetel", 2500, 22));
            workerList.Add(new Worker("Goci", "Goranov", 33000, 50));

            Console.WriteLine("==========================================");
            Console.WriteLine("Output for workers sorted by payment per hour");
            workerList.OrderByDescending(p => p.MoneyPerHour()).ToList().ForEach(Console.WriteLine);


            List<Human> combinedList = new List<Human>();
            combinedList.AddRange(workerList);
            combinedList.AddRange(studentList);

            Console.WriteLine("==========================================");
            Console.WriteLine("All humans sorted by first/last name");
            combinedList.OrderBy(p => p.FirstName).ThenBy(s => s.Lastname).ToList().ForEach(Console.WriteLine);
        }
    }
}
