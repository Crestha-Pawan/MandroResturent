using System;
using System.Collections.Generic;
using System.Text;
using FiboInfraStructure.Entity.FiboInventory;

namespace FiboInventory.Src.ViewModel
{
   public class ProductcategoryViewModel
    {
        public List<ProductCategory> ProductCategory { get; set; }
        public List<ProductSubCategory> ProductSubCategories { get; set; }
    }
}
