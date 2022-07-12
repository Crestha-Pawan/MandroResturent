using FiboInfraStructure.BaseInfraStructure;
using FiboInfraStructure.Data;
using FiboInfraStructure.Entity.FiboInventory;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FiboInventory.InfraStructure.Repository
{
    public interface IItemRepository : IRepository<Item>
    {
        Task<List<Item>> GetAllItemAsync();
    }
    public class ItemRepository : Repository<Item>, IItemRepository
    {
        public ItemRepository(ApplicationDbContext context) : base(context)
        {

        }

        public async Task<List<Item>> GetAllItemAsync()
        {
            return await GetAllAsync().ToListAsync();
        }
    }
}
