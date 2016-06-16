using System.Collections.Generic;
using System.Text;
using Problem03.CompanyHierarchy.Interfaces;
using Problem03.CompanyHierarchy.Valuables;

namespace Problem03.CompanyHierarchy.People
{
    public class SalesEmployee : RegularEmployee, ISalesEmployee
    {
        public SalesEmployee(string id, string fname, string lname, string department, double salary) : base(id, fname, lname, department, salary)
        {
            this.SalesList = new List<Sale>();
        }

        public List<Sale> SalesList { get; }

        public void AddSale(Sale ABC) => this.SalesList.Add(ABC);

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            output.AppendFormat("{0} {1} {2} {3} {4}\n", this.Firstname, this.Lastname, this.ID, this.Department, this.Salary);

            if (SalesList != null)
            {
                foreach (var sale in this.SalesList)
                {
                    output.AppendFormat(sale.ToString());
                }
            }

            return output.ToString();
        }
    }
}
