namespace StudentClass
{
    using System;

    public class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student("Peter", 22);
            student.propertyChanged += (sender, eventArgs) =>
            {
                Console.WriteLine("Property changed: {0} (from {1} to {2})",
                    eventArgs.PropertyName, eventArgs.OldData, eventArgs.NewData);
            };

            student.Name = "Maria";
            student.Age = 19;
        }
    }
}
