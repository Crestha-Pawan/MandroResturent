using FiboInfraStructure.BaseInfraStructure;
using FiboInfraStructure.Data;
using FiboInfraStructure.Entity.FiboInventory;
using FiboInfraStructure.Entity.FiboOffice;
using FiboInventory.InfraStructure.Repository;
using FiboInventory.InfraStructure.Service;
using FiboInventory.Src.Dto;
using FiboInventory.Src.ViewModel;
using FiboOffice.InfraStructure.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FiboInfraStructure;
namespace FiboCounterSystem.Areas.Inventories.Controllers
{
    public class StockAdjustmentController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IUserAndBranchInfo _userAndBranchInfo;
        private readonly IItemRepository _itemRepository;
        private readonly IMeasuringUnitRepository _muRepo;
        private readonly IStockAdjustmentRepository _saRepo;
        private readonly IStockAdjustmentDetailRepository _saDetailRepo;
        private readonly IStockAdjustmentService _stockAdjustmentService;
        private readonly IStockAdjustmentDetailService _stockAdjustmentDetailService;
        public StockAdjustmentController(ApplicationDbContext context
            , IUserAndBranchInfo userAndBranchInfo
            , IItemRepository itemRepository
            , IMeasuringUnitRepository muRepo
            , IStockAdjustmentRepository saRepo
            , IStockAdjustmentDetailRepository saDetailRepo
            , IStockAdjustmentService stockAdjustmentService
            , IStockAdjustmentDetailService stockAdjustmentDetailService
            )
        {
            _context = context;
            _userAndBranchInfo = userAndBranchInfo;
            _itemRepository = itemRepository;
            _muRepo = muRepo;
            _saRepo = saRepo;
            _saDetailRepo = saDetailRepo;
            _stockAdjustmentService = stockAdjustmentService;
            _stockAdjustmentDetailService = stockAdjustmentDetailService;
        }
        public async Task<IActionResult> Index(StockAdjustmentViewModel vm, string message)
        {
            vm.StockAdjustmentList = new List<StockAdjustment>();
            var sa = await _saRepo.GetAllStockAdjustmentAsync();
            var detail = await _saDetailRepo.GetAllStockAdjustmentDetailAsync();
            vm.StockAdjustmentList = sa;
            vm.StockAdjustmentDetailList = detail;
            ViewBag.Message = message;
            return View(vm);
        }
        [HttpGet()]
        public async Task<IActionResult> Create()
        {
            StockAdjustmentDto dto = new StockAdjustmentDto
            {
                CreatedBy = await _userAndBranchInfo.getCurrentUser(),
                BranchId = await _userAndBranchInfo.getCurrentBranch(),
                Items= await _itemRepository.GetAllItemAsync(),
                MeasuringUnits = await _muRepo.GetAllMeasuringUnitAsync(),
                AdjustedBy = await _userAndBranchInfo.getCurrentUser(),
                AdjustmentDate = DateTime.Now.ToDateTime().ToNepDate(),
            };
            return View(dto);
        }
        public async Task<IActionResult> Create(StockAdjustmentDto dto)
        {
            using (IDbContextTransaction tran = _context.Database.BeginTransaction())
            {
                if (ModelState.IsValid)
                {
                    try
                    {
                        await _stockAdjustmentService.InsertAsync(dto);
                        await tran.CommitAsync();
                        return RedirectToAction("Index", "StockAdjustment", new { message = "Stock Adjustment has been saved successfully." });
                    }
                    catch (Exception ex)
                    {
                        await tran.RollbackAsync();
                        ViewBag.Message = "Error: Please contact System Administrator.";
                    }
                }
                else
                {
                    ViewBag.Message = "Error: Invalid Data !";
                }
            }
            return View(dto);
        }
    }
}
