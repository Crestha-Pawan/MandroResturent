using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using FiboInfraStructure.BaseInfraStructure;
using FiboInfraStructure.Data;
using FiboInfraStructure.Entity.FiboInventory;
using Microsoft.EntityFrameworkCore;

namespace FiboInventory.InfraStructure.Repository
{
   public interface IProductCategoryRepository : IRepository<ProductCategory>
    {
        Task<List<ProductCategory>> GetAllProductCategoryAsync();
    }
    public class ProductCategoryRepository : Repository<ProductCategory>, IProductCategoryRepository
    {
        public ProductCategoryRepository(ApplicationDbContext context) : base(context)
        {

        }

        public async Task<List<ProductCategory>> GetAllProductCategoryAsync()
        {
            return await GetAllAsync().ToListAsync();
        }
    }
}
