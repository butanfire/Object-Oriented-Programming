namespace FootballLeague.Models
{
    using System;

    public class Player
    {
        private const int YearAllowed = 1980;
        private string firstName;
        private string lastName;
        private decimal salary;
        private DateTime dateOfBirth;
        private Team team;

        public Player(string firstName,string lastName,DateTime dateOfBirth, decimal salary,Team team)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Salary = salary;
            this.DateOfBirth = dateOfBirth;
            this.team = team;
        }

        public string FirstName
        {
            get
            {
                return this.firstName;
            }

            set
            {
                if (value.Length < 3 && !string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("FirstName cannot be less than 3 characters");
                }

                this.firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }

            set
            {
                if (value.Length < 3 && !string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("LastName cannot be less than 3 characters");
                }

                this.lastName = value;
            }
        }

        public decimal Salary
        {
            get
            {
                return this.salary;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Salary cannot be negative");
                }

                this.salary = value;
            }
        }

        public DateTime DateOfBirth
        {
            get
            {
                return this.dateOfBirth;
            }

            set
            {
                if (value.Year <= YearAllowed)
                {
                    throw new ArgumentException("Year cannot be lower than " + YearAllowed);
                }

                this.dateOfBirth = value;
            }
        }
       
    }
}
