using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using FiboInfraStructure.Entity.FiboOffice;

namespace FiboInfraStructure.Entity.FiboInventory
{
   public class Product : BaseEntity
    {
        public string Name { get; set; }
        public string Cost { get; set; }
             
        [ForeignKey("ProductCategoryId")]
        public long? ProductCategoryId { get; set; }
        [NotMapped()]
        public virtual ProductCategory ProductCategory { get; set; }
        [ForeignKey("ProductSubCategoryId")]
        public long? ProductSubCategoryId { get; set; }
        [NotMapped()]
        public virtual ProductSubCategory ProductSubCategory { get; set; }
        [ForeignKey("MeasuringUnitId")]
        public long? MeasuringUnitId { get; set; }
        [NotMapped()]
        public virtual MeasuringUnit MeasuringUnit { get; set; }
        public long? ItemId { get; set; }
        public virtual Item Item { get; set; }
    }
}
