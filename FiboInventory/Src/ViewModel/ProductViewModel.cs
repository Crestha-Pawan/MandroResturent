using System;
using System.Collections.Generic;
using System.Text;
using FiboInfraStructure.Entity.FiboInventory;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace FiboInventory.Src.ViewModel
{
    public class ProductViewModel
    {
       
        public List<Product> products { get; set; }
        public long? ProductId { get; set; }
        public List<Ingredient> ingredients { get; set; }
        public List<ProductCategory> productcategorie{ get; set; }
        public List<ProductSubCategory> productsubcategory { get; set; }
        public string Name { get; set; }
        public long? ProductCategoryId { get; set; }
        public virtual ProductCategory ProductCategory { get; set; }
        public long? ProductSubCategoryId { get; set; }
        public virtual ProductSubCategory ProductSubCategory { get; set; }

        public IList<ProductCategory> ProductCategories { get; set; } = new List<ProductCategory>();
        public SelectList ProductCategoryList => new SelectList(ProductCategories, nameof(ProductCategory.Id), nameof(ProductCategory.Name));
        public IList<Product> Productss{ get; set; } = new List<Product>();
        public SelectList ProductList => new SelectList(Productss, nameof(Product.Id), nameof(Product.Name));

        public IList<ProductSubCategory> ProductSubCategories { get; set; } = new List<ProductSubCategory>();
        public SelectList ProductSubCategoryList => new SelectList(ProductSubCategories, nameof(ProductSubCategory.Id), nameof(ProductSubCategory.Name));
    }
}
