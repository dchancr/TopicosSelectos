using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AdventureWorks2014.BL.Interfaces;
using AdventureWorks2014.Model.Models;

namespace AdventureWorks2014.BL.Repositorios
{
    public class RepSalesPersons : GenericRepository<AdventureWorksContext, SalesPerson>, 
                    IRepSalesPersons
    {
        public IQueryable<SalesPerson> QueryPercentGreaterThan(double lowerBound)
        {
            var query = FindBy(x=> (double)x.CommissionPct > lowerBound);
            return query;
        }
    }
}
