using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Data.Entity.Core.Mapping;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureWorks2014.Model.Models
{
    [MetadataType(typeof(StoreMetadata))]
    public partial class Store
    {
        [NotMapped]
        [Display(Name = "Upper Name")]
        public string UpperName => Name.ToUpper();
    }


    public class StoreMetadata
    {
        [Key]
        public int BusinessEntityID;
        [Required]
        public string Name;
        [NotMapped]
        public System.Guid rowguid;
        [NotMapped]
        public System.DateTime ModifiedDate;
    }

}
