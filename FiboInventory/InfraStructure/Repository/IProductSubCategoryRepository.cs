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
   public interface IProductSubCategoryRepository : IRepository<ProductSubCategory>
    {
        Task<List<ProductSubCategory>> GetAllProductSubCategoryAsync();
        Task<List<ProductSubCategory>> GetByCategoryId(long Id);
    }
    public class ProductSubCategoryRepository : Repository<ProductSubCategory>, IProductSubCategoryRepository
    {
        public ProductSubCategoryRepository(ApplicationDbContext context) : base(context)
        {

        }

        public async Task<List<ProductSubCategory>> GetAllProductSubCategoryAsync()
        {
            return await GetAllAsync().ToListAsync();
        }

        public async Task<List<ProductSubCategory>> GetByCategoryId(long Id)
        {
            return await GetAllAsync().Where(x => x.ProductCategoryId == Id).ToListAsync();
        }
    }
}
