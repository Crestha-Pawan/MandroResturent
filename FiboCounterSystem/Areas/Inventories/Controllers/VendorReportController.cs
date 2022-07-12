using FiboInventory.InfraStructure.Repository;
using FiboInventory.Src.ViewModel;
using FiboOffice.InfraStructure.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FiboInfraStructure;
using Microsoft.AspNetCore.Http;
using FiboInfraStructure.Entity.FiboInventory;

namespace FiboCounterSystem.Areas.Inventories.Controllers
{
    public class VendorReportController : Controller
    {
        private readonly IVendorRepository _vRepo;
        private readonly IInventoryRepository _invRepo;
        public readonly IItemRepository _itemRepository;
        public VendorReportController(IVendorRepository vRepo
            , IInventoryRepository invRepo
            , IItemRepository itemRepository
            )
        {
            _itemRepository = itemRepository;
            _vRepo = vRepo;
            _invRepo = invRepo;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> VendorList(VendorReportViewModel vm)
        {
            var vendor = await _vRepo.GetAllVendorAsync();
            vm.Vendors = new List<FiboInfraStructure.Entity.FiboOffice.Vendor>();

            vm.Vendors = vendor;
            vm.VedorList = vendor;
            if (vm.VendorId > 0)
            {
                vm.VedorList = vm.VedorList.Where(x => x.Id == vm.VendorId).ToList();
            }
            
            return View(vm);
        }
        [HttpGet]
        public async Task<IActionResult> VendorReport(long id)
        {
            VendorReportViewModel vm = new VendorReportViewModel();
            var item = await _itemRepository.GetAllItemAsync();
            vm.Items = new List<Item>();
            vm.Items = item;
            var invList = await _invRepo.GetAllInventoryAsync();
            vm.InventoryList = invList.Where(x => x.VendorId == id).ToList();
            vm.VendorId = id;
            return View(vm);
        }
        [HttpPost]
        public async Task<IActionResult> VendorReport(VendorReportViewModel vm)
        {
            var item = await _itemRepository.GetAllItemAsync();
            vm.Items = new List<Item>();
            vm.Items = item;
            var invList = await _invRepo.GetAllInventoryAsync();
            vm.InventoryList = invList.Where(x => x.VendorId == vm.VendorId).ToList();
            if (!string.IsNullOrEmpty(vm.FromMiti))
            {
                vm.FromDate = vm.FromMiti.ToEnglishDate();
                vm.InventoryList = vm.InventoryList.Where(x => x.Date >= vm.FromDate).ToList();
            }
            if (!string.IsNullOrEmpty(vm.ToMiti))
            {
                vm.ToDate = vm.ToMiti.ToEnglishDate();
                vm.InventoryList = vm.InventoryList.Where(x => x.Date <= vm.ToDate).ToList();
            }
            if (vm.ItemId > 0)
            {
                vm.InventoryList = vm.InventoryList.Where(x => x.ItemId == vm.ItemId).ToList();
            }
            //if (string.IsNullOrEmpty(_fromMiti) && string.IsNullOrEmpty(_toMiti))
            //{
            //    vm.InventoryList = vm.InventoryList.Where(x => x.Date >= DateTime.Now.Date).ToList();
            //}
            return View(vm);
        }

    }
}
