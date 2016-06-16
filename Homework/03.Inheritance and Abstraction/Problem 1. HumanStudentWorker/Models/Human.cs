using System;

namespace Problem1.HumanStudentWorker
{
    public abstract class Human
    {
        private string fname;
        private string lname;

        public Human(string fname, string lname)
        {
            this.FirstName = fname;
            this.Lastname = lname;
        }
        
        public string FirstName
        {
            get
            {
                return this.fname;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("First name cannot be null");
                }

                this.fname = value;
            }
        }

        public string Lastname
        {
            get
            {
                return this.lname;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Last name cannot be null");
                }

                this.lname = value;
            }
        }
    }
}
