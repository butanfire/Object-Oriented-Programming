namespace SULS.Models
{
    public class Person
    {
        protected string firstName;
        protected string lastName;
        protected int age;

        public Person(string firstName, string lastName, int age)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
        }
       
        public string FirstName
        {
            get
            {
                return firstName;
            }

            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    this.firstName = value;
                }
            }
        }

        public string LastName
        {
            get
            {
                return lastName;
            }

            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    this.lastName = value;
                }
            }
        }

        public int Age
        {
            get
            {
                return age;
            }

            set
            {
                if (value > 0)
                {
                    this.age = value;
                }
            }
        }

        public override string ToString()
        {
            return string.Format("First Name : {0}\n Last Name : {1} \n Age : {2}", this.FirstName, this.LastName, this.Age);
        }

    }
}
