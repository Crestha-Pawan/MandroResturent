using System;
using System.Collections.Generic;
using System.Text;
using FiboInfraStructure.Entity.FiboInventory;
using FiboInventory.Src.Dto;

namespace FiboInventory.InfraStructure.Assembler
{
   public interface IProductCategoryAssembler
    {
        void copyTo(ProductCategory productCategory, ProductCategoryDto dto);
        void copyFrom(ProductCategoryDto dto, ProductCategory productCategory);
        void modifyTo(ProductCategory productCategory, ProductCategoryDto dto);
    }

    public class ProductCategoryAssembler : IProductCategoryAssembler
    {
        //copy to entity(table)
        public void copyTo(ProductCategory productCategory, ProductCategoryDto dto)
        {
            productCategory.CreatedBy = dto.CreatedBy;
            productCategory.CreatedDate = DateTime.Now;
            productCategory.Name = dto.Name;
        }
        //copy from entity(table)
        public void copyFrom(ProductCategoryDto dto, ProductCategory productCategory)
        {
            dto.CreatedBy = productCategory.CreatedBy;
            dto.CreatedDate = productCategory.CreatedDate;
            dto.Name = productCategory.Name;
            dto.Id = productCategory.Id;
        }

        //modified to entity(table)
        public void modifyTo(ProductCategory productCategory, ProductCategoryDto dto)
        {
            productCategory.CreatedBy = dto.CreatedBy;
            productCategory.CreatedDate = DateTime.Now;
            productCategory.Name = dto.Name;
            productCategory.ModifiedBy = dto.ModifiedBy;
            productCategory.ModifiedDate = DateTime.Now;
            productCategory.Id = dto.Id;
        }
    }
}
