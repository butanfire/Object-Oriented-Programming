namespace Problem02.Animals
{
    using System;
    using System.Text;

    public abstract class Animals : ISoundProducible
    {
        private string gender;
        private int age;
        private string name;

        public Animals(string gender, int age, string name)
        {
            this.Gender = gender;
            this.Age = age;
            this.Name = name;
        }

        public string Gender
        {
            get
            {
                return this.gender;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Gender cannot be null");
                }

                this.gender = value;
            }
        }

        public int Age
        {
            get
            {
                return this.age;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Age cannot be negative number");
                }

                this.age = value;
            }
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Name cannot be null");
                }

                this.name = value;
            }
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            output.AppendFormat("{0} {1} {2} {3}", this.gender, this.age, this.name, this.GetType().Name);
            return output.ToString();
        }

        public abstract void ProduceSound();
    }
}
