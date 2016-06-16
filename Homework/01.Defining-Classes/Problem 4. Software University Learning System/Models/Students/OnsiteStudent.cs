namespace SULS.Models.Students
{
    public class OnsiteStudent : CurrentStudent
    {
        private int numberVisits;

        public OnsiteStudent(string firstName, string lastName, int age, string studentNumber, double averageGrade, string currentCourse, int numberVisits)
            : base(firstName, lastName, age, studentNumber, averageGrade, currentCourse)
        {
            this.NumberVisits = numberVisits;
        }

        public int NumberVisits
        {
            get
            {
                return this.numberVisits;
            }

            set
            {
                if (value >= 0)
                {
                    this.numberVisits = value;
                }
            }
        }

        public override string ToString()
        {
            return $"{base.ToString()} \n Visits : {this.NumberVisits}";
        }
    }
}
