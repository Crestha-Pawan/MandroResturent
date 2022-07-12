using FiboBilling.InfraStructure.Repository;
using FiboInfraStructure;
using FiboInventory.InfraStructure.Repository;
using FiboInventory.Src.ViewModel;
using FiboOffice.InfraStructure.Repository;
using FiboParty.Infrastructure.Repository;
using Microsoft.AspNetCore.Mvc;
using Payroll.InfraStructure.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FiboCounterSystem.Areas.DayCashBook.Controllers
{
    public class DayCashBookReportController : Controller
    {
        private readonly IInventoryRepository _invRepo;
        private readonly IBillingRepository _billingRepo;
        private readonly IBillingInfoRepository _billingInfoRepo;
        private readonly ILedgerRepository _ledgerRepo;
        private readonly ILedgerDetailRepository _ledgerDetailRepo;
        private readonly ISalarySheetRepository _salarySheetRepository;
        private readonly IExpenseRepository _expenseRepository;
        private readonly IDayCashBookRepository _dayCashBookRepository;
        public DayCashBookReportController(IInventoryRepository invRepo
            , IBillingRepository billingRepo
            , IBillingInfoRepository billingInfoRepo
            , ILedgerRepository ledgerRepo
            , ILedgerDetailRepository ledgerDetailRepo
            , ISalarySheetRepository salarySheetRepository
            , IExpenseRepository expenseRepository
            , IDayCashBookRepository dayCashBookRepository)
        {
            _invRepo = invRepo;
            _billingRepo = billingRepo;
            _billingInfoRepo = billingInfoRepo;
            _ledgerRepo = ledgerRepo;
            _ledgerDetailRepo = ledgerDetailRepo;
            _salarySheetRepository = salarySheetRepository;
            _expenseRepository = expenseRepository;
            _dayCashBookRepository = dayCashBookRepository;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        //public async Task<IActionResult> DayCashBookReport(DayCashBookReportViewModel vm)
        //{
        //    var inventory = await _invRepo.GetAllInventoryAsync();

        //    var ledgerdetail = await _ledgerDetailRepo.GetAllLedgerDetailAsync();
        //    var salarysheet = await _salarySheetRepository.GetAllSalarySheetAsync();
        //    var expenses = await _expenseRepository.GetAllExpense();
        //    var billinginfo = await _billingInfoRepo.GetAllBillingAsync();
        //    var billing = await _billingRepo.GetAllBillingAsync();
        //    var prevDayBalList = await _dayCashBookRepository.GetAllDayCashBookAsync();
        //    string prevDayBal = "0";
        //    decimal? balance = 0;
        //    if (!string.IsNullOrEmpty(vm.FromMiti) && !string.IsNullOrEmpty(vm.ToMiti))
        //    {
        //        balance = prevDayBalList.Where(x => x.OpeningDate >= vm.FromMiti.ToEnglishDate() && x.OpeningDate <= vm.ToMiti.ToEnglishDate()).FirstOrDefault().OpeningBalance.ToDecimal();
        //    }
        //    else
        //    {
        //        balance = prevDayBalList.Where(x => x.OpeningDate == DateTime.Today).FirstOrDefault().OpeningBalance.ToDecimal();
        //    }
        //    if (string.IsNullOrEmpty(vm.FromMiti) && string.IsNullOrEmpty(vm.ToMiti))
        //    {
        //        //vm.FromDate = DateTime.Now.AddDays(-1);
        //        //vm.ToDate = DateTime.Now;
        //        vm.FromDate = DateTime.Now.Date;
        //        vm.ToDate = DateTime.Now.Date.AddDays(1);
        //        billing = billing.Where(x => x.BillingDate > vm.FromDate && x.BillingDate < vm.ToDate).ToList();
        //    }
        //    if (string.IsNullOrEmpty(vm.FromMiti) && string.IsNullOrEmpty(vm.ToMiti))
        //    {
        //        vm.FromDate = DateTime.Now.AddDays(-1);
        //        vm.ToDate = DateTime.Now;
        //        //vm.FromDate = DateTime.Now.Date;
        //        //vm.ToDate = DateTime.Now.Date.AddDays(1);
        //        inventory = inventory.Where(x => x.Date >= vm.FromDate && x.Date <= vm.ToDate).ToList();

        //        expenses = expenses.Where(x => x.Date >= vm.FromDate && x.Date <= vm.ToDate).ToList();
        //    }
        //    if (!string.IsNullOrEmpty(vm.FromMiti))
        //    {
        //        vm.FromDate = vm.FromMiti.ToEnglishDate();
        //        inventory = inventory.Where(x => x.Date >= vm.FromDate).ToList();
        //        billing = billing.Where(x => x.BillingDate > vm.FromDate).ToList();
        //        expenses = expenses.Where(x => x.Date >= vm.FromDate).ToList();
        //    }
        //    if (!string.IsNullOrEmpty(vm.ToMiti))
        //    {
        //        vm.ToDate = vm.ToMiti.ToEnglishDate();
        //        inventory = inventory.Where(x => x.Date <= vm.ToDate).ToList();
        //        billing = billing.Where(x => x.BillingDate < vm.ToDate).ToList();
        //        expenses = expenses.Where(x => x.Date <= vm.ToDate).ToList();
        //    }
        //    #region previous day balance
        //    //decimal? balance = 0;
        //    //if (prevDayBal != null)
        //    //{
        //    //    balance = prevDayBal.OpeningBalance.ToDecimal();
        //    //}
        //    //else
        //    //{
        //    //    //DateTime? _frmdate = DateTime.Now.Date.AddDays(-1);
        //    //    //DateTime? _todate = DateTime.Now.Date;
        //    //    //decimal? amt = 0;
        //    //    //decimal? bamoutnt = 0;
        //    //    //decimal? lddr = 0;
        //    //    //decimal? ldcr = 0;
        //    //    //decimal? advncesal = 0;
        //    //    //decimal? salpaid = 0;
        //    //    //decimal? expamt = 0;

        //    //    //var inv = await _invRepo.GetAllInventoryAsync();
        //    //    //var exp = await _expenseRepository.GetAllExpense();
        //    //    //var binfo = await _billingRepo.GetAllBillingAsync();
        //    //    //if (!string.IsNullOrEmpty(vm.FromMiti))
        //    //    //{
        //    //    //    _frmdate = vm.FromDate.ToDateTime().Value.AddDays(-1).Date;
        //    //    //    inv = inventory.Where(x => x.Date > _frmdate).ToList();
        //    //    //    binfo = billing.Where(x => x.CreatedDate > _frmdate).ToList();
        //    //    //    exp = expenses.Where(x => x.CreatedDate > _frmdate).ToList();
        //    //    //}
        //    //    //if (!string.IsNullOrEmpty(vm.ToMiti))
        //    //    //{
        //    //    //    _todate = vm.ToDate;
        //    //    //    inv = inventory.Where(x => x.Date < _todate).ToList();
        //    //    //    binfo = billing.Where(x => x.CreatedDate < _todate).ToList();
        //    //    //    exp = expenses.Where(x => x.CreatedDate < _todate).ToList();
        //    //    //}
        //    //    //if(string.IsNullOrEmpty(vm.FromMiti) && string.IsNullOrEmpty(vm.ToMiti))
        //    //    //    {
        //    //    //        binfo = binfo.Where(x => x.BillingDate > _frmdate && x.BillingDate < _todate).ToList();
        //    //    //        inv = inv.Where(x => x.Date >= _frmdate && x.Date <= _todate).ToList();
        //    //    //        exp = exp.Where(x => x.Date >= _frmdate && x.Date <= _todate).ToList();

        //    //    //    }

        //    //    //foreach (var item in inv)
        //    //    //{
        //    //    //    amt += item.Total.ToDecimal();
        //    //    //}
        //    //    //foreach (var item in binfo)
        //    //    //{
        //    //    //    bamoutnt += item.Total.ToDecimal();
        //    //    //}
        //    //    //foreach (var item in exp)
        //    //    //{
        //    //    //    expamt += item.Amount.ToDecimal();
        //    //    //}

        //    //    //balance = bamoutnt.ToDecimal() - amt.ToDecimal() - expamt.ToDecimal(); /*- lddr.ToDecimal() + ldcr.ToDecimal() - salpaid.ToDecimal() - advncesal.ToDecimal()*/
        //    //    decimal? amt = 0;
        //    //    decimal? bamoutnt = 0;
        //    //    decimal? lddr = 0;
        //    //    decimal? ldcr = 0;
        //    //    decimal? advncesal = 0;
        //    //    decimal? salpaid = 0;
        //    //    decimal? expamt = 0;

        //    //    var inv = await _invRepo.GetAllInventoryAsync();
        //    //    var exp = await _expenseRepository.GetAllExpense();
        //    //    var binfo = await _billingRepo.GetAllBillingAsync();

        //    //    DateTime? _frmdate = DateTime.Now.AddDays(-1).Date;
        //    //    DateTime? _todate = DateTime.Now.Date;
        //    //    binfo = binfo.Where(x => x.BillingDate > _frmdate && x.BillingDate < _todate).ToList();


        //    //    DateTime? _frmdt = DateTime.Now.AddDays(-2);
        //    //    DateTime? _todt = DateTime.Now.AddDays(-1);


        //    //    inv = inv.Where(x => x.Date >= _frmdt && x.Date <= _todt).ToList();
        //    //    exp = exp.Where(x => x.Date >= _frmdt && x.Date <= _todt).ToList();


        //    //    foreach (var item in inv)
        //    //    {
        //    //        amt += item.Total.ToDecimal();
        //    //    }
        //    //    foreach (var item in binfo)
        //    //    {
        //    //        bamoutnt += item.Total.ToDecimal();
        //    //    }
        //    //    foreach (var item in exp)
        //    //    {
        //    //        expamt += item.Amount.ToDecimal();
        //    //    }

        //    //    balance = bamoutnt.ToDecimal() - amt.ToDecimal() - lddr.ToDecimal() + ldcr.ToDecimal() - salpaid.ToDecimal() - advncesal.ToDecimal() - expamt.ToDecimal();
        //    //}
        //    ViewBag.Balance = balance;
        //    #endregion

        //    vm.InventoryList = inventory;
        //    vm.BillingList = billing;
        //    vm.Expenses = expenses;
        //    return View(vm);
        //}

        public async Task<IActionResult> DayCashBookReport(DayCashBookReportViewModel vm)
        {
            var inventory = await _invRepo.GetAllInventoryAsync();
            var ledger = await _ledgerRepo.GetAllLedgerAsync();
            var ledgerdetail = await _ledgerDetailRepo.GetAllLedgerDetailAsync();
            var salarysheet = await _salarySheetRepository.GetAllSalarySheetAsync();
            var expenses = await _expenseRepository.GetAllExpense();
            var billinginfo = await _billingInfoRepo.GetAllBillingAsync();
            var billing = await _billingRepo.GetAllBillingAsync();
            var prevDayBalList = await _dayCashBookRepository.GetAllDayCashBookAsync();
            //string prevDayBal = "0";
            decimal? balance = 0;
            //if (!string.IsNullOrEmpty(vm.FromMiti) && !string.IsNullOrEmpty(vm.ToMiti))
            //{
            //    balance = prevDayBalList.Where(x => x.OpeningDate >= vm.FromMiti.ToEnglishDate() && x.OpeningDate <= vm.ToMiti.ToEnglishDate()).FirstOrDefault().OpeningBalance.ToDecimal();
            //}
            //else
            //{
            //    balance = prevDayBalList.Where(x => x.OpeningDate == DateTime.Today).FirstOrDefault().OpeningBalance.ToDecimal();
            //}
            if (string.IsNullOrEmpty(vm.FromMiti) && string.IsNullOrEmpty(vm.ToMiti))
            {
                vm.FromDate = DateTime.Now.Date;
                vm.ToDate = DateTime.Now.Date.AddDays(1);
                billing = billing.Where(x => x.BillingDate > vm.FromDate && x.BillingDate < vm.ToDate).ToList();
            }
            if (string.IsNullOrEmpty(vm.FromMiti) && string.IsNullOrEmpty(vm.ToMiti))
            {
                vm.FromDate = DateTime.Now.AddDays(-1);
                vm.ToDate = DateTime.Now;
                inventory = inventory.Where(x => x.Date >= vm.FromDate && x.Date <= vm.ToDate).ToList();
                salarysheet = salarysheet.Where(x => x.AdvanceSalaryDate.ToEnglishDate() >= vm.FromDate && x.AdvanceSalaryDate.ToEnglishDate() <= vm.ToDate).ToList();
                expenses = expenses.Where(x => x.Date >= vm.FromDate && x.Date <= vm.ToDate).ToList();
                ledgerdetail = ledgerdetail.Where(x => x.Date >= vm.FromDate && x.Date <= vm.ToDate).ToList();

            }
            if (!string.IsNullOrEmpty(vm.FromMiti))
            {
                vm.FromDate = vm.FromMiti.ToEnglishDate();
                inventory = inventory.Where(x => x.Date >= vm.FromDate).ToList();
                billing = billing.Where(x => x.BillingDate > vm.FromDate).ToList();
                expenses = expenses.Where(x => x.Date >= vm.FromDate).ToList();
                salarysheet = salarysheet.Where(x => x.AdvanceSalaryDate.ToEnglishDate() >= vm.FromDate).ToList();
                ledgerdetail = ledgerdetail.Where(x => x.Date >= vm.FromDate).ToList();
            }
            if (!string.IsNullOrEmpty(vm.ToMiti))
            {
                vm.ToDate = vm.ToMiti.ToEnglishDate();
                inventory = inventory.Where(x => x.Date < vm.ToDate).ToList();
                billing = billing.Where(x => x.BillingDate < vm.ToDate).ToList();
                expenses = expenses.Where(x => x.Date < vm.ToDate).ToList();
                salarysheet = salarysheet.Where(x => x.AdvanceSalaryDate.ToEnglishDate() < vm.ToDate).ToList();
                ledgerdetail = ledgerdetail.Where(x => x.Date < vm.ToDate).ToList();
            }
            //  #region previous day balance
            // // decimal? balance = 0;
            //  //if (prevDayBal != null)
            // // {
            //  //    balance = prevDayBal.OpeningBalance.ToDecimal();
            ////  }
            ////  else
            //  {   decimal? amt = 0;
            //      decimal? bamoutnt = 0;
            //      decimal? lddr = 0;
            //      decimal? ldcr = 0;
            //      decimal? advncesal = 0;
            //      decimal? salpaid = 0;
            //      decimal? expamt = 0;
            //      decimal? advancesalary = 0;
            //      decimal? totalsalary = 0;
            //      decimal? ledgerdr = 0;
            //      decimal? ledgercr = 0;
            //      var inv = await _invRepo.GetAllInventoryAsync();
            //      var exp = await _expenseRepository.GetAllExpense();
            //      var binfo = await _billingRepo.GetAllBillingAsync();
            //      var ledgeramt = await _ledgerRepo.GetAllLedgerAsync();
            //      var salary = await _salarySheetRepository.GetAllSalarySheetAsync();

            //      DateTime? _frmdate = DateTime.Now.AddDays(-1).Date;
            //      DateTime? _todate = DateTime.Now.Date;
            //      binfo = binfo.Where(x => x.BillingDate > _frmdate && x.BillingDate < _todate).ToList();


            //      DateTime? _frmdt = DateTime.Now.AddDays(-2);
            //      DateTime? _todt = DateTime.Now.AddDays(-1);
            //      inv = inv.Where(x => x.Date >= _frmdt && x.Date <= _todt).ToList();
            //      exp = exp.Where(x => x.Date >= _frmdt && x.Date <= _todt).ToList();
            //      salary = salary.Where(x => x.CreatedDate >= _frmdt && x.CreatedDate <= _todt).ToList();
            //      ledgeramt = ledgeramt.Where(x => x.CreatedDate >= _frmdt && x.CreatedDate <= _todt).ToList();


            //      foreach (var item in inv)
            //      {
            //          amt += item.Total.ToDecimal();
            //      }
            //      foreach (var item in binfo)
            //      {
            //          bamoutnt += item.Total.ToDecimal();
            //      }
            //      foreach (var item in exp)
            //      {
            //          expamt += item.Amount.ToDecimal();
            //      }
            //      foreach(var item in salary)
            //      {
            //          advancesalary += item.ToDecimal();
            //      }
            //      foreach (var item in salary)
            //      {
            //          totalsalary += item.NetSalary.ToDecimal();
            //      }
            //      foreach (var item in ledgeramt)
            //      {
            //          ledgerdr += item.Debit.ToDecimal();
            //      }
            //      foreach (var item in ledgeramt)
            //      {
            //          ledgercr += item.Credit.ToDecimal();
            //      }
            //      balance = bamoutnt.ToDecimal() - amt.ToDecimal() - lddr.ToDecimal() + ldcr.ToDecimal() - salpaid.ToDecimal() - advncesal.ToDecimal() - expamt.ToDecimal();
            //  }
            //  #endregion
            ViewBag.Balance = balance;

            vm.InventoryList = inventory;
            vm.BillingList = billing;
            vm.Expenses = expenses;
            vm.LedgerList = ledger;
            vm.LedgerDetailList = ledgerdetail;
            vm.SalarySheets = salarysheet;

            return View(vm);
        }
    }
}