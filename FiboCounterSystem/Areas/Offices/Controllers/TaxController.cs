using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FiboInfraStructure.BaseInfraStructure;
using FiboInfraStructure.Entity.FiboOffice;
using FiboOffice.InfraStructure.Assembler;
using FiboOffice.InfraStructure.Repository;
using FiboOffice.InfraStructure.Service;
using FiboOffice.Src.Dto;
using FiboOffice.Src.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace FiboCounterSystem.Areas.Offices.Controllers
{
    public class TaxController : Controller
    {
        private readonly ITaxService _taxService;
        private readonly ITaxRepository _taxRepository;
        private readonly ITaxAssembler _taxAssembler;
        private readonly IUserAndBranchInfo _userAndBranchInfo;
        public TaxController(ITaxService taxService
            , ITaxRepository taxRepository
            , ITaxAssembler taxAssembler
            , IUserAndBranchInfo userAndBranchInfo)

        {
            _taxRepository = taxRepository;
            _taxAssembler = taxAssembler;
            _taxService = taxService;
            _userAndBranchInfo = userAndBranchInfo;
        }
        public async Task<IActionResult> Index(TaxViewModel vm, string message)
        {
            vm.Taxs = new List<Tax>();
            var taxs = await _taxRepository.GetAllTaxAsync();
            vm.Taxs = taxs;
            ViewBag.Message = message;
            return View(vm);
        }
        [HttpGet()]
        public async Task<IActionResult> Create()
        {
            TaxDto dto = new TaxDto
            {
                CreatedBy = await _userAndBranchInfo.getCurrentUser(),
                BranchId = await _userAndBranchInfo.getCurrentBranch(),
            };
            return View(dto);
        }

        [HttpPost()]
        [ValidateAntiForgeryToken()]
        public async Task<IActionResult> Create(TaxDto dto)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    await _taxService.InsertAsync(dto);
                    return RedirectToAction("Index", "Tax", new { message = "Tax has been saved successfully." });
                }
                else
                {
                    ViewBag.Message = "Error: Invalid data !";
                }
            }
            catch (Exception ex)
            {
                ViewBag.Message = "Error: Please Contact Administrator.";
            }
            return View(dto);
        }

        [HttpGet()]
        public async Task<IActionResult> Update(long? id)
        {
            if (!id.HasValue)
            {

            }
            var tax = await _taxRepository.GetByIdAsync(id.Value) ?? throw new Exception();
            TaxDto dto = new TaxDto();
            _taxAssembler.copyFrom(dto, tax);
            return View(dto);
        }
        [HttpPost()]
        [ValidateAntiForgeryToken()]
        public async Task<IActionResult> Update(TaxDto dto)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    await _taxService.UpdateAsync(dto);
                    return RedirectToAction("Index", "Tax", new { message = "Tax has been saved successfully." });
                }
                else
                {
                    ViewBag.Message = "Error: Invalid data !";
                }
            }
            catch (Exception ex)
            {
                ViewBag.Message = "Error: Please Contact Administrator.";
            }
            return View();
        }
        public async Task<IActionResult> ToggleStatus(long id)
        {
            var tax = await _taxRepository.GetByIdAsync(id) ?? throw new Exception();
            return View(tax);
        }

        [HttpPost()]
        public async Task<IActionResult> ToggleStatus(Tax tax)
        {
            try
            {
                if (tax != null)
                {
                    tax = await _taxRepository.GetByIdAsync(tax.Id) ?? throw new Exception();
                    await _taxService.ToggleStatus(tax).ConfigureAwait(true);
                    return RedirectToAction(nameof(Index));
                }
            }
            catch (Exception ex)
            {
                throw new Exception();
            }
            return View(tax);
        }
        [HttpGet()]
        public async Task<IActionResult> Delete(long id)
        {
            var tax = await _taxRepository.GetByIdAsync(id) ?? throw new Exception();
            return View(tax);
        }

        [HttpPost()]
        [ValidateAntiForgeryToken()]
        public async Task<IActionResult> DeleteConfirmed(Tax tax)
        {
            try
            {
                if (tax != null)
                {
                    await _taxService.Delete(tax.Id).ConfigureAwait(true);
                    return RedirectToAction(nameof(Index));
                }
            }
            catch (Exception ex)
            {
                throw new Exception();
            }
            return View(tax);
        }
    }
}
