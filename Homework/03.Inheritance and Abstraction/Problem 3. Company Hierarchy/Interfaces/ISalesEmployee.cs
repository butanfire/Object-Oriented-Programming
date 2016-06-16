using Problem03.CompanyHierarchy.Valuables;

namespace Problem03.CompanyHierarchy.Interfaces
{
    using System.Collections.Generic;

    public interface ISalesEmployee
    {
        List<Sale> SalesList { get; }

        void AddSale(Sale ABC);
    }
}
