using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FiboInfraStructure;
using FiboInfraStructure.Entity.Payroll;
using Microsoft.AspNetCore.Mvc;
using Payroll.InfraStructure.Assembler;
using Payroll.InfraStructure.Repository;
using Payroll.InfraStructure.Service;
using Payroll.Src.Dto;
using Payroll.Src.ViewModel;

namespace FiboCounterSystem.Areas.Payroll.Controllers
{
    public class OpeningClosingController : Controller
    {
        private readonly IOpeningClosingService _openingClosingService;
        private readonly IOpeningClosingRepository _openingClosingRepository;
        private readonly IOpeningClosingAssembler _openingClosingAssembler;
        public OpeningClosingController(IOpeningClosingService openingClosingService
            , IOpeningClosingRepository OpeningClosingRepository
            , IOpeningClosingAssembler OpeningClosingAssembler)
        {
            _openingClosingService = openingClosingService;
            _openingClosingRepository = OpeningClosingRepository;
            _openingClosingAssembler = OpeningClosingAssembler;
        }
        public async Task<IActionResult> Index(OpeningClosingViewModel vm)
        {
            vm.OpenignClosing = new List<OpeningClosing>();
            var opensclose = await _openingClosingRepository.GetAllOpeningClosingAsync();
            if (!string.IsNullOrEmpty(vm.FromMiti))
            {
                vm.FromDate = vm.FromMiti.ToEnglishDate();
                opensclose = opensclose.Where(x => x.Date.ToEnglishDate() >= vm.FromDate).ToList();
            }
            if (!string.IsNullOrEmpty(vm.ToMiti))
            {
                vm.ToDate = vm.ToMiti.ToEnglishDate();
                opensclose = opensclose.Where(x => x.Date.ToEnglishDate() <= vm.ToDate).ToList();
            }
            vm.OpenignClosing = opensclose.OrderByDescending(x => x.Date).ToList(); 
            return View(vm);
        }
        [HttpGet()]
        public async Task<IActionResult> Create()
        {
            OpeningClosingDto openclose = new OpeningClosingDto
            {
                //Date = DateTime.Now.ToDateTime().ToNepDate(),
            };
            return View(openclose);
        }

        [HttpPost()]
        [ValidateAntiForgeryToken()]
        public async Task<IActionResult> Create(OpeningClosingDto dto)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    await _openingClosingService.Insertasync(dto);
                    return RedirectToAction("Index", "OpeningClosing", new { message = "It has been saved successfully." });
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

        [HttpGet()]
        public async Task<IActionResult> Update(long? id)
        {
            if (!id.HasValue)
            {

            }
            var openclsose = await _openingClosingRepository.GetByIdAsync(id.Value) ?? throw new Exception();
            OpeningClosingDto dto = new OpeningClosingDto();
            _openingClosingAssembler.copyFrom(dto, openclsose);
            return View(dto);
        }
        [HttpPost()]
        [ValidateAntiForgeryToken()]
        public async Task<IActionResult> Update(OpeningClosingDto dto)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    await _openingClosingService.UpdateAsync(dto);
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
            var openclsoe = await _openingClosingRepository.GetByIdAsync(id) ?? throw new Exception();
            return View(openclsoe);
        }

        [HttpPost()]
        [ValidateAntiForgeryToken()]
        public async Task<IActionResult> DeleteConfirmed(OpeningClosing openingClosing)
        {
            try
            {
                if (openingClosing != null)
                {
                    await _openingClosingService.Delete(openingClosing.Id).ConfigureAwait(true);
                    return RedirectToAction(nameof(Index));
                }
            }
            catch (Exception ex)
            {

            }
            return View(openingClosing);
        }
      
    }
}