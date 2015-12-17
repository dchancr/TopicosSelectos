using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using rg.GenericRepository.Impl;
using AdventureWorks2014.Model.Models;


namespace AdventureWorks2014.EF.GR
{
    public class RepSalesPersons
    {
        public RepSalesPersons()
        {
            IsLazyLoading = false;
        }
        public RepSalesPersons(bool lazyLoading )
        {
            IsLazyLoading = lazyLoading;
        }

        private readonly static AdventureWorksEntities _context = new AdventureWorksEntities();
        rg.GenericRepository.Impl.EF.SqlRepository<SalesPerson> repo = new rg.GenericRepository.Impl.EF.SqlRepository<SalesPerson> (_context);

        public bool IsLazyLoading { get; set; }

        public IQueryable<SalesPerson> QueryPercentGreaterThan(decimal lowerBound)
        {
            _context.Configuration.LazyLoadingEnabled = IsLazyLoading;
            _context.Configuration.ProxyCreationEnabled = IsLazyLoading;
            var query = repo.GetAll().Where(x => x.CommissionPct >= lowerBound);
            return query;
        }

    }
}
