using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FiboBilling.InfraStructure.Repository;
using FiboBilling.InfraStructure.Service;
using FiboBilling.Src.ViewModel;
using FiboInfraStructure.Entity.FiboBilling;
using Microsoft.AspNetCore.Mvc;
using FiboInfraStructure;
using Microsoft.AspNetCore.Http;
using FiboBilling.Src.Dto;

namespace FiboCounterSystem.Areas.Billings.Controllers
{
    public class BillingReportController : Controller
    {
        private readonly IBillingService _billingService;
        private readonly IBillingInfoRepository _billingInfoRepository;
        private readonly IBillingRepository _billingRepository;
        private readonly IBillingStatusRepository _billingStatusRepository;
        private readonly IBillingStatusService _billingStatusService;
        public BillingReportController(IBillingService billingService
            , IBillingStatusRepository billingStatusRepository
            , IBillingStatusService billingStatusService
            , IBillingInfoRepository billingInfoRepository
            , IBillingRepository billingRepository)
        {
            _billingService = billingService;
            _billingInfoRepository = billingInfoRepository;
            _billingRepository = billingRepository;
            _billingStatusRepository = billingStatusRepository;
            _billingStatusService = billingStatusService;
        }
        [HttpGet]
        public async Task<IActionResult> BillingReport(BillingReportViewModel vm)
        {
            vm.BillingInfoList = await _billingInfoRepository.GetAllBillingAsync();
            vm.Billings = await _billingRepository.GetAllBillingAsync();
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
            }
            if (!string.IsNullOrEmpty(vm.PaymentMethod))
            {
                vm.Billings = vm.Billings.Where(x => x.PaymentMethod == vm.PaymentMethod).ToList();
            }
            return View(vm);
        }

        public async Task<ActionResult> BillingDetails(long id, String message)
        {
            BillingReportViewModel vm = new BillingReportViewModel();

            vm.Billings = await _billingRepository.GetAllBillingAsync();
            vm.Billings = vm.Billings.Where(x => x.Id == id).ToList();
            vm.BillingInfoList = new List<BillingInfo>();
            if (vm.Billings != null)
            {
                var billinginfo = await _billingInfoRepository.GetAllBillingAsync();
                var billinginfos = billinginfo.Where(x => x.BillingId == id).ToList();
                vm.BillingInfoList = billinginfos;
            }
            ViewBag.Message = message;
            return View(vm);
        }
        [HttpGet()]
        public async Task<IActionResult> BillingCreditReport(BillingReportViewModel vm)
        {
            vm.BillingInfoList = await _billingInfoRepository.GetAllBillingAsync();
            vm.Billings = await _billingRepository.GetAllBillingAsync();
            vm.Billings = vm.Billings.Where(x => x.IsCredit()).ToList();
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
            }
            if (!string.IsNullOrEmpty(vm.PaymentMethod))
            {
                vm.Billings = vm.Billings.Where(x => x.PaymentMethod == vm.PaymentMethod).ToList();
            }
            return View(vm);
        }
        [HttpPost]
        public async Task<IActionResult> BillingCreditReport(BillingReportViewModel vm, IFormCollection form)
        {
            var checkbox = this.Request.Form["chkSelected"];
            foreach (string item in checkbox)
            {
                BillingStatusDto dto = new BillingStatusDto();
                dto.BillingId = long.Parse(item);
                dto.IsPaid = true;
                await _billingStatusService.Insertasync(dto);

            }
            return RedirectToAction("BillingCreditReport");
        }
    }
}
