using FiboInfraStructure.BaseInfraStructure;
using FiboInfraStructure.Entity.FiboInventory;
using FiboInventory.InfraStructure.Assembler;
using FiboInventory.InfraStructure.Repository;
using FiboInventory.InfraStructure.Service;
using FiboInventory.Src.Dto;
using FiboInventory.Src.ViewModel;
using FiboOffice.InfraStructure.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FiboInfraStructure;
using FiboInfraStructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.ViewEngines;
using FiboInfraStructure.Common;
using System.IO;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using FiboOffice.Src.Dto;
using FiboOffice.InfraStructure.Service;
using FiboInfraStructure;
namespace FiboCounterSystem.Areas.Inventories.Controllers
{
    public class InventoryController : Controller
    {
        private readonly IInventoryService _invService;
        private readonly IInventoryRepository _repo;
        private readonly IInventoryAssembler _assembler;
        private readonly IItemRepository _itemRepo;
        private readonly IMeasuringUnitRepository _muRepo;
        private readonly IUserAndBranchInfo _userAndBranchInfo;
        private readonly IInventorySummaryService _invSummaryService;
        private readonly IInventorySummaryRepository _invSumRepo;
        private readonly IVendorRepository _vendorRepo;
        private readonly IVendorService _vendorService;
        private readonly ApplicationDbContext _context;
        public InventoryController(
            IInventoryService invService
            , IInventoryRepository repo
            , IItemRepository itemRepo
            , IMeasuringUnitRepository muRepo
            , IInventoryAssembler assembler
            , IUserAndBranchInfo userAndBranchInfo
            , IInventorySummaryService invSummaryService
            , IInventorySummaryRepository invSumRepo
            , IVendorRepository vendorRepo
            , IVendorService vendorService
            , ApplicationDbContext context

            )
        {
            _repo = repo;
            _assembler = assembler;
            _invService = invService;
            _itemRepo = itemRepo;
            _muRepo = muRepo;
            _invSumRepo = invSumRepo;
            _vendorRepo = vendorRepo;
            _vendorService = vendorService;
            _userAndBranchInfo = userAndBranchInfo;
            _invSummaryService = invSummaryService;
            _context = context;

        }
        public async Task<IActionResult> Index(InventoryViewModel vm, string message)
        {
            vm.Inventories = new List<FiboInfraStructure.Entity.FiboInventory.Inventory>();
            var inv = await _repo.GetAllInventoryAsync();
            vm.Inventories = inv;
            vm.Inventories = vm.Inventories.Where(x => x.Date > DateTime.Now.AddDays(-1) && x.Date < DateTime.Now.AddDays(1)).ToList();
            ViewBag.Message = message;
            return View(vm);
        }
        [HttpGet()]
        public async Task<IActionResult> Create()
        {
            InventoryDto dto = new InventoryDto()
            {
                Items = await _itemRepo.GetAllItemAsync(),
                MeasuringUnits = await _muRepo.GetAllMeasuringUnitAsync(),
                CreatedBy = await _userAndBranchInfo.getCurrentUser(),
                BranchId = await _userAndBranchInfo.getCurrentBranch(),
                Vendors= await _vendorRepo.GetAllVendorAsync(),
                Date = DateTime.Now.ToDateTime().ToNepDate(),
            };

            return View(dto);
        }

