namespace CustomLINQ
{
    using System;
    using System.Collections.Generic;

    public class Student
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public Student(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }
    }

    public class CustomLINQ
    {
        static void Main(string[] args)
        {
            List<int> numberList = new List<int> { 15, 1, 10, 3, 44, 55, 66 };
            var resultList = numberList.WhereNot(e => e % 2 == 0);
            Console.WriteLine(string.Join(" , ", resultList));
            Console.WriteLine("Max number in the number list {0}", numberList.Max(i => i));

            List<Student> students = new List<Student>();
            students.Add(new Student("Teodor", 10));
            students.Add(new Student("Ivan", 30));
            students.Add(new Student("Pesho", 31));

            Console.WriteLine("Max age from Students : {0}", students.Max(s => s.Age));
        }
    }


}