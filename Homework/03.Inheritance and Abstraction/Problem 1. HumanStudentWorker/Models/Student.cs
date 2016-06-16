namespace Problem1.HumanStudentWorker
{
    using System;

   public class Student : Human
    {
        private string facultyNumber;

        public Student(string fname, string lname, string facultyN) : base(fname, lname)
        {
            this.FacultyNumber = facultyN;
        }

        public string FacultyNumber{
            get
            {
                return this.facultyNumber;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Faculty number cannot be empty");
                }

                this.facultyNumber = value;
            }
        }

        public override string ToString()
        {
            return string.Format("{0} {1} {2}", this.FacultyNumber, this.FirstName, this.Lastname);
        }
    }
}
