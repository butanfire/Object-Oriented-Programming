namespace Problem03.CompanyHierarchy.Interfaces
{
    using System;

    public interface ISale
    {
        string ProductName { get; set; }

        DateTime Date { get; set; }

        double Price { get; set; }
    }
}
