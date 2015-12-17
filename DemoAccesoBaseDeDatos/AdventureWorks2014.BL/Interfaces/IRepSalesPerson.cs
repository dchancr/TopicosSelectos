using System.Linq;
using AdventureWorks2014.Model.Models;

namespace AdventureWorks2014.BL.Interfaces
{
    public interface IRepSalesPersons
    {
        IQueryable<SalesPerson> QueryPercentGreaterThan(double lowerBound);

    }
}