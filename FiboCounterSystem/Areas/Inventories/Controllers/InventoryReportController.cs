using FiboInfraStructure;
using FiboInfraStructure.Entity.FiboInventory;
using FiboInventory.InfraStructure.Repository;
using FiboInventory.Src.ViewModel;
using FiboOffice.InfraStructure.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FiboCounterSystem.Areas.Inventories.Controllers
{
    public class InventoryReportController : Controller
    {
        private readonly IInventoryRepository _inventoryRepository;
        public readonly IItemRepository _itemRepository;
        private readonly IMonthRepository _monthRepo;
        private readonly IYearRepository _yearRepo;
        public InventoryReportController(IInventoryRepository inventoryRepository
            , IItemRepository itemRepository
            , IMonthRepository monthRepo
            , IYearRepository yearRepo
            )
        {
            _itemRepository = itemRepository;
            _inventoryRepository = inventoryRepository;
            _monthRepo = monthRepo;
            _yearRepo = yearRepo;
        }

        public async Task<IActionResult> InventoryReport(InventoryReportViewModel vm)
        {
            var inv = await _inventoryRepository.GetAllInventoryAsync();
            var item = await _itemRepository.GetAllItemAsync();
            vm.Items = new List<Item>();
            vm.Items = item;
            var query = (from i in inv
                         join itm in item on i.ItemId equals itm.Id
                         select new { Id = i.ItemId, AvailableQty = i.AvailableQuantity, ActualQty = i.ActualQuantity, ConsumedQty = i.ConsumedQuantity, MeasuringUnitId = itm.MeasuringUnitId });
            List<InventoryReportViewModel> inventory = query.GroupBy(l => l.Id).Select(cl => new InventoryReportViewModel
            {
                ItemId = (long)cl.Select(c => c.Id).FirstOrDefault(),
                AvailableQuantity = cl.Sum(c => c.AvailableQty),
                ActualQuantity = cl.Sum(c => c.ActualQty),
                ConsumedQuantity = cl.Sum(c => c.ConsumedQty),
                MeasuringUnitId = (long)cl.Select(c => c.MeasuringUnitId).FirstOrDefault()

            }).ToList();
            if (vm.ItemId > 0)
            {
                inventory = inventory.Where(x => x.ItemId == vm.ItemId).ToList();
            }
            vm.Inventories = inventory;

            return View(vm);
        }
        public async Task<IActionResult> PurchaseReport(InventoryViewModel vm)
        {
            var item = await _itemRepository.GetAllItemAsync();
            vm.Items = new List<Item>();
            vm.Items = item;
            vm.Inventories = new List<FiboInfraStructure.Entity.FiboInventory.Inventory>();
            var inv = await _inventoryRepository.GetAllInventoryAsync();
            var query = (from i in inv
                         select new
                         {

                             Id = i.ItemId
                             ,
                             LastPurchaseDate = i.CreatedDate
                             ,
                             InvId = i.Id
                             ,
                             Quantity = i.Quantity
                             ,
                             LastPurchaseQuantity= i.Quantity.ToDecimal()
                             ,
                             LastPurchasePrice= i.Rate.ToDecimal()
                             ,
                             ConsumedQuantity= i.ConsumedQuantity
                             ,
                             Total= i.Total
                             ,
                             Date = i.Date
                         }) ;
            if (!string.IsNullOrEmpty(vm.FromMiti) && !string.IsNullOrEmpty(vm.ToMiti))
            {
                vm.FromDate = vm.FromMiti.ToEnglishDate();
                vm.ToDate = vm.ToMiti.ToEnglishDate();
                query = (from i in inv
                         where i.Date >= vm.FromDate && i.Date <= vm.ToDate
                         select new
                         {

                             Id = i.ItemId
                             ,
                             LastPurchaseDate = i.CreatedDate
                             ,
                             InvId = i.Id
                             ,
                             Quantity = i.Quantity
                             ,
                             LastPurchaseQuantity= i.Quantity.ToDecimal()
                             ,
                             LastPurchasePrice= i.Rate.ToDecimal()
                             ,
                             ConsumedQuantity= i.ConsumedQuantity
                             ,
                             Total= i.Total
                             ,
                             Date = i.Date
                         }) ;
            }
            
            List<InventoryViewModel> inventory = query.GroupBy(l => l.Id).Select(cl => new InventoryViewModel
            {
                ItemId = (long?)cl.Select(c => c.Id).FirstOrDefault(),
                LastPurchaseDate = cl.Select(x=>x.LastPurchaseDate).LastOrDefault().ToString(),
                InvId = (long?)cl.Select(c => c.Id).FirstOrDefault(),
                Quantity = (cl.Sum(c => c.Quantity.ToDecimal())- cl.Sum(c => c.ConsumedQuantity.ToDecimal())).ToString(),
                LastPurchaseQuantity= cl.Select(c => c.Quantity).LastOrDefault().ToString(),
                LastPurchasePrice= cl.Select(c => c.LastPurchasePrice).LastOrDefault().ToString(),
                Total = cl.Sum(c => c.Total.ToDecimal()).ToString(),
                Date = cl.Select(x=>x.Date).ToDateTime(),
            }).ToList();
            if (vm.ItemId > 0)
            {
                inventory = inventory.Where(x => x.ItemId == vm.ItemId).ToList();
            }
            //if (!string.IsNullOrEmpty(vm.FromMiti))
            //{
            //    vm.FromDate = vm.FromMiti.ToEnglishDate();
            //    inventory = inventory.Where(x => x.Date >= vm.FromDate).ToList();
            //}
            //if (!string.IsNullOrEmpty(vm.ToMiti))
            //{
            //    vm.ToDate = vm.ToMiti.ToEnglishDate();
            //    inventory = inventory.Where(x => x.Date <= vm.ToDate).ToList();
            //}
            //if (string.IsNullOrEmpty(vm.FromMiti) && string.IsNullOrEmpty(vm.ToMiti))
            //{
            //    inventory = inventory.Where(x => x.LastPurchaseDate.ToEnglishDate() >= DateTime.Now.Date).ToList();
            //}
            vm.Inventories = inv;
            vm.InventoryVMList = inventory;
            return View(vm);
        }
        public async Task<ActionResult> MonthlyReport(long id)
        {
            PurchaseReportViewModel vm = new PurchaseReportViewModel()
            {
                MonthList = await _monthRepo.GetAllMonthAsync(),
                Years = await _yearRepo.GetAllYearAsync()
            };

            vm.ItemId = id;
            return View(vm);
        }
        public async Task<ActionResult> PurchaseReportDetails(string id)
        {
            long? itemId = long.Parse(id.Split("-")[0].Trim());
            string yearId = id.Split("-")[1].Trim();
            long lYearId = long.Parse(yearId);
            string monthNo = id.Split("-")[2].Trim();
            var yearRepo= await _yearRepo.GetByIdAsync(lYearId);
            string nepstartDate=string.Empty;
            string nependDate=string.Empty;
            if (monthNo == "12")
            {
                nepstartDate = yearRepo.YearName + "/" + monthNo + "/" + "1";
                nependDate = (Convert.ToDecimal(yearRepo.YearName) + Convert.ToDecimal(1)).ToString() + "/" + "1" + "/" + "1";
            }
            else
            {
                nepstartDate = yearRepo.YearName + "/" + monthNo + "/" + "1";
                nependDate = yearRepo.YearName + "/" + (Convert.ToDecimal(monthNo) + Convert.ToDecimal(1)).ToString() + "/" + "1";
            }
            DateTime? startDate = nepstartDate.ToEnglishDate();
            DateTime? endDate = nependDate.ToEnglishDate();

            PurchaseReportViewModel vm = new PurchaseReportViewModel();
            var year = await _yearRepo.GetAllYearAsync();
            var month = await _monthRepo.GetAllMonthAsync();
            var inv = await _inventoryRepository.GetAllInventoryAsync();
            vm.InventoryList = inv;
            vm.InventoryList = vm.InventoryList.Where(x => x.Date >= startDate && x.Date < endDate && x.ItemId == itemId).ToList();
            ViewBag.MonthOrder = monthNo;
            vm.YearId = lYearId;
            return View(vm);
        }
    }
}
