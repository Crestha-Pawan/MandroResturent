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
    public interface IProductService
    {
        Task<ProductDto> InsertAsync(ProductDto dto);
        Task<Product> Delete(long Id);
        Task<ProductDto> UpdateAsync(ProductDto dto);
    }

    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;
        private readonly IProductAssembler _assembler;
        private readonly IIngredientService _ingredientService;
        public ProductService(IProductRepository productRepository, IProductAssembler assembler
            , IIngredientService ingredientService)
        {
            _productRepository = productRepository;
            _assembler = assembler;
            _ingredientService = ingredientService;
        }
        public async Task<ProductDto> InsertAsync(ProductDto dto)
        {
            Product product = new Product();
            _assembler.copyTo(product, dto);
            await _productRepository.AddAsync(product);
            dto.Id = product.Id;
            if (dto.IngredientDtos != null)
            {
                if (dto.hasingredients())
                {
                    foreach (var dto_item in dto.IngredientDtos)
                    {
                        dto_item.ProductId = dto.Id;
                        dto_item.CreatedBy = dto.CreatedBy;
                        dto_item.BranchId = dto.BranchId;
                        await _ingredientService.InsertAsync(dto_item).ConfigureAwait(true);
                    }
                }
            }

            return dto;
        }

        public async Task<ProductDto> UpdateAsync(ProductDto dto)
        {
            Product product = new Product();
            _assembler.modifyTo(product, dto);
            await _productRepository.UpdateAsync(product);
            return dto;
        }

        public async Task<Product> Delete(long Id)
        {
            var product = await _productRepository.GetByIdAsync(Id) ?? throw new Exception();
            return await _productRepository.DeleteAsync(product).ConfigureAwait(true);
        }
    }
}
