using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using FiboInfraStructure.Entity.FiboInventory;
using FiboInventory.InfraStructure.Assembler;
using FiboInventory.InfraStructure.Repository;
using FiboInventory.Src.Dto;

namespace FiboInventory.InfraStructure.Service
{
   public interface IProductSubCategoryService
    {
        Task<ProductSubCategoryDto> InsertAsync(ProductSubCategoryDto dto);
        Task<ProductSubCategory> Delete(long Id);
        Task<ProductSubCategoryDto> UpdateAsync(ProductSubCategoryDto dto);
    }
    public class ProductSubCategoryService : IProductSubCategoryService
    {
        private readonly IProductSubCategoryRepository _productSubCategoryRepository;
        private readonly IProductSubCategoryAssembler _assembler;
        public ProductSubCategoryService(IProductSubCategoryRepository productSubCategoryRepository, IProductSubCategoryAssembler assembler)
        {
            _productSubCategoryRepository = productSubCategoryRepository;
            _assembler = assembler;
        }
        public async Task<ProductSubCategoryDto> InsertAsync(ProductSubCategoryDto dto)
        {
            ProductSubCategory productSubCategory = new ProductSubCategory();
            _assembler.copyTo(productSubCategory, dto);
            await _productSubCategoryRepository.AddAsync(productSubCategory);
            dto.Id = productSubCategory.Id;
            return dto;
        }

        public async Task<ProductSubCategoryDto> UpdateAsync(ProductSubCategoryDto dto)
        {
            ProductSubCategory productSubCategory = new ProductSubCategory();
            _assembler.modifyTo(productSubCategory, dto);
            await _productSubCategoryRepository.UpdateAsync(productSubCategory);
            return dto;
        }

        public async Task<ProductSubCategory> Delete(long Id)
        {
            var productSubCategory = await _productSubCategoryRepository.GetByIdAsync(Id) ?? throw new Exception();
            return await _productSubCategoryRepository.DeleteAsync(productSubCategory).ConfigureAwait(true);
        }
    }
}
