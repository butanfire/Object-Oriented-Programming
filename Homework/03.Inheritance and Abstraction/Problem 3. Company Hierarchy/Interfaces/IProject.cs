namespace Problem03.CompanyHierarchy.Interfaces
{
    using System;

    public interface IProject
    {
        string ProjectName { get; set; }

        DateTime ProjectStartDate { get; set; }

        string ProjectDetails { get; set; }

        string ProjectState { get; set; }

        void CloseProject();
    }
}
