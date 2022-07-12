using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using FiboInfraStructure.Entity.FiboOffice;

namespace FiboInfraStructure.Entity.FiboInventory
{
   public class Ingredient :BaseCounterEntity
    {
        
        public Decimal Quantity { get; set; }

        [ForeignKey("ItemId")]
        public long? ItemId { get; set; }

        [NotMapped()]
        public virtual Item Item { get; set; }

        [ForeignKey("ProductId")]
        public long? ProductId { get; set; }
        [NotMapped()]
        public virtual Product Product { get; set; }

        [ForeignKey("MeasuringUnitId")]
        public long? MeasuringUnitId { get; set; }
        [NotMapped()]
        public virtual MeasuringUnit MeasuringUnit { get; set; }
    }
}
