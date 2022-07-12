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
   
    public class ServiceChargeController : Controller
    {
        private readonly IServiceChargeService _scService;
        private readonly IServiceChargeRepository _scRepository;
        private readonly IServiceChargeAssembler _scAssembler;
        private readonly IUserAndBranchInfo _userAndBranchInfo;
        public ServiceChargeController(IServiceChargeService scService
            , IServiceChargeRepository scRepository
            , IServiceChargeAssembler scAssembler
            , IUserAndBranchInfo userAndBranchInfo)

        {
            _scRepository = scRepository;
            _scAssembler = scAssembler;
            _scService = scService;
            _userAndBranchInfo = userAndBranchInfo;
        }
        public async Task<IActionResult> Index(ServiceChargeViewModel vm, string message)
        {
            vm.ServiceCharges = new List<ServiceCharge>();
            var sc = await _scRepository.GetAllServiceChargeAsync();
            vm.ServiceCharges = sc;
            ViewBag.Message = message;
            return View(vm);
        }
        [HttpGet()]
        public async Task<IActionResult> Create()
        {
            ServiceChargeDto dto = new ServiceChargeDto
            {
                CreatedBy = await _userAndBranchInfo.getCurrentUser(),
                BranchId = await _userAndBranchInfo.getCurrentBranch(),
            };
            return View(dto);
        }

        [HttpPost()]
        [ValidateAntiForgeryToken()]
        public async Task<IActionResult> Create(ServiceChargeDto dto)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    await _scService.InsertAsync(dto);
                    return RedirectToAction("Index", "ServiceCharge", new { message = "Service Charge has been saved successfully." });
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
            var sc = await _scRepository.GetByIdAsync(id.Value) ?? throw new Exception();
            ServiceChargeDto dto = new ServiceChargeDto();
            _scAssembler.copyFrom(dto, sc);
            return View(dto);
        }
        [HttpPost()]
        [ValidateAntiForgeryToken()]
        public async Task<IActionResult> Update(ServiceChargeDto dto)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    await _scService.UpdateAsync(dto);
                    return RedirectToAction("Index", "ServiceCharge", new { message = "Service Charge has been saved successfully." });
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
            var sc = await _scRepository.GetByIdAsync(id) ?? throw new Exception();
            return View(sc);
        }

        [HttpPost()]
        public async Task<IActionResult> ToggleStatus(ServiceCharge sc)
        {
            try
            {
                if (sc != null)
                {
                    sc = await _scRepository.GetByIdAsync(sc.Id) ?? throw new Exception();
                    await _scService.ToggleStatus(sc).ConfigureAwait(true);
                    return RedirectToAction(nameof(Index));
                }
            }
            catch (Exception ex)
            {
                throw new Exception();
            }
            return View(sc);
        }
        [HttpGet()]
        public async Task<IActionResult> Delete(long id)
        {
            var sc = await _scRepository.GetByIdAsync(id) ?? throw new Exception();
            return View(sc);
        }

        [HttpPost()]
        [ValidateAntiForgeryToken()]
        public async Task<IActionResult> DeleteConfirmed(ServiceCharge sc)
        {
            try
            {
                if (sc != null)
                {
                    await _scService.Delete(sc.Id).ConfigureAwait(true);
                    return RedirectToAction(nameof(Index));
                }
            }
            catch (Exception ex)
            {
                throw new Exception();
            }
            return View(sc);
        }
    }
}
