using Problem03.CompanyHierarchy.People;

namespace Problem03.CompanyHierarchy.Interfaces
{
    using System.Collections.Generic;

    public interface IManager
    {
        List<Employee> EmpList { get; }
    }
}
