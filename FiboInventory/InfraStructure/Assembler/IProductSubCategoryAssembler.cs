using System;
using System.Collections.Generic;
using System.Text;
using FiboInfraStructure.Entity.FiboInventory;
using FiboInventory.Src.Dto;

namespace FiboInventory.InfraStructure.Assembler
{
   public interface IProductSubCategoryAssembler
    {
        void copyTo(ProductSubCategory productSubCategory , ProductSubCategoryDto dto);
        void copyFrom(ProductSubCategoryDto dto, ProductSubCategory productSubCategory);
        void modifyTo(ProductSubCategory productSubCategory, ProductSubCategoryDto dto);
    }
    public class ProductSubCategoryAssembler : IProductSubCategoryAssembler
    {
        //copy to entity(table)
        public void copyTo(ProductSubCategory productSubCategory, ProductSubCategoryDto dto)
        {
            productSubCategory.CreatedBy = dto.CreatedBy;
            productSubCategory.CreatedDate = DateTime.Now;
            productSubCategory.Name = dto.Name;
            productSubCategory.ProductCategoryId = dto.ProductCategoryId;
        }
        //copy from entity(table)
        public void copyFrom(ProductSubCategoryDto dto, ProductSubCategory productSubCategory)
        {
            dto.Id = productSubCategory.Id;
            dto.CreatedBy = productSubCategory.CreatedBy;
            dto.CreatedDate = productSubCategory.CreatedDate;
            dto.Name = productSubCategory.Name;
            dto.ProductCategoryId = productSubCategory.ProductCategoryId;
        }

        //modified to entity(table)
        public void modifyTo(ProductSubCategory productSubCategory, ProductSubCategoryDto dto)
        {
            productSubCategory.Id = dto.Id;
            productSubCategory.CreatedBy = dto.CreatedBy;
            productSubCategory.CreatedDate = DateTime.Now;
            productSubCategory.Name = dto.Name;
            productSubCategory.ProductCategoryId = dto.ProductCategoryId;
            productSubCategory.ModifiedBy = dto.ModifiedBy;
            productSubCategory.ModifiedDate = DateTime.Now;
        }
    }
}
