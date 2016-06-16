using System;

namespace SULS.Models.Trainders
{
    public class Trainer : Person
    {

        public Trainer(string firstName, string lastName, int age) : base(firstName, lastName, age)
        { }
        
        public void CreateCourse(string courseName)
        {
            Console.WriteLine("Course " + courseName + "has been created");         
        }

        public override string ToString()
        {
            return string.Format(" First Name : {0}\n Last Name : {1} \n Age : {2}", this.FirstName, this.LastName, this.Age);
        }

    }
}
