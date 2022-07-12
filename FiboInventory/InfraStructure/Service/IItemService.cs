using FiboInfraStructure.Entity.FiboInventory;
using FiboInventory.InfraStructure.Assembler;
using FiboInventory.InfraStructure.Repository;
using FiboInventory.Src.Dto;
using System;
using System.Threading.Tasks;

namespace FiboInventory.InfraStructure.Service
{
    public interface IItemService
    {
        Task<ItemDto> Insertasync(ItemDto dto);
        Task<Item> Delete(long Id);
        Task<ItemDto> UpdateAsync(ItemDto dto);
    }
    public class ItemService : IItemService
    {
        private readonly IItemRepository _repo;
        private readonly IItemAssembler _assembler;
        public ItemService(IItemRepository repo, IItemAssembler assembler)
        {
            _repo = repo;
            _assembler = assembler;
        }

        public async Task<Item> Delete(long Id)
        {
            var item = await _repo.GetByIdAsync(Id) ?? throw new Exception();
            return await _repo.DeleteAsync(item).ConfigureAwait(true);
        }

        public async Task<ItemDto> Insertasync(ItemDto dto)
        {
            Item item = new Item();
            _assembler.copyTo(item, dto);
            await _repo.AddAsync(item);
            dto.Id = item.Id;
            return dto;
        }

        public async Task<ItemDto> UpdateAsync(ItemDto dto)
        {
            Item item = new Item();
            _assembler.modifyTo(item, dto);
            await _repo.UpdateAsync(item);
            return dto;
        }
    }
}
