using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace FiboInfraStructure.Entity.FiboInventory
{
   public class ProductSubCategory :BaseEntity
    {
        public string Name { get; set; }

        [ForeignKey("ProductCategoryId")]
        public long? ProductCategoryId { get; set; }
        [NotMapped()]
        public virtual ProductCategory ProductCategory { get; set; }

    }
}
