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
    public class MeasuringUnitController : Controller
    {
        private readonly IMeasuringUnitService _measuringUnitService;
        private readonly IMeasuringUnitRepository _measuringUnitRepository;
        private readonly IMeasuringUnitAssembler _measuringUnitAssembler;
        private readonly IUserAndBranchInfo _userAndBranchInfo;
        public MeasuringUnitController(IMeasuringUnitService measuringUnitService 
            , IMeasuringUnitRepository measuringUnitRepository 
            , IMeasuringUnitAssembler measuringUnitAssembler
            , IUserAndBranchInfo userAndBranchInfo)

        {
            _measuringUnitRepository = measuringUnitRepository;
            _measuringUnitAssembler = measuringUnitAssembler;
            _measuringUnitService = measuringUnitService;
            _userAndBranchInfo = userAndBranchInfo;
        }
        public async Task<IActionResult> Index(MeasuringUnitViewModel vm, string message)
        {
            vm.MeasuringUnits = new List<MeasuringUnit>();
            var MeasuringUnits = await _measuringUnitRepository.GetAllMeasuringUnitAsync();
            vm.MeasuringUnits = MeasuringUnits;
            ViewBag.Message = message;
            return View(vm);
        }
        [HttpGet()]
        public async Task<IActionResult> Create()
        {
            MeasuringUnitDto dto = new MeasuringUnitDto
            {
                CreatedBy = await _userAndBranchInfo.getCurrentUser(),
                BranchId = await _userAndBranchInfo.getCurrentBranch(),
            };
            return View(dto);
        }

        [HttpPost()]
        [ValidateAntiForgeryToken()]
        public async Task<IActionResult> Create(MeasuringUnitDto dto)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    await _measuringUnitService.Insertasync(dto);
                    return RedirectToAction("Index", "MeasuringUnit", new { message = "Measuring Unit has been saved successfully." });
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
            var measuringunit = await _measuringUnitRepository.GetByIdAsync(id.Value) ?? throw new Exception();
            MeasuringUnitDto dto = new MeasuringUnitDto();
            _measuringUnitAssembler.copyFrom(dto, measuringunit);
            return View(dto);
        }
        [HttpPost()]
        [ValidateAntiForgeryToken()]
        public async Task<IActionResult> Update(MeasuringUnitDto dto)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    await _measuringUnitService.UpdateAsync(dto);
                    return RedirectToAction("Index", "MeasuringUnit", new { message = "Measuring Unit has been saved successfully." });
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

        [HttpGet()]
        public async Task<IActionResult> Delete(long id)
        {
            var MU = await _measuringUnitRepository.GetByIdAsync(id) ?? throw new Exception();
            return View(MU);
        }

        [HttpPost()]
        [ValidateAntiForgeryToken()]
        public async Task<IActionResult> DeleteConfirmed(MeasuringUnit measuringUnit)
        {
            try
            {
                if (measuringUnit != null)
                {
                    await _measuringUnitService.Delete(measuringUnit.Id).ConfigureAwait(true);
                    return RedirectToAction(nameof(Index));
                }
            }
            catch (Exception ex)
            {
                throw new Exception();
            }
            return View(measuringUnit);
        }
    }
}
