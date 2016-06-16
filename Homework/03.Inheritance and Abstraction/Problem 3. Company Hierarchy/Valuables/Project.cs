using Problem03.CompanyHierarchy.Interfaces;

namespace Problem03.CompanyHierarchy.Valuables
{
    using System;

    public class Project : IProject
    {
        private string projectName;
        private string projectDetails;
        private DateTime projectDate;
        private string projectState;

        public Project(string name, string details, string state, DateTime startDate)
        {
            this.ProjectName = name;
            this.ProjectDetails = details;
            this.ProjectState = state;
            this.ProjectStartDate = startDate;
        }

        public string ProjectName
        {
            get
            {
                return this.projectName;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Project name cannot be null");
                }

                this.projectName = value;
            }
        }

        public DateTime ProjectStartDate
        {
            get
            {
                return this.projectDate;
            }

            set
            {
                if (value == null)
                {
                    throw new ArgumentException("Date cannot be null");
                }

                this.projectDate = value;
            }
        }

        public string ProjectDetails
        {
            get
            {
                return this.projectDetails;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Project details cannot be null or empty");
                }

                this.projectDetails = value;
            }
        }

        public string ProjectState
        {
            get
            {
                return this.projectState;
            }

            set
            {
                if (value.ToLowerInvariant() == "open" || value.ToLowerInvariant() == "closed")
                {
                    this.projectState = value;
                }
                else
                {
                    throw new ArgumentException("Project can be only 'open' or 'closed'");
                }
            }
        }

        public void CloseProject()
        {
            this.projectState = "closed";
        }

        public override string ToString()
        {
            return string.Format("{0} {1} {2} {3}\n", this.ProjectName, this.ProjectStartDate, this.ProjectDetails, this.ProjectState);
        }
    }
}
