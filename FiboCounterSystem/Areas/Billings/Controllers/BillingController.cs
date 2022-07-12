using FiboBilling.InfraStructure.Assembler;
using FiboBilling.InfraStructure.Repository;
using FiboBilling.InfraStructure.Service;
using FiboBilling.Src.Dto;
using FiboBilling.Src.ViewModel;
using FiboInfraStructure;
using FiboInfraStructure.BaseInfraStructure;
using FiboInfraStructure.Data;
using FiboInfraStructure.Entity.FiboBilling;
using FiboInventory.InfraStructure.Repository;
using FiboInventory.InfraStructure.Service;
using FiboOffice.InfraStructure.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FiboCounterSystem.Areas.Billings.Controllers
{
    public class BillingController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IBillingService _billingService;
        private readonly IBillingRepository _repo;
        private readonly IBillingAssembler _assembler;
        private readonly IBillingInfoService _bInfoService;
        private readonly IBillingInfoRepository _bInfoRepo;
        private readonly IBillingInfoAssembler _bInfoAssembler;
        private readonly IProductRepository _productRepo;
        private readonly IProductSubCategoryRepository _productSubCategoryRepo;
        private readonly ITableRepository _tableRepository;
        private readonly IUserAndBranchInfo _userAndBranchInfo;
        private readonly IItemRepository _itemRepository;
        private readonly IIngredientRepository _iRepo;
        private readonly IInventoryService _iInvService;
        private readonly IProductCategoryRepository _productCategoryRepo;
        private readonly ITaxRepository _taxRepo;
        private readonly IServiceChargeRepository _serviceChargeRepo;
        private readonly INotificationService _notificationService;
        private readonly INotificationRepository _notificationRepo;
        public BillingController(
            IBillingService billingService
            , IBillingRepository repo
            , IBillingAssembler assembler
            , IBillingInfoService bInfoService
            , IBillingInfoAssembler bInfoAssembler
            , IBillingInfoRepository bInfoRepo
            , IProductRepository productRepo
            , IProductSubCategoryRepository productSubCategoryRepo
            , ApplicationDbContext context
            , ITableRepository tableRepository
            , IUserAndBranchInfo userAndBranchInfo
            , IItemRepository itemRepository
            , IIngredientRepository iRepo
            , IInventoryService iInvService
            , IProductCategoryRepository productCategoryRepo
            , ITaxRepository taxRepo
            , IServiceChargeRepository serviceChargeRepo
            , INotificationService notificationService
            , INotificationRepository notificationRepo
            )
        {
            _repo = repo;
            _assembler = assembler;
            _billingService = billingService;
            _bInfoService = bInfoService;
            _bInfoRepo = bInfoRepo;
            _bInfoAssembler = bInfoAssembler;
            _productRepo = productRepo;
            _productSubCategoryRepo = productSubCategoryRepo;
            _context = context;
            _tableRepository = tableRepository;
            _userAndBranchInfo = userAndBranchInfo;
            _itemRepository = itemRepository;
            _iRepo = iRepo;
            _iInvService = iInvService;
            _productCategoryRepo = productCategoryRepo;
            _taxRepo = taxRepo;
            _serviceChargeRepo = serviceChargeRepo;
            _notificationRepo = notificationRepo;
            _notificationService = notificationService;
        }
        public async Task<IActionResult> Index(BillingViewModel vm, string message)
        {
            vm.Billings = new List<Billing>();
            var billing = await _repo.GetAllBillingAsync();
            vm.Billings = billing;
            vm.Tables = await _tableRepository.GetAllTableAsync();
            ViewBag.Message = message;
            return View(vm);
        }

        public async Task<IActionResult> LatestBilling(BillingViewModel vm, string message)
        {
            vm.Billings = new List<Billing>();
            var billing = await _repo.GetAllBillingAsync();
            vm.Billings = billing;
            vm.Tables = await _tableRepository.GetAllTableAsync();
            ViewBag.Message = message;
            return View(vm);
        }

        public async Task<IActionResult> NewBilling(string TableId)
        {
            long _tableId = long.Parse(TableId);
            BillingDto dto = new BillingDto();
            dto.Categories = await _productCategoryRepo.GetAllProductCategoryAsync();
            dto.OrderProducts = await _productRepo.GetAllProductAsync();
            dto.Tables = await _tableRepository.GetAllTableAsync();
            dto.BillingInfo = new List<BillingInfoDto>();
            var table = await _tableRepository.GetByIdAsync(_tableId);
            dto.TableId = _tableId;
            dto.TableNo = table.Name;
            var tables = await _tableRepository.GetAllTableAsync();
            dto.TableList = tables;



            var tax = await _taxRepo.GetAllTaxAsync();
            var activeTax = tax.Where(x => x.IsActive()).FirstOrDefault();
            var sc = await _serviceChargeRepo.GetAllServiceChargeAsync();
            var activeSc = sc.Where(x => x.IsActive()).FirstOrDefault();

            if (activeTax != null)
            {
                dto.TaxId = activeTax.Id;
            }
            if (activeSc != null)
            {
                dto.ServiceChargeId = activeSc.Id;
            }
            var orders = await _repo.GetAllBillingAsync();
            var prevOrder = orders.Where(x => x.IsWaiting() && x.TableId == _tableId).LastOrDefault();

            if (prevOrder != null && !prevOrder.IsCancelled())
            {
                var billingInfo = await _bInfoRepo.GetByBillingId(prevOrder.Id);
                dto.Id = prevOrder.Id;
                dto.GuestName = prevOrder.GuestName;
                dto.NetAmtPayable = prevOrder.NetAmtPayable;
                dto.Total = prevOrder.Total;
                dto.Discount = prevOrder.Discount;
                dto.TaxAmount = prevOrder.TaxAmount;
                dto.ServiceCharge = prevOrder.ServiceCharge;
                dto.BillingDate = prevOrder.BillingDate;
                dto.BillingNumber = prevOrder.BillingNumber;
                dto.KotBotBy = prevOrder.KotBotBy;

                foreach (var info in billingInfo)
                {
                    BillingInfoDto info_dto = new BillingInfoDto();
                    _bInfoAssembler.copyFrom(info_dto, info);
                    dto.BillingInfo.Add(info_dto);
                }
            }
            return View(dto);
        }

        public async Task<IActionResult> CancelOrder(long TableId)
        {
            var orders = await _repo.GetAllBillingAsync();
            var prevOrder = orders.Where(x => x.IsWaiting() && x.TableId == TableId).LastOrDefault();
            prevOrder.cancel();
            BillingDto dto = new BillingDto();
            _assembler.copyFrom(dto, prevOrder);
            await _billingService.UpdateAsync(dto).ConfigureAwait(true);
            return RedirectToAction("NewBilling", "Billing", new { TableId = TableId });
        }

        [HttpGet()]
        public async Task<IActionResult> CreateNew(long TableId)
        {
            var table = await _tableRepository.GetByIdAsync(TableId);
            var billings = await _repo.GetAllBillingAsync();
            var billing = billings.Where(x => x.IsWaiting() && x.TableId == TableId).FirstOrDefault();

            BillingDto dto = new BillingDto
            {
                TableNo = table.Name,
                TableId = TableId,
                CreatedBy = await _userAndBranchInfo.getCurrentUser(),
                BranchId = await _userAndBranchInfo.getCurrentBranch(),
                BillingDate = DateTime.Now,
                BillingInfo = new List<BillingInfoDto>(),
                Products = await _productRepo.GetAllProductAsync()
            };
            if (billing != null)
            {
                _assembler.copyFrom(dto, billing);
                dto.CreatedBy = await _userAndBranchInfo.getCurrentUser();
                var entities = await _bInfoRepo.GetByBillingId(billing.Id);
                foreach (var info in entities)
                {
                    BillingInfoDto info_dto = new BillingInfoDto();
                    _bInfoAssembler.copyFrom(info_dto, info);
                    dto.BillingInfo.Add(info_dto);
                }
            }
            return View(dto);
        }

        [HttpPost()]
        [ValidateAntiForgeryToken()]
        public async Task<IActionResult> CreateNew(BillingDto dto)
        {
            using (IDbContextTransaction tran = _context.Database.BeginTransaction())
            {
                try
                {
                    if (ModelState.IsValid)
                    {
                        var billings = await _repo.GetAllBillingAsync();
                        if (dto.Id == 0)
                        {
                            dto.BillingNumber = billings.Count().ToString();
                            
                            await _billingService.InsertAsync(dto);
                            NotificationDto notificationDto = new NotificationDto()
                            {
                                IsChecked = true,
                            };
                            foreach (var dto_info in dto.BillingInfo)
                            {
                                var _product = await _productRepo.GetByIdAsync(long.Parse(dto_info.ProductId.ToString()));
                                var _category = await _productCategoryRepo.GetByIdAsync(long.Parse(_product.ProductCategoryId.ToString()));
                                if (_category != null)
                                {
                                    if (_category.Name.ToLower() == "beverage")
                                    {
                                        notificationDto.IsKOT = false;
                                    }
                                    else
                                    {
                                        notificationDto.IsKOT = true;
                                    }
                                }
                            }
                            await _notificationService.InsertAsync(notificationDto);
                        }
                        else
                        {
                            dto.BillingNumber = billings.Count().ToString();
                            await _billingService.UpdateAsync(dto);
                            NotificationDto notificationDto = new NotificationDto()
                            {
                                IsChecked = true,
                            };
                            foreach (var dto_info in dto.BillingInfo)
                            {
                                var _product = await _productRepo.GetByIdAsync(long.Parse(dto_info.ProductId.ToString()));
                                var _category = await _productCategoryRepo.GetByIdAsync(long.Parse(_product.ProductCategoryId.ToString()));
                                if (_category != null)
                                {
                                    if (_category.Name.ToLower() == "beverage")
                                    {
                                        notificationDto.IsKOT = false;
                                    }
                                    else
                                    {
                                        notificationDto.IsKOT = true;
                                    }
                                }
                            }
                            await _notificationService.InsertAsync(notificationDto);
                        }


                        if (dto.IsClear)
                        {
                            foreach (var dto_info in dto.BillingInfo)
                            {
                                decimal quantity = 0;
                                if (dto_info.ProductId != null)
                                {
                                    var ingredients = await _iRepo.GetAllIngredientAsync();
                                    ingredients = ingredients.Where(x => x.ProductId == dto_info.ProductId).ToList();
                                    foreach (var item in ingredients)
                                    {
                                        quantity = item.Quantity.ToDecimal() * dto_info.Quantity.ToDecimal();

                                        if (quantity > 0)
                                        {
                                            await _iInvService.UpdateFromBillingAsync((long)item.ItemId, quantity);
                                        }
                                    }
                                }
                            }
                            await tran.CommitAsync();
                            return RedirectToAction("BillingDetails", "BillingReport", new { id = dto.Id, message = "Billing has been cleared." });
                        }
                        else
                        {
                            await tran.CommitAsync();
                            return RedirectToAction("Index", "Billing", new { message = "Order has been saved successfully." });
                        }
                    }
                    else
                    {
                        ViewBag.Message = "Error: Invalid Data !";
                    }

                }
                catch (Exception ex)
                {
                    await tran.RollbackAsync();
                    ViewBag.Message = "Error: Please contact System Administrator.";
                }
            }
            return View(dto);
        }

        [HttpGet()]
        public async Task<IActionResult> Create(long TableId)
        {
            BillingDto dto = new BillingDto();
            dto.TableId = TableId;
            dto.Categories = await _productCategoryRepo.GetAllProductCategoryAsync();
            dto.OrderProducts = await _productRepo.GetAllProductAsync();
            dto.Tables = await _tableRepository.GetAllTableAsync();
            dto.BillingInfo = new List<BillingInfoDto>();
            var table = await _tableRepository.GetByIdAsync(TableId);
            dto.TableNo = table.Name;

            var tax = await _taxRepo.GetAllTaxAsync();
            var activeTax = tax.Where(x => x.IsActive()).FirstOrDefault();
            var sc = await _serviceChargeRepo.GetAllServiceChargeAsync();
            var activeSc = sc.Where(x => x.IsActive()).FirstOrDefault();

            if (activeTax != null)
            {
                dto.TaxId = activeTax.Id;
            }
            if (activeSc != null)
            {
                dto.ServiceChargeId = activeSc.Id;
            }
            var orders = await _repo.GetAllBillingAsync();
            var prevOrder = orders.Where(x => x.IsWaiting() && x.TableId == TableId).LastOrDefault();

            if (prevOrder != null)
            {
                var billingInfo = await _bInfoRepo.GetByBillingId(prevOrder.Id);
                dto.Id = prevOrder.Id;
                dto.GuestName = prevOrder.GuestName;
                dto.NetAmtPayable = prevOrder.NetAmtPayable;
                dto.Total = prevOrder.Total;
                dto.Discount = prevOrder.Discount;
                dto.TaxAmount = prevOrder.TaxAmount;
                dto.ServiceCharge = prevOrder.ServiceCharge;
                dto.BillingDate = prevOrder.BillingDate;
                dto.BillingNumber = prevOrder.BillingNumber;
                dto.PaymentMethod = prevOrder.PaymentMethod;

                foreach (var info in billingInfo)
                {
                    BillingInfoDto info_dto = new BillingInfoDto();
                    _bInfoAssembler.copyFrom(info_dto, info);
                    dto.BillingInfo.Add(info_dto);
                }
            }
            return View(dto);
        }

        [HttpPost()]
        [ValidateAntiForgeryToken()]
        public async Task<IActionResult> Create(BillingDto dto)
        {
            using (IDbContextTransaction tran = _context.Database.BeginTransaction())
            {
                try
                {
                    if (ModelState.IsValid)
                    {
                        var billings = await _bInfoRepo.GetAllBillingAsync();
                        if (dto.Id == 0)
                        {
                            dto.BillingNumber = billings.Count().ToString();
                            await _billingService.InsertAsync(dto);
                        }
                        else
                        {
                            await _billingService.UpdateAsync(dto);
                        }


                        if (dto.IsClear)
                        {
                            foreach (var dto_info in dto.BillingInfo)
                            {
                                decimal quantity = 0;
                                if (dto_info.ProductId != null)
                                {
                                    var ingredients = await _iRepo.GetAllIngredientAsync();
                                    ingredients = ingredients.Where(x => x.ProductId == dto_info.ProductId).ToList();
                                    foreach (var item in ingredients)
                                    {
                                        quantity = item.Quantity.ToDecimal() * dto_info.Quantity.ToDecimal();

                                        if (quantity > 0)
                                        {
                                            await _iInvService.UpdateFromBillingAsync((long)item.ItemId, quantity);
                                        }
                                    }
                                }
                            }

                            await tran.CommitAsync();
                            return RedirectToAction("BillingDetails", "BillingReport", new { id = dto.Id, message = "Billing has been saved successfully." });
                        }
                        else
                        {
                            await tran.CommitAsync();
                            return RedirectToAction("Index", "Billing", new { message = "Billing has been saved successfully." });
                        }
                    }
                    else
                    {
                        ViewBag.Message = "Error: Invalid Data !";
                    }

                }
                catch (Exception ex)
                {
                    await tran.RollbackAsync();
                    ViewBag.Message = "Error: Please contact System Administrator.";
                }
            }
            return View(dto);
        }

        [HttpPost()]
        [ValidateAntiForgeryToken()]
        public async Task<IActionResult> Update(BillingDto dto)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    await _billingService.UpdateAsync(dto);
                    return RedirectToAction(nameof(Index));
                }
            }
            catch (Exception ex)
            {
                throw new Exception();
            }
            return View();
        }

        public async Task<ActionResult> PrintKOT(long id, String message)
        {
            BillingReportViewModel vm = new BillingReportViewModel();

            vm.Billings = await _repo.GetAllBillingAsync();
            vm.Billings = vm.Billings.Where(x => x.Id == id).ToList();
            vm.BillingInfoList = new List<BillingInfo>();
            if (vm.Billings != null)
            {
                var billinginfo = await _bInfoRepo.GetAllBillingAsync();
                var billinginfos = billinginfo.Where(x => x.BillingId == id && x.IsKOT == true ).ToList();
                vm.BillingInfoList = billinginfos;
            }
            ViewBag.Message = message;
            return View(vm);
        }
        public async Task<ActionResult> PrintBOT(long id, String message)
        {
            BillingReportViewModel vm = new BillingReportViewModel();
            vm.Billings = await _repo.GetAllBillingAsync();
            vm.Billings = vm.Billings.Where(x => x.Id == id).ToList();
            vm.BillingInfoList = new List<BillingInfo>();
            if (vm.Billings != null)
            {
               
                var billinginfo = await _bInfoRepo.GetAllBillingAsync();
               var billinginfos = billinginfo.Where(x => x.BillingId == id && x.IsKOT == false).ToList();
                vm.BillingInfoList = billinginfos;
                
            }
            ViewBag.Message = message;
            return View(vm);
        }

        [HttpGet()]
        public async Task<IActionResult> Delete(long id)
        {
            var billing = await _repo.GetByIdAsync(id) ?? throw new Exception();
            return View(billing);
        }

        [HttpPost()]
        [ValidateAntiForgeryToken()]
        public async Task<IActionResult> DeleteConfirmed(Billing billing)
        {
            try
            {
                if (billing != null)
                {
                    await _billingService.Delete(billing.Id).ConfigureAwait(true);
                    return RedirectToAction(nameof(Index));
                }
            }
            catch (Exception ex)
            {
                throw new Exception();
            }
            return View(billing);
        }
        public async Task<JsonResult> CheckTable(string id)
        {
            long? tableId = long.Parse(id);
            bool check = false;
            var billingList = await _repo.GetAllBillingAsync();
            var billing = billingList.Where(x => x.TableId == tableId && x.IsWaiting());
            if (billing.Count() > 0)
            {
            }
            else
            {
                check = true;
            }
            return Json(check);
        }
        public async Task<JsonResult> GetTableNo(string id)
        {
            long? tableId = long.Parse(id);
            var tableList = await _tableRepository.GetAllTableAsync();
            var table = tableList.Where(x => x.Id == tableId).FirstOrDefault();
            return Json(table.Name);
        }
    }
}
