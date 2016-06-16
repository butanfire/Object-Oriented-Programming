namespace Persons
{
    public class Persons
    {
        private int age;
        private string name;
        private string email;
        
        public Persons(string name, int age)
        {
            this.Age = age;
            this.Name = name;
        }
        public Persons(string name, int age, string email) : this(name, age)
        {
            this.Email = email;
        }

        public override string ToString()
        {
            return string.Format("Name : {0}\nAge : {1}\nEmail : {2}\n"
                , this.name, this.age, this.email);
        }

        public int Age
        {
            set
            {
                if (value > 100 || value < 1)
                {
                    throw new System.ArgumentException("Invalid Age", "age");
                }

                this.age = value;
            }
            get
            {
                return age;
            }
        }

        public string Name
        {
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new System.ArgumentException("Invalid name", "name");
                }

                this.name = value;
            }
            get
            {
                return name;
            }
        }

        public string Email
        {
            set
            {
                if (!value.Contains("@"))
                {
                    throw new System.ArgumentException("Invalid email", "email");
                }

                this.email = value;
            }
            get
            {
                return email;
            }

        }
    }
}
