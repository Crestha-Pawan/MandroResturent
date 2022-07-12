using System;
using System.Collections.Generic;
using System.Text;
using FiboInfraStructure.Entity.FiboInventory;

namespace FiboInventory.Src.ViewModel
{
   public class ProductSubCategoryViewModel
    {
        public List<ProductSubCategory> productSubCategory { get; set; }
        public virtual ProductCategory ProductCategory { get; set; }
    }
}
