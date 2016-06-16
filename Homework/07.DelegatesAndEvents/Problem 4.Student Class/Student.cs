namespace StudentClass
{
    using System;

    public class Student
    {
        public delegate void PropertyChangedHandler(Student someStudent, PropertyChangedEventArgs arguments);
        public event PropertyChangedHandler propertyChanged;

        private string name;
        private int age;

        public Student(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Name cannot be empty");
                }
                if (propertyChanged != null)
                {
                    propertyChanged(this, new PropertyChangedEventArgs("Name", this.Name, value));
                }

                this.name = value;
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
                    throw new ArgumentException("Age cannot be negative");
                }
                if (propertyChanged != null)
                {
                    propertyChanged(this, new PropertyChangedEventArgs("Age", this.Age, value));
                }

                this.age = value;
            }
        }
    }
}
