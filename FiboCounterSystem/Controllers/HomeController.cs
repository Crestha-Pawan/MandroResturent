using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using FiboBilling.InfraStructure.Repository;
using FiboBilling.InfraStructure.Service;
using FiboBilling.Src.ViewModel;
using FiboCounterSystem.Models;
using FiboInfraStructure;
using FiboInfraStructure.Entity.FiboBilling;
using FiboInventory.InfraStructure.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Payroll.InfraStructure.Repository;

namespace FiboCounterSystem.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IBillingService _billingService;
        private readonly IBillingInfoRepository _billingInfoRepository;
        private readonly IBillingRepository _billingRepository;
        private readonly INotificationRepository _notificationRepo;
        private readonly INotificationService _notificationService;
        private readonly IExpenseDetailRepository _expenseDetailRepository;
        private readonly IExpenseRepository _expenseRepository;
        private readonly IInventoryRepository _inventoryRepository;
        private readonly ISalarySheetRepository _salarySheetRepository;
        public HomeController(ILogger<HomeController> logger
            , IBillingService billingService
            , IBillingInfoRepository billingInfoRepository
            , IBillingRepository billingRepository
            , INotificationRepository notificationRepo
            , INotificationService notificationService
            , IExpenseDetailRepository expenseDetailRepository
            , IExpenseRepository expenseRepository
            , IInventoryRepository inventoryRepository
            , ISalarySheetRepository salarySheetRepository)
        {
            _logger = logger;
            _billingService = billingService;
            _billingInfoRepository = billingInfoRepository;
            _billingRepository = billingRepository;
            _notificationRepo = notificationRepo;
            _notificationService = notificationService;
            _expenseDetailRepository = expenseDetailRepository;
            _expenseRepository = expenseRepository;
            _inventoryRepository = inventoryRepository;
            _salarySheetRepository = salarySheetRepository;
        }

        [HttpGet]
        public async Task<IActionResult> Index(DashBoardViewModel vm, string message/*, string sortOrder, string currentFilter, string searchString, int? pageNumber*/)
        {
            //ViewData["CurrentSort"] = sortOrder;
            //if (searchString != null)
            //{
            //    pageNumber = 1;
            //}
            //else
            //{
            //    searchString = currentFilter;
            //}

            //ViewData["currentFilter"] = searchString;
            vm.BillingInfoList = await _billingInfoRepository.GetAllBillingAsync();
            vm.Billings = await _billingRepository.GetAllBillingAsync();
            vm.Expenses = await _expenseRepository.GetAllExpense();
            vm.Inventories = await _inventoryRepository.GetAllInventoryAsync();
            vm.salarySheets = await _salarySheetRepository.GetAllSalarySheetAsync();
            if (!string.IsNullOrEmpty(vm.Name))
            {
                vm.Billings = vm.Billings.Where(x => x.GuestName == vm.Name).ToList();
            }
            if (!string.IsNullOrEmpty(vm.FromMiti))
            {
                vm.FromDate = vm.FromMiti.ToEnglishDate();
                vm.Billings = vm.Billings.Where(x => x.BillingDate >= vm.FromDate).ToList();
            }
            if (!string.IsNullOrEmpty(vm.ToMiti))
            {
                vm.ToDate = vm.ToMiti.ToEnglishDate();
                vm.Billings = vm.Billings.Where(x => x.BillingDate <= vm.ToDate).ToList();
            }
            if (string.IsNullOrEmpty(vm.FromMiti) && string.IsNullOrEmpty(vm.ToMiti))
            {
                vm.Billings = vm.Billings.Where(x => x.BillingDate >= DateTime.Now.Date).ToList();
                vm.Inventories = vm.Inventories.Where(x => x.Date >= DateTime.Now.Date).ToList();
                vm.Expenses = vm.Expenses.Where(x => x.Date >= DateTime.Now.Date).ToList();
            }
            if (!string.IsNullOrEmpty(vm.PaymentMethod))
            {
                vm.Billings = vm.Billings.Where(x => x.PaymentMethod == vm.PaymentMethod).ToList();
            }
            ViewBag.Message = message;
            return View(vm);

        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        public IActionResult KitchenOrderTicket()
        {
            return View();
        }
        public IActionResult BarOrderTicket()
        {
            return View();
        }
        [HttpPost]
        public async Task<JsonResult> DeleteKOTNotification()
        {
            var notificationList = await _notificationRepo.GetAllNotificationAsync();
            var notification = notificationList.Where(x=>x.IsKOT==true).ToList();
            if (notification != null)
            {
                foreach (var item in notification)
                {
                    await _notificationService.Delete(item.Id);
                }
            }

            return Json("success");
        }
        [HttpPost]
        public async Task<JsonResult> DeleteBOTNotification()
        {
            var notificationList = await _notificationRepo.GetAllNotificationAsync();
            var notification = notificationList.Where(x=>x.IsKOT==false).ToList();
            if (notification != null)
            {
                foreach (var item in notification)
                {
                    await _notificationService.Delete(item.Id);
                }
            }

            return Json("success");
        }
        public async Task<JsonResult> CheckKOTNotification()
        {
            bool check= false;
            var notificationList = await _notificationRepo.GetAllNotificationAsync();
            var notification = notificationList.Where(x=>x.IsKOT==true).ToList();
            if (notification.Count() > 0)
            {
                check = true;
            }
            return Json(check);
        }
        public async Task<JsonResult> CheckBOTNotification()
        {
            bool check= false;
            var notificationList = await _notificationRepo.GetAllNotificationAsync();
            var notification = notificationList.Where(x=>x.IsKOT==false).ToList();
            if (notification.Count() > 0)
            {
                check = true;
            }
            return Json(check);
        }
    }
}
