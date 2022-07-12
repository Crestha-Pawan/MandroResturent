using System;
using System.Collections.Generic;
using System.Text;
using FiboInfraStructure.Entity.FiboInventory;
using FiboInventory.Src.Dto;

namespace FiboInventory.InfraStructure.Assembler
{
   public interface IIngredientAssembler
    {
        void copyTo(Ingredient ingredient, IngredientDto dto);
        void copyFrom(IngredientDto dto, Ingredient ingredient);
        void modifyTo(Ingredient ingredient, IngredientDto dto);
    }

    public class IngredientAssembler : IIngredientAssembler
    {
        public void copyFrom(IngredientDto dto, Ingredient ingredient)
        {
            dto.Id = ingredient.Id;
            dto.CreatedBy = ingredient.CreatedBy;
            dto.CreatedDate = ingredient.CreatedDate;
            dto.ItemId = ingredient.ItemId;
            dto.Quantity = ingredient.Quantity;
            dto.MeasuringUnitId = ingredient.MeasuringUnitId;
            dto.ProductId = ingredient.ProductId;
        }

        public void copyTo(Ingredient ingredient, IngredientDto dto)
        {
            ingredient.CreatedBy = dto.CreatedBy;
            ingredient.CreatedDate = DateTime.Now;
            ingredient.ItemId = dto.ItemId;
            ingredient.Quantity = dto.Quantity;
            ingredient.MeasuringUnitId = dto.MeasuringUnitId;
            ingredient.ProductId = dto.ProductId;
        }

        public void modifyTo(Ingredient ingredient, IngredientDto dto)
        {
            ingredient.Id = dto.Id;
            ingredient.CreatedBy = dto.CreatedBy;
            ingredient.CreatedDate = DateTime.Now;
            ingredient.ModifiedBy = dto.ModifiedBy;
            ingredient.ModifiedDate = DateTime.Now;
            ingredient.ItemId = dto.ItemId;
            ingredient.Quantity = dto.Quantity;
            ingredient.MeasuringUnitId = dto.MeasuringUnitId;
            ingredient.ProductId = dto.ProductId;
        }
    }

}
