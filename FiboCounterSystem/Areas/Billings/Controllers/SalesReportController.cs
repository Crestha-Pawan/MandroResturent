using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FiboBilling.InfraStructure.Repository;
using FiboBilling.Src.ViewModel;
using FiboInfraStructure.Entity.FiboBilling;
using FiboInventory.InfraStructure.Repository;
using Microsoft.AspNetCore.Mvc;
using FiboInfraStructure;
using FiboInfraStructure.Entity.FiboInventory;
using FiboOffice.InfraStructure.Repository;

namespace FiboCounterSystem.Areas.Billings.Controllers
{
    public class SalesReportController : Controller
    {
        private readonly IBillingRepository _repo;
        private readonly IBillingInfoRepository _bInfoRepo;
        private readonly IProductRepository _pRepo;
        private readonly IMeasuringUnitRepository _measuringunitrepo;
        public SalesReportController(
            IBillingRepository repo
            , IBillingInfoRepository bInfoRepo
            , IProductRepository pRepo
            ,IMeasuringUnitRepository measuringunitrepo)
        {
            _repo = repo;
            _bInfoRepo = bInfoRepo;
            _pRepo = pRepo;
            _measuringunitrepo = measuringunitrepo;
        }
        public async Task<IActionResult> SalesReport(SalesReportViewModel vm)
        {
            var product = await _pRepo.GetAllProductAsync();
            vm.Products = new List<Product>();
            vm.Products = product;
            var billing = await _repo.GetAllBillingAsync();
            var bInfo = await _bInfoRepo.GetAllBillingAsync();
            var munit = await _measuringunitrepo.GetAllMeasuringUnitAsync();
            vm.Billings = await _repo.GetAllBillingAsync();



            var query = (from bi in bInfo
                         join b in billing on bi.BillingId equals b.Id
                         join p in product on bi.ProductId equals p.Id
                         //join m in munit on bi.Id equals m.Id
                         into q
                         where b.Status != "Cancelled"
                         //where m
                         select new { Id = bi.ProductId, BillDate = b.BillingDate.ToNepDate(), Quantity = bi.Quantity, Total = bi.Amount});
            List<SalesReportViewModel> sales = query.GroupBy(l => new { l.BillDate, l.Id }).Select(cl => new SalesReportViewModel
            {
                ProductId = (long)cl.Key.Id,
                Quantity = cl.Sum(c => c.Quantity),
                Total = cl.Sum(c=>c.Total),
                BillingDate = cl.Key.BillDate,

            }).ToList();

            vm.salesvm = sales;
            
            if (!string.IsNullOrEmpty(vm.FromMiti))
            {
                vm.FromDate = vm.FromMiti.ToEnglishDate();
                vm.salesvm = vm.salesvm.Where(x => x.BillingDate.ToEnglishDate() >= vm.FromDate).ToList();
            }
            if (!string.IsNullOrEmpty(vm.ToMiti))
            {
                vm.ToDate = vm.ToMiti.ToEnglishDate();
                vm.salesvm = vm.salesvm.Where(x => x.BillingDate.ToEnglishDate() <= vm.ToDate).ToList();
            }
            if (string.IsNullOrEmpty(vm.FromMiti) && string.IsNullOrEmpty(vm.ToMiti))
            {

                vm.salesvm = vm.salesvm.Where(x => x.BillingDate.ToEnglishDate() >= DateTime.Now.Date).ToList();
            }
            if (vm.ProductId > 0)
            {
                vm.salesvm = vm.salesvm.Where(x => x.ProductId == vm.ProductId).ToList();
            }
            return View(vm);
        }
    }
}
