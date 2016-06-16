using System;

namespace SULS.Models.Trainders
{
    public class SeniorTrainer : Trainer
    {
       public SeniorTrainer(string firstName, string lastName, int age) : base(firstName,  lastName,  age)
        { }

        public void DeleteCourse(string courseName)
        {
            Console.WriteLine("Course " + courseName + " has been deleted");
        }
    }
}
