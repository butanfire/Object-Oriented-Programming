using Problem03.CompanyHierarchy.Interfaces;

namespace Problem03.CompanyHierarchy.People
{
    using System;

    public abstract class Person : IPerson
    {
        private string fname;
        private string lname;
        private string id;

        protected Person(string id, string fname, string lname)
        {
            this.ID = id;
            this.Lastname = lname;
            this.Firstname = fname;
        }
        public string ID
        {
            get
            {
                return this.id;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("ID cannot be null");
                }

                this.id = value;
            }
        }

        public string Firstname
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

        public override string ToString()
        {
            return string.Format("{0} {1} {2} \n", this.Firstname, this.Lastname, this.ID);
        }
    }
}
