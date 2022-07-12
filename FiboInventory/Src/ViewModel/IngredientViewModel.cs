using System;
using System.Collections.Generic;
using System.Text;
using FiboInfraStructure.Entity.FiboInventory;

namespace FiboInventory.Src.ViewModel
{
   public class IngredientViewModel
    {
        public List<Ingredient> Ingredients { get; set; }
        public virtual Product Product { get; set; }
    }
}
