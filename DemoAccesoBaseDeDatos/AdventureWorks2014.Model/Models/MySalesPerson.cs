using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using rg.GenericRepository.Core;

namespace AdventureWorks2014.Model.Models
{
    [MetadataType(typeof(SalesPersonMetadata))]
    public partial class SalesPerson : IEntity
    {
        [NotMapped]
        public int Id { get; set; }

        [NotMapped]
        public double CommissionAmount => ((double)CommissionPct * 100.0);

        [NotMapped]
        public string CommisionAmountString => 
                string.Format("{0}%", CommissionAmount.ToString());

    }
    public  class SalesPersonMetadata
    {
        [Key]
        public int BusinessEntityID;
        [Required]
        public decimal Bonus;
        [Required]
        public decimal CommissionPct;
        [Required]
        public decimal SalesYTD;
        [Required]
        public decimal SalesLastYear;
    }
}
