using System;

namespace SULS.Models.Students
{
    public class DropoutStudent : Student
    {
        private string dropoutReason;

        public DropoutStudent(string firstName, string lastName, int age, string studentNumber, double averageGrade, string dropoutReason)
            : base(firstName, lastName, age, studentNumber, averageGrade)
        {
            this.DropOutReason = dropoutReason;
        }

        public void Reapply()
        {
            Console.WriteLine(string.Format(" First Name : {0}\n Last Name : {1} \n Age : {2} \n StudentNumber : {3} \n AverageGrade : {4} \n DropoutReason: {5}",
                this.FirstName, this.LastName, this.Age, this.StudentNumber, this.AverageGrade, this.DropOutReason));
        }

        public string DropOutReason
        {
            get
            {
                return this.dropoutReason;
            }

            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    this.dropoutReason = value;
                }
            }
        }
    }
}
