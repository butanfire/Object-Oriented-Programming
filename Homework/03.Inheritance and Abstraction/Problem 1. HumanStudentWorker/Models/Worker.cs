namespace Problem1.HumanStudentWorker
{
    using System;

    public class Worker : Human
    {
        private decimal weekSalary;
        private int workHoursPerDay;

        public Worker(string fname, string lname, decimal weekSalary, int WorkHoursPerDay) : base(fname, lname)
        {
            this.WeekSalary = weekSalary;
            this.WorkHours = WorkHoursPerDay;
        }

        public decimal WeekSalary
        {
            get
            {
                return this.weekSalary;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Salary cannot be negative");
                }

                this.weekSalary = value;
            }
        }

        public int WorkHours
        {
            get
            {
                return this.workHoursPerDay;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Work hours cannot be negative");
                }

                this.workHoursPerDay = value;
            }
        }

        public decimal MoneyPerHour()
        {
            return weekSalary / 7 / workHoursPerDay;
        }

        public override string ToString()
        {
            return string.Format("{0} {1} {2} {3}", this.WeekSalary, this.WorkHours, this.FirstName, this.Lastname);
        }
    }
}
