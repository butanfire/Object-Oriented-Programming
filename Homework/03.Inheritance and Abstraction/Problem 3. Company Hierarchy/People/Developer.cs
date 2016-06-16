using Problem03.CompanyHierarchy.Valuables;

namespace Problem03.CompanyHierarchy.People
{
    using System.Collections.Generic;
    using System.Text;

    public class Developer : RegularEmployee, IDeveloper
    {
        public Developer(string id, string fname, string lname, string department, double salary) : base(id, fname, lname, department, salary)
        {
            this.ProjectList = new List<Project>();
        }

        public List<Project> ProjectList { get; }

        public void AddProject(Project project) => this.ProjectList.Add(project);

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            output.AppendFormat("{0} {1} {2} {3} {4}\n", this.Firstname, this.Lastname, this.ID, this.Department, this.Salary);

            if (ProjectList != null)
            {
                foreach (var project in this.ProjectList)
                {
                    output.AppendFormat(ProjectList.ToString());
                }
            }

            return output.ToString();
        }
    }
}
