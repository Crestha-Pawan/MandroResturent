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
  public interface IProductRepository : IRepository<Product>
    {
        Task<List<Product>> GetAllProductAsync();
        IQueryable<Product> GetAllProductsAsync();
        IQueryable<Product> GetAllProductByFilter(string searchString);
    }
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        public ProductRepository(ApplicationDbContext context) : base(context)
        {

        }
       

        public async Task<List<Product>> GetAllProductAsync()
        {
            return await GetAllAsync().ToListAsync();
        }
        public IQueryable<Product> GetAllProductsAsync()
        {
            return GetAllAsync();
        }
        public IQueryable<Product> GetAllProductByFilter(string searchString = null)
        {
            return GetAllAsync().Where(x =>
                x.Name.Trim().ToLower().Contains(searchString.Trim().ToLower()) ||
                x.Cost.Trim().ToLower().Contains(searchString.Trim().ToLower()));
                //x.Priority.ToString().Contains(searchString));
        }
    }
}
