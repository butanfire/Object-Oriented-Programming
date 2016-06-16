namespace Problem03.CompanyHierarchy.People
{
    public class RegularEmployee : Employee
    {
        public RegularEmployee(string id, string fname, string lname, string department, double salary) : base(id, fname, lname, department, salary) { }

        public override string ToString()
        {
            return string.Format("{0} {1} {2} {3} {4}\n", this.Firstname, this.Lastname, this.ID, this.Department, this.Salary);
        }
    }
}
