
using FiboBilling.InfraStructure.Assembler;
using FiboBilling.InfraStructure.Repository;
using FiboBilling.InfraStructure.Service;
using FiboBilling.Src.Dto;
using FiboBilling.Src.ViewModel;
using FiboInfraStructure;
using FiboInfraStructure.Entity.FiboBilling;
using FiboInfraStructure.Entity.Payroll;
using FiboOffice.InfraStructure.Repository;
using Microsoft.AspNetCore.Mvc;
using Payroll.InfraStructure.Assembler;
using Payroll.InfraStructure.Repository;
using Payroll.InfraStructure.Service;
using Payroll.Src.Dto;
using Payroll.Src.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FiboCounterSystem.Areas.Billings.Controllers
{
    public class ExpenseController : Controller
    {
        private readonly IExpenseAssembler _assembler;

        private readonly IExpenseRepository _repository;

        private readonly IExpenseService _service;

       
        private readonly IMonthRepository _monthRepo;
        private readonly IYearRepository _yearRepo;

        public ExpenseController(
            IExpenseAssembler assembler,
            IExpenseRepository repository,
            IExpenseService service,
            IMonthRepository monthRepositor,
            IYearRepository yearRepository
            )
        {
            _assembler = assembler;
            _repository = repository;
            _service = service;
            _monthRepo = monthRepositor;
            _yearRepo = yearRepository;
        }
        

        public async Task<IActionResult> OfficeExpView(ExpenseViewModel vm, string message)
        {

            vm.Expenses = new List<Expense>();
            var expense = await _repository.GetAllExpense();
            if(string.IsNullOrEmpty(vm.FromMiti) && string.IsNullOrEmpty(vm.ToMiti))
            {
                vm.FromDate = DateTime.Now.AddDays(-1);
                vm.ToDate = DateTime.Now;
                expense = expense.Where(x => x.Date > vm.FromDate && x.Date < vm.ToDate).ToList();
            }
            if (!string.IsNullOrEmpty(vm.FromMiti))
            {
                vm.FromDate = vm.FromMiti.ToEnglishDate();
                expense =expense.Where(x => x.Date >= vm.FromDate).ToList();
            }
            if (!string.IsNullOrEmpty(vm.ToMiti))
            {
                vm.ToDate = vm.ToMiti.ToEnglishDate();
                expense = expense.Where(x => x.Date <= vm.ToDate).ToList();
            }
            vm.Expenses = expense;
            ViewBag.Message = message;
            return View(vm);
        }

        [HttpGet()]
        public async Task<IActionResult> Create()
        {
            ExpenseDto dto = new ExpenseDto
            {
                Miti = DateTime.Now.ToDateTime().ToNepDate(),
            };
            return View(dto);
        }

     
        [HttpGet()]
        public async Task<IActionResult> OfficeExpenses()
        {
            ExpenseDto dto = new ExpenseDto
            {
                Miti = DateTime.Now.ToDateTime().ToNepDate(),
            };
            return View(dto);
        }

        [HttpPost()]
        [ValidateAntiForgeryToken()]
        public async Task<IActionResult> OfficeExpenses(ExpenseDto dto)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    dto.IsExpense = false;
                    await _service.InsertAsync(dto).ConfigureAwait(true);
                    return RedirectToAction("OfficeExpView", "Expense", new { message = "Expense been saved successfully." });
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
    }
}