        [HttpPost()]
        [ValidateAntiForgeryToken()]
        public async Task<IActionResult> Create(InventoryDto dto)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    foreach (var item in dto.InventoryInfo)
                    {
                        item.Date = dto.Date;
                        item.VendorId = dto.VendorId;
                        await _invService.Insertasync(item);
                    }
                    return RedirectToAction("Index", "Inventory", new { message = "Inventory has been saved successfully." });
                }
                else
                {
                    ViewBag.Message = "Error: Invalid data !";
                }
            }
            catch (Exception ex)
            {
                ViewBag.Message = "Error: Please contact Administrator.";
            }
            return View(dto);
        }
        [HttpGet()]
        public async Task<IActionResult> UpdateNew(long? id)
        {
            if (!id.HasValue)
            {

            }
            var inv = await _repo.GetByIdAsync((long)id);
            InventorySummaryDto dto = new InventorySummaryDto();
            dto.InventoryId = id;
            dto.StockInHand = inv.Quantity.ToDecimal() - inv.ConsumedQuantity;
            return View(dto);
        }
        [HttpPost()]
        [ValidateAntiForgeryToken()]
        public async Task<IActionResult> UpdateNew(InventorySummaryDto dto)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    await _invSummaryService.Insertasync(dto);

                    await _invService.UpdateFromSummaryAsync(dto);
                    return RedirectToAction("Index", "Inventory", new { message = "Stock has been saved successfully." });
                }
                else
                {
                    ViewBag.Message = "Error: Invalid data !";
                }
            }
            catch (Exception ex)
            {
                ViewBag.Message = "Error: Please contact Administrator.";
            }
            return View();
        }
        [HttpGet()]
        public async Task<IActionResult> Update(long? id)
        {
            if (!id.HasValue)
            {

            }
            var inv = await _repo.GetByIdAsync(id.Value) ?? throw new Exception();
            InventoryDto dto = new InventoryDto();
            _assembler.copyFrom(dto, inv);
            return View(dto);
        }
        [HttpPost()]
        [ValidateAntiForgeryToken()]
        public async Task<IActionResult> Update(InventoryDto dto)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    await _invService.UpdateAsync(dto);
                    return RedirectToAction("Index", "Inventory", new { message = "Inventory has been saved successfully." });
                }
                else
                {
                    ViewBag.Message = "Error: Invalid data !";
                }
            }
            catch (Exception ex)
            {
                ViewBag.Message = "Error: Please contact Administrator.";
            }
            return View();
        }

        public async Task<JsonResult> getPartialViewVendor([FromServices] ICompositeViewEngine viewEngine)
        {
            var _result = new ResponseData();
            try
            {
                string dtResult = await RenderPartialView("_createVendor",viewEngine);
                _result.Success = true;
                _result.Message = dtResult;

            }
            catch (Exception ex)
            {
                _result.Success = false;
                _result.Message = ex.Message;
            }

            return Json(_result);
        }

        [HttpPost()]
        [ValidateAntiForgeryToken()]
        public async Task<IActionResult> SaveVendor(VendorDto dto)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    await _vendorService.InsertAsync(dto);
                    return RedirectToAction("Create", "Inventory", new { message = "Vendor has been saved successfully." });
                }
                else
                {
                    ViewBag.Message = "Error: Invalid data !";
                }
            }
            catch (Exception ex)
            {
                ViewBag.Message = "Error: Please contact Administrator.";
            }
            return View(dto);
        }
        [HttpGet()]
        public async Task<IActionResult> Delete(long id)
        {
            var inv = await _repo.GetByIdAsync(id) ?? throw new Exception();
            return View(inv);
        }

        [HttpPost()]
        [ValidateAntiForgeryToken()]
        public async Task<IActionResult> DeleteConfirmed(FiboInfraStructure.Entity.FiboInventory.Inventory inv)
        {
            try
            {
                if (inv != null)
                {
                    await _invService.Delete(inv.Id).ConfigureAwait(true);
                    return RedirectToAction(nameof(Index));
                }
            }
            catch (Exception ex)
            {
                throw new Exception();
            }
            return View(inv);
        }

        protected async Task<string> RenderPartialView(string viewName, ICompositeViewEngine _viewEngine, object model = null)
        {
            if (string.IsNullOrEmpty(viewName))
                viewName = ControllerContext.ActionDescriptor.ActionName;

            ViewData.Model = model;

            using (var writer = new StringWriter())
            {
                ViewEngineResult viewResult = _viewEngine.FindView(ControllerContext, viewName, false);

                ViewContext viewContext = new ViewContext(
                    ControllerContext,
                    viewResult.View,
                    ViewData,
                    TempData,
                    writer,
                    new HtmlHelperOptions()
                );

                await viewResult.View.RenderAsync(viewContext);

                return writer.GetStringBuilder().ToString();
            }
        }
    }
}
