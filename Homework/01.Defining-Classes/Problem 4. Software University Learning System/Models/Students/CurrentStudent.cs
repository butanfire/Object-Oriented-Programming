namespace SULS.Models.Students
{
    public class CurrentStudent : Student
    {
        protected string currentCourse;

        public CurrentStudent(string firstName, string lastName, int age, string studentNumber, double averageGrade, string currentCourse)
            : base(firstName, lastName, age, studentNumber, averageGrade)
        {
            this.CurrentCourse = currentCourse;
        }


        public string CurrentCourse
        {
            get
            {
                return this.currentCourse;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    this.currentCourse = value;
                }
            }
        }

        public override string ToString()
        {
            return string.Format(" First Name : {0}\n Last Name : {1} \n Age : {2} \n StudentNumber : {3} \n AverageGrade : {4} \n Current Course : {5}",
                this.FirstName, this.LastName, this.Age, this.StudentNumber, this.AverageGrade, this.CurrentCourse);
        }
    }
}
