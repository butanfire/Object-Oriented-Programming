namespace SULS.Models.Students
{
    public class Student : Person
    {
        protected string studentNumber;
        protected double averageGrade;

        public Student(string firstName, string lastName, int age, string studentNumber, double averageGrade) : base(firstName, lastName, age)
        {
            this.StudentNumber = studentNumber;
            this.AverageGrade = averageGrade;
        }

        public string StudentNumber
        {
            get
            {
                return studentNumber;
            }

            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    this.studentNumber = value;
                }
            }
        }

        public double AverageGrade
        {
            get
            {
                return this.averageGrade;
            }

            set
            {
                if (value >= 0)
                {
                    this.averageGrade = value;
                }
            }
        }

        public override string ToString()
        {
            return string.Format(" First Name : {0}\n Last Name : {1}\n Age : {2}", this.FirstName, this.LastName, this.Age);
        }

    }
}

