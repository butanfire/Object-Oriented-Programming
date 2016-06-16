using Problem03.CompanyHierarchy.Valuables;

namespace Problem03.CompanyHierarchy.People
{
    using System.Collections.Generic;

    public interface IDeveloper
    {
        List<Project> ProjectList { get; }

        void AddProject(Project project);
    }
}