using System;
using System.Collections.Generic;
using System.Text;
using FiboInfraStructure.Entity.FiboInventory;
using FiboInventory.Src.Dto;

namespace FiboInventory.InfraStructure.Assembler
{
   public interface IProductAssembler
    {
        void copyTo(Product product, ProductDto dto);
        void copyFrom(ProductDto dto, Product product);
        void modifyTo(Product product, ProductDto dto);
    }

    public class ProductAssembler : IProductAssembler
    {
        //copy to entity(table)
        public void copyTo(Product product, ProductDto dto)
        {
            product.CreatedBy = dto.CreatedBy;
            product.CreatedDate = DateTime.Now;
            product.Name = dto.Name;
            product.Cost = dto.Cost;
            product.ProductCategoryId = dto.ProductCategoryId;
            product.ProductSubCategoryId = dto.ProductSubCategoryId;
        }
        //copy from entity(table)
        public void copyFrom(ProductDto dto, Product product)
        {
            dto.Id = product.Id;
            dto.CreatedBy = product.CreatedBy;
            dto.CreatedDate = product.CreatedDate;
            dto.Name = product.Name;
            dto.Cost = product.Cost;
            dto.ProductCategoryId = product.ProductCategoryId;
            dto.ProductSubCategoryId = product.ProductSubCategoryId;
        }

        //modified to entity(table)
        public void modifyTo(Product product, ProductDto dto)
        {
            product.Id = dto.Id;
            product.CreatedBy = dto.CreatedBy;
            product.CreatedDate = DateTime.Now;
            product.Name = dto.Name;
            product.Cost = dto.Cost;
            product.ProductCategoryId = dto.ProductCategoryId;
            product.ProductSubCategoryId = dto.ProductSubCategoryId;
            product.ModifiedBy = dto.ModifiedBy;
            product.ModifiedDate = DateTime.Now;
        }
    }
}
