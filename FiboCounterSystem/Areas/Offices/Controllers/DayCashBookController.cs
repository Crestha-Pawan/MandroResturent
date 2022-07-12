using FiboInfraStructure.BaseInfraStructure;
using FiboOffice.InfraStructure.Assembler;
using FiboOffice.InfraStructure.Repository;
using FiboOffice.InfraStructure.Service;
using FiboOffice.Src.Dto;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FiboInfraStructure;
using FiboInventory.InfraStructure.Repository;
using FiboBilling.InfraStructure.Repository;
using FiboParty.Infrastructure.Repository;
using Payroll.InfraStructure.Repository;

namespace FiboCounterSystem.Areas.Offices.Controllers
{
    public class DayCashBookController : Controller
    {
        private readonly IDayCashBookService _service;
        private readonly IDayCashBookRepository _repo;
        private readonly IDayCashBookAssembler _assembler;
        private readonly IUserAndBranchInfo _userAndBranchInfo;
        private readonly IInventoryRepository _invRepo;
        private readonly IBillingRepository _billingRepo;
        private readonly IBillingInfoRepository _billingInfoRepo;
        private readonly ILedgerRepository _ledgerRepo;
        private readonly ILedgerDetailRepository _ledgerDetailRepo;
        private readonly ISalarySheetRepository _salarySheetRepository;
        private readonly IExpenseRepository _expenseRepository;
        private readonly IPartyRepository _partyRepo;
        public DayCashBookController(IDayCashBookService service, IDayCashBookRepository repo,
            IDayCashBookAssembler assembler
            , IUserAndBranchInfo userAndBranchInfo
            , IInventoryRepository invRepo
            , IBillingRepository billingRepo
            , IBillingInfoRepository billingInfoRepo
            , ILedgerRepository ledgerRepo
            , ILedgerDetailRepository ledgerDetailRepo
            , ISalarySheetRepository salarySheetRepository
            , IExpenseRepository expenseRepository
            , ILedgerRepository ledgerRepository)
        {
            _repo = repo;
            _assembler = assembler;
            _service = service;
            _userAndBranchInfo = userAndBranchInfo;
            _invRepo = invRepo;
            _billingRepo = billingRepo;
            _billingInfoRepo = billingInfoRepo;
            _ledgerRepo = ledgerRepo;
            _ledgerDetailRepo = ledgerDetailRepo;
            _salarySheetRepository = salarySheetRepository;
            _expenseRepository = expenseRepository;
            _ledgerRepo = ledgerRepository;
        }
        [HttpGet()]
        public async Task<IActionResult> Create()
        {
            DayCashBookDto dto = new DayCashBookDto()
            {
                CreatedBy = await _userAndBranchInfo.getCurrentUser(),
                
            };
            var inventory = await _invRepo.GetAllInventoryAsync();
            var ledgerdetail = await _ledgerDetailRepo.GetAllLedgerDetailAsync();
            var salarysheet = await _salarySheetRepository.GetAllSalarySheetAsync();
            var expenses = await _expenseRepository.GetAllExpense();
            var billinginfo = await _billingInfoRepo.GetAllBillingAsync();
            var billing = await _billingRepo.GetAllBillingAsync();
            var ledger = await _ledgerRepo.GetAllLedgerAsync();
            DateTime?  FromDate = DateTime.Now.Date;
            DateTime? ToDate = DateTime.Now.Date.AddDays(1);
            billing = billing.Where(x => x.BillingDate > FromDate && x.BillingDate < ToDate).ToList();

            DateTime? _fromDate = DateTime.Now.AddDays(-1);
            DateTime? _toDate  = DateTime.Now;

            inventory = inventory.Where(x => x.Date >= _fromDate && x.Date <= _toDate).ToList();
            expenses = expenses.Where(x => x.Date >= _fromDate && x.Date <= _toDate).ToList();
            salarysheet = salarysheet.Where(x => x.AdvanceSalaryDate.ToEnglishDate() >= _fromDate && x.AdvanceSalaryDate.ToEnglishDate() <= _toDate).ToList();
            ledgerdetail = ledgerdetail.Where(x => x.Date > _fromDate && x.Date < _toDate).ToList();

            #region previous day balance
            var prevDayBalList = await _repo.GetAllDayCashBookAsync();
            var prevDayBal = prevDayBalList.Where(x=>x.OpeningDate == DateTime.Today).FirstOrDefault();
            decimal? balance=0;
            if (prevDayBal != null)
            {
                balance = prevDayBal.OpeningBalance.ToDecimal();
            }
            else
            {
                
                decimal? amt = 0;
                decimal? bamoutnt = 0;
                decimal? lddr = 0;
                decimal? ldcr = 0;
                decimal? advncesal = 0;
                decimal? salpaid = 0;
                decimal? expamt = 0;
                decimal? sal = 0;
                decimal? ledgerdr = 0;
                decimal? ledgercr = 0;
                decimal? advancesalary = 0;
                var inv = await _invRepo.GetAllInventoryAsync();
                var exp = await _expenseRepository.GetAllExpense();
                var binfo = await _billingRepo.GetAllBillingAsync();
                var salary = await _salarySheetRepository.GetAllSalarySheetAsync();
                var ledgeramt = await _ledgerRepo.GetAllLedgerAsync();
                var ledgerdetailamt = await _ledgerDetailRepo.GetAllLedgerDetailAsync();

                DateTime?  _frmdate = DateTime.Now.AddDays(-1).Date;
                DateTime? _todate = DateTime.Now.Date;

                binfo = binfo.Where(x => x.BillingDate > _frmdate && x.BillingDate < _todate).ToList();


                DateTime? _frmdt = DateTime.Now.AddDays(-2);
                DateTime? _todt  = DateTime.Now.AddDays(-1);


                inv = inv.Where(x => x.Date >= _frmdt && x.Date <= _todt).ToList();
                exp = exp.Where(x => x.Date >= _frmdt && x.Date <= _todt).ToList();
                salary = salary.Where(x => x.AdvanceSalaryDate.ToEnglishDate() >= _frmdt && x.AdvanceSalaryDate.ToEnglishDate() <= _todt).ToList();
                ledgerdetailamt = ledgerdetailamt.Where(x => x.Date >= _frmdt && x.Date <= _todt).ToList();

                foreach (var item in inv)
                {
                    amt += item.Total.ToDecimal();
                }
                foreach (var item in binfo)
                {
                    bamoutnt += item.Total.ToDecimal();
                }
                foreach (var item in exp)
                {
                    expamt += item.Amount.ToDecimal();
                }
                foreach(var item in salary)
                {
                    sal += item.NetSalary.ToDecimal();
                }
                foreach(var item in salary)
                {
                    advancesalary += item.AdvanceSalary.ToDecimal();
                }
                foreach (var item in ledgerdetailamt)
                { 
                    ledgerdr += item.DebitAmount.ToDecimal();
                }
                foreach (var item in ledgerdetailamt)
                {
                    ledgercr += item.CreditAmount.ToDecimal();
                }
                balance = bamoutnt.ToDecimal() - amt.ToDecimal() - lddr.ToDecimal() + ldcr.ToDecimal() - salpaid.ToDecimal() - advncesal.ToDecimal() - expamt.ToDecimal() -sal.ToDecimal()-ledgeramt.ToDecimal();
            }
            ViewBag.Balance = balance;
            #endregion

            dto.InventoryList = inventory;
            dto.BillingList = billing;
            dto.SalarySheets = salarysheet; 
            dto.Expenses = expenses;
            dto.LedgerDetailList = ledgerdetail;
            return View(dto);
        }
         
        [HttpPost()]
        [ValidateAntiForgeryToken()]
        public async Task<IActionResult> Create(DayCashBookDto dto)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    dto.OpeningDate = DateTime.Now.AddDays(1).Date;
                    await _service.InsertAsync(dto);
                    return RedirectToAction("DayCashBookReport", "DayCashBookReport", new { message = "DayCashBook has been saved successfully." });
                }
                else
                {
                    ViewBag.Message = "Error: Invalide Data !";
                }
            }
            catch (Exception ex)
            {
                ViewBag.Message = "Error: Please contact System Administrator.";
            }
            return View(dto);
        }

    }
}
