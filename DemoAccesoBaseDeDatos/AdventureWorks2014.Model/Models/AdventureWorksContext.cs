using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureWorks2014.Model.Models
{
    public class AdventureWorksContext : DbContext
    {
        public DbSet<Store> Stores{ get; set; }
        public  DbSet<SalesPerson> SalesPersons { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer<AdventureWorksContext>(null);
        }
    }
}
