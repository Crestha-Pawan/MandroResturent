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
   public interface IIngredientService
    {
        Task<IngredientDto> InsertAsync(IngredientDto dto);
        Task<Ingredient> Delete(long Id);
        Task<IngredientDto> UpdateAsync(IngredientDto dto);
    }

    public class IngredientService : IIngredientService
    {
        private readonly IIngredientRepository _repo;
        private readonly IIngredientAssembler _assembler;
        public IngredientService(IIngredientRepository repo, IIngredientAssembler assembler)
        {
            _repo = repo;
            _assembler = assembler;
        }

        public async Task<Ingredient> Delete(long Id)
        {
            var ingredient = await _repo.GetByIdAsync(Id) ?? throw new Exception();
            return await _repo.DeleteAsync(ingredient).ConfigureAwait(true);
        }

        public async Task<IngredientDto> InsertAsync(IngredientDto dto)
        {
            Ingredient ingredient = new Ingredient();
            _assembler.copyTo(ingredient, dto);
            await _repo.AddAsync(ingredient);
            dto.Id = ingredient.Id;
            return dto;
        }

        public async Task<IngredientDto> UpdateAsync(IngredientDto dto)
        {
            Ingredient ingredient = new Ingredient();
            _assembler.modifyTo(ingredient, dto);
            await _repo.UpdateAsync(ingredient);
            return dto;
        }
    }
}
