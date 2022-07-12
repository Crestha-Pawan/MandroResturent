using System;
using System.Collections.Generic;
using System.Text;
using FiboInfraStructure.Entity.FiboInventory;
using FiboInfraStructure.Entity.FiboOffice;
using FiboInfraStructure.Src;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace FiboInventory.Src.Dto
{
   public class ProductDto : BaseDto
    {
        public string Name { get; set; }
        public string Cost { get; set; }
        public long? ProductCategoryId { get; set; }
        public virtual ProductCategory ProductCategory { get; set; }
        public long? ProductSubCategoryId { get; set; }
        public virtual ProductSubCategory ProductSubCategory { get; set; }
        public long? ItemId { get; set; }
        public virtual Item Item{ get; set; }

        public IList<Item> items { get; set; } = new List<Item>();
        public SelectList ItemList => new SelectList(items, nameof(Item.Id), nameof(Item.Name));
        public long? MeasuringUnitId { get; set; }
        public virtual MeasuringUnit MeasuringUnit { get; set; }

        public IList<MeasuringUnit> MeasuringUnits { get; set; } = new List<MeasuringUnit>();
        public SelectList MeasuringUnitList => new SelectList(MeasuringUnits, nameof(MeasuringUnit.Id), nameof(MeasuringUnit.Name));

        public IList<ProductCategory> ProductCategories { get; set; } = new List<ProductCategory>();
        public SelectList ProductCategoryList => new SelectList(ProductCategories, nameof(ProductCategory.Id), nameof(ProductCategory.Name));
        public IList<ProductSubCategory> ProductSubCategories { get; set; } = new List<ProductSubCategory>();
        public SelectList ProductSubCategoryList => new SelectList(ProductSubCategories, nameof(ProductSubCategory.Id), nameof(ProductSubCategory.Name));

        public List<IngredientDto> IngredientDtos { get; set; }
        public bool hasingredients()
        {
            return IngredientDtos.Count > 0;
        }

    }
}
