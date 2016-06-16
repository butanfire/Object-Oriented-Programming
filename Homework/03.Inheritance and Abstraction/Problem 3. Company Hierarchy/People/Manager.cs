using System.Collections.Generic;
using System.Text;
using Problem03.CompanyHierarchy.Interfaces;

namespace Problem03.CompanyHierarchy.People
{
    public class Manager : Employee, IManager
    {
        public Manager(string id, string fname, string lname, string department, double salary) : base(id, fname, lname, department, salary)
        {
            this.EmpList = new List<Employee>();
        }

        public List<Employee> EmpList { get; }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            output.AppendFormat("{0} {1} {2} {3} {4}\n", this.Firstname, this.Lastname, this.ID, this.Department, this.Salary);
            if (EmpList != null)
            {
                foreach (var employee in this.EmpList)
                {
                    output.Append(employee.ToString());
                }
            }

            return output.ToString();
        }
    }
}
