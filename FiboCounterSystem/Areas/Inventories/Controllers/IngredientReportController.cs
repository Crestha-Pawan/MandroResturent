using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FiboInventory.InfraStructure.Repository;
using FiboInventory.Src.ViewModel;
using Microsoft.AspNetCore.Mvc;
using FiboInfraStructure;
using FiboInfraStructure.Entity.FiboInventory;

namespace FiboCounterSystem.Areas.Inventories.Controllers
{
    public class IngredientReportController : Controller
    {
        private readonly IIngredientRepository _ingredientRepository;
        private readonly IInventoryRepository _INVRepository;
        public readonly IItemRepository _itemRepository;
        public IngredientReportController(IIngredientRepository ingredientRepository
            , IInventoryRepository inventoryRepository, IItemRepository itemRepository)
        {
            _ingredientRepository = ingredientRepository;
            _INVRepository = inventoryRepository;
            _itemRepository = itemRepository;
        }
        public async Task<IActionResult> IngredientReport(IngredientReportViewModel vm)
        {
            var inv = await _INVRepository.GetAllInventoryAsync();
            var item = await _itemRepository.GetAllItemAsync();
            vm.Items = new List<Item>();
            vm.Items = item;
            var query = (from i in inv
                         join itm in item on i.ItemId equals itm.Id
                         select new { Id = i.ItemId, AvailableQty = i.AvailableQuantity, ActualQty = i.ActualQuantity, ConsumedQty = i.ConsumedQuantity, MeasuringUnitId=itm.MeasuringUnitId });
            List<InventoryReportViewModel> inventory = query.GroupBy(l => l.Id).Select(cl => new InventoryReportViewModel
            {
                ItemId = (long)cl.Select(c => c.Id).FirstOrDefault(),
                AvailableQuantity = cl.Sum(c => c.AvailableQty),
                ActualQuantity = cl.Sum(c => c.ActualQty),
                ConsumedQuantity = cl.Sum(c => c.ConsumedQty),
                MeasuringUnitId= (long)cl.Select(c => c.MeasuringUnitId).FirstOrDefault()

            }).ToList();
            if (vm.ItemId > 0)
            {
                inventory = inventory.Where(x => x.ItemId == vm.ItemId).ToList();
            }
            vm.Inventories = inventory;

            return View(vm);
        }
    }
}
