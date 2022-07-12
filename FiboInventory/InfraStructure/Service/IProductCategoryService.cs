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
    public interface IProductCategoryService
    {
        Task<ProductCategoryDto> InsertAsync(ProductCategoryDto dto);
        Task<ProductCategory> Delete(long Id);
        Task<ProductCategoryDto> UpdateAsync(ProductCategoryDto dto);
    }

    public class ProductCategoryService : IProductCategoryService
    {
        private readonly IProductCategoryRepository _productCategoryRepository;
        private readonly IProductCategoryAssembler _assembler;
        private readonly IProductSubCategoryService _productSubCategoryService;
        public ProductCategoryService(IProductCategoryRepository productCategoryRepository, IProductCategoryAssembler assembler, IProductSubCategoryService productSubCategoryService)
        {
            _productCategoryRepository = productCategoryRepository;
            _assembler = assembler;
            _productSubCategoryService = productSubCategoryService;
        }
        public async Task<ProductCategoryDto> InsertAsync(ProductCategoryDto dto)
        {
            ProductCategory productCategory = new ProductCategory();
            _assembler.copyTo(productCategory, dto);
            await _productCategoryRepository.AddAsync(productCategory);
            dto.Id = productCategory.Id;
            if (dto.SubCategoryDtos != null)
            {
                if (dto.hassubcategory())
                {
                    foreach (var dto_item in dto.SubCategoryDtos)
                    {
                        dto_item.ProductCategoryId = dto.Id;
                        dto_item.CreatedBy = dto.CreatedBy;
                        dto_item.BranchId = dto.BranchId;
                        await _productSubCategoryService.InsertAsync(dto_item).ConfigureAwait(true);
                    }
                }
            }

            return dto;
        }

        public async Task<ProductCategoryDto> UpdateAsync(ProductCategoryDto dto)
        {
            ProductCategory productCategory = new ProductCategory();
            _assembler.modifyTo(productCategory, dto);
            await _productCategoryRepository.UpdateAsync(productCategory);
            return dto;
        }

        public async Task<ProductCategory> Delete(long Id)
        {
            var productCategory = await _productCategoryRepository.GetByIdAsync(Id) ?? throw new Exception();
            return await _productCategoryRepository.DeleteAsync(productCategory).ConfigureAwait(true);
        }
    }
}
