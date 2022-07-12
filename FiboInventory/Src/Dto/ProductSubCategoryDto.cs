using System;
using System.Collections.Generic;
using System.Text;
using FiboInfraStructure.Entity.FiboInventory;
using FiboInfraStructure.Src;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace FiboInventory.Src.Dto
{
   public class ProductSubCategoryDto : BaseDto
    {
        public string Name { get; set; }
        public long? ProductCategoryId { get; set; }
        public virtual ProductCategory ProductCategory { get; set; }

        public IList<ProductCategory> ProductCategories { get; set; } = new List<ProductCategory>();
        public SelectList ProvienceList => new SelectList(ProductCategories, nameof(ProductCategory.Id), nameof(ProductCategory.Name));
    

}
}
