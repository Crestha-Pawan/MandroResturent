using FiboInfraStructure;
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
using FiboInfraStructure;
using FiboInfraStructure.Entity.FiboOffice;

namespace FiboCounterSystem.Areas.Payroll.Controllers
{
    public class SalarySheetController : Controller
    {
        private readonly ISalarySheetService _salarySheetService;
        private readonly ISalarySheetRepository _salarySheetRepository;
        private readonly ISalarySheetAssembler _salarySheetAssembler;
        private readonly IEmployeeRepository _employeeRepository;
        private readonly IPostRepository _postRepository;
        public SalarySheetController(ISalarySheetService salarySheetService
            , ISalarySheetRepository salarySheetRepository
            , ISalarySheetAssembler salarySheetAssembler
            , IEmployeeRepository employeeRepository
            , IPostRepository postRepository)
        {
            _salarySheetRepository = salarySheetRepository;
            _salarySheetService = salarySheetService;
            _salarySheetAssembler = salarySheetAssembler;
            _employeeRepository = employeeRepository;
            _postRepository = postRepository;
        }
        public async Task<IActionResult> Index(SalarySheetViewModel vm)
        {
            vm.SalarySheets = new List<SalarySheet>();
            var salarySheets = await _salarySheetRepository.GetAllSalarySheetAsync();
            vm.SalarySheets = salarySheets;
            return View(vm);
        }
        public async Task<IActionResult> SalarySheetReport(SalarySheetViewModel vm)
        {
            var salarysheet = await _salarySheetRepository.GetAllSalarySheetAsync();
            var employee = await _employeeRepository.GetAllEmployeeAsync();
            vm.Employeee = await _employeeRepository.GetAllEmployeeAsync();

            if (vm.EmployeeId > 0)
            {
                vm.Employeee = employee.Where(x => x.Id == vm.EmployeeId).ToList();
            }
            vm.Employees = vm.Employeee;
            vm.SalarySheets = salarysheet;
            return View(vm);
        }
        public async Task<IActionResult> Report(SalarySheetViewModel vm, long empId)
        {
            var salarySheets = await _salarySheetRepository.GetAllSalarySheetAsync();

            if (empId > 0)
            {
                vm.EmployeeId = empId;
            }
            if (vm.EmployeeId > 0)
            {
                salarySheets = salarySheets.Where(x => x.EmployeeId == vm.EmployeeId).ToList();
            }
            vm.SalarySheets = salarySheets;
            if (!string.IsNullOrEmpty(vm.FromMiti))
            {
                vm.FromDate = vm.FromMiti.ToEnglishDate();
                vm.SalarySheets = vm.SalarySheets.Where(x => x.AdvanceSalaryDate.ToEnglishDate() >= vm.FromDate).ToList();
            }
            if (!string.IsNullOrEmpty(vm.ToMiti))
            {
                vm.ToDate = vm.ToMiti.ToEnglishDate();
                vm.SalarySheets = vm.SalarySheets.Where(x => x.AdvanceSalaryDate.ToEnglishDate() <= vm.ToDate).ToList();
            }
            if (string.IsNullOrEmpty(vm.FromMiti) && string.IsNullOrEmpty(vm.ToMiti))
            {

                vm.SalarySheets = vm.SalarySheets.Where(x => x.AdvanceSalaryDate.ToEnglishDate() >= DateTime.Now.Date).ToList();
            }
            return View(vm);
        }

        [HttpGet()]
        public async Task<IActionResult> Create()
        {
            var salarySheets = await _salarySheetRepository.GetAllSalarySheetAsync();
            SalarySheetDto dto = new SalarySheetDto
            {
                Employees = await _employeeRepository.GetAllEmployeeAsync(),

                Posts = await _postRepository.GetAllPostAsync()

            };
            return View(dto);
        }

        [HttpPost()]
        [ValidateAntiForgeryToken()]
        public async Task<IActionResult> Create(SalarySheetDto dto)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    await _salarySheetService.Insertasync(dto);
                    return RedirectToAction("SalaryIndex","Employee");
                }
            }
            catch (Exception ex)
            {
                throw new Exception();
            }
            return View(dto);
        }

        [HttpGet()]
        public async Task<IActionResult> Update(long? id)
        {
            if (!id.HasValue)
            {
                throw new Exception();
            }
            var salarySheet = await _salarySheetRepository.GetByIdAsync(id.Value) ?? throw new Exception();
            SalarySheetDto dto = new SalarySheetDto()
            {
                Employees = await _employeeRepository.GetAllEmployeeAsync(),
                Posts = await _postRepository.GetAllPostAsync()
            };
            _salarySheetAssembler.copyFrom(dto, salarySheet);
            return View(dto);
        }
        [HttpPost()]
        [ValidateAntiForgeryToken()]
        public async Task<IActionResult> Update(SalarySheetDto dto)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    await _salarySheetService.UpdateAsync(dto);
                    return RedirectToAction(nameof(Index));
                }
            }
            catch (Exception ex)
            {
                throw new Exception();
            }
            return View();
        }
        [HttpGet()]
        public async Task<IActionResult> Delete(long id)
        {
            var salarySheet = await _salarySheetRepository.GetByIdAsync(id) ?? throw new Exception();
            return View(salarySheet);
        }

        [HttpPost()]
        [ValidateAntiForgeryToken()]
        public async Task<IActionResult> DeleteConfirmed(SalarySheet salarySheet)
        {
            try
            {
                if (salarySheet != null)
                {
                    await _salarySheetService.Delete(salarySheet.Id).ConfigureAwait(true);
                    return RedirectToAction(nameof(Index));
                }
            }
            catch (Exception ex)
            {

            }
            return View(salarySheet);
        }

       
    }


}
