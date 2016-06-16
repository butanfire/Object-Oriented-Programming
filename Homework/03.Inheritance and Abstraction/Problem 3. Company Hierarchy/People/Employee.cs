using System;
using Problem03.CompanyHierarchy.Interfaces;

namespace Problem03.CompanyHierarchy.People
{
    public class Employee : Person, IEmployee
    {
        private string department;
        private double salary;

        public Employee(string id, string fname, string lname, string department, double salary) : base(id, fname, lname)
        {
            this.Department = department;
            this.Salary = salary;
        }

        public string Department
        {
            get
            {
                return this.department;
            }

            set
            {
                if (value == "Production" || value == "Accounting" || value == "Sales" || value == "Marketing")
                {
                    this.department = value;
                }
                else
                {
                    throw new ArgumentException("Department cannot be other than : Production, Accounting, Sales or Marketing");
                }
            }
        }

        public double Salary
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

        public override string ToString()
        {
            return string.Format("{0} {1} {2} {3} {4}\n", this.Firstname, this.Lastname, this.ID, this.Department, this.Salary);
        }
    }
}
