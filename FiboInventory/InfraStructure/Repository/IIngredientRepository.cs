using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FiboInfraStructure.BaseInfraStructure;
using FiboInfraStructure.Data;
using FiboInfraStructure.Entity.FiboInventory;
using Microsoft.EntityFrameworkCore;

namespace FiboInventory.InfraStructure.Repository
{
    public interface IIngredientRepository : IRepository<Ingredient>
    {
        Task<List<Ingredient>> GetAllIngredientAsync();
        Task<List<Ingredient>> GetByProductId(long Id);
    }
    public class IngredientRepository : Repository<Ingredient>, IIngredientRepository
    {
        public IngredientRepository(ApplicationDbContext context) : base(context)
        {

        }

        public async Task<List<Ingredient>> GetAllIngredientAsync()
        {
            return await GetAllAsync().ToListAsync();
        }

        public async Task<List<Ingredient>> GetByProductId(long Id)
        {
            return await GetAllAsync().Where(x => x.ProductId == Id).ToListAsync();
        }
    }
}
