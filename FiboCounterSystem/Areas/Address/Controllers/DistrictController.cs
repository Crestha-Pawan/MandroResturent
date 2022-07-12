﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FiboAddress.InfraStructure.Assembler;
using FiboAddress.InfraStructure.Repository;
using FiboAddress.InfraStructure.Service;
using FiboAddress.Src.Dto;
using FiboAddress.Src.ViewModel;
using FiboInfraStructure.BaseInfraStructure;
using FiboInfraStructure.Entity.FiboAddress;
using Microsoft.AspNetCore.Mvc;

namespace FiboCounterSystem.Areas.Address.Controllers
{
    public class DistrictController : Controller
    {
        private readonly IDistrictService _districtService;
        private readonly IDistrictRepository _districtRepository;
        private readonly IDistrictAssembler _districtAssembler;
        private readonly IProvienceRepository _provienceRepository;
        private readonly IUserAndBranchInfo _userAndBranchInfo;
        public DistrictController(IDistrictService districtService, IDistrictRepository districtRepository , IDistrictAssembler districtAssembler , IProvienceRepository provienceRepository,
             IUserAndBranchInfo userAndBranchInfo)
        {
            _districtService = districtService;
            _districtRepository = districtRepository;
            _districtAssembler = districtAssembler;
            _provienceRepository = provienceRepository;
            _userAndBranchInfo = userAndBranchInfo;
        }
        public async Task<IActionResult> Index(DistrictViewModel vm, string message)
        {
            vm.Districts = new List<District>();
            var district = await _districtRepository.GetAllDistrictAsync();
            vm.Districts = district;
            ViewBag.Message = message;
            return View(vm);
        }

        [HttpGet()]
        public async Task<IActionResult> Create()
        {
            DistrictDto districtDto = new DistrictDto
            {
                Proviences = await _provienceRepository.GetAllProvienceAsync(),
                 CreatedBy = await _userAndBranchInfo.getCurrentUser(),
                BranchId = await _userAndBranchInfo.getCurrentBranch(),
            };
            return View(districtDto);
        }

        [HttpPost()]
        [ValidateAntiForgeryToken()]
        public async Task<IActionResult> Create(DistrictDto dto)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    await _districtService.Insertasync(dto);
                    return RedirectToAction("Index", "District", new { message = "District has been saved successfully." });
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
            var entity = await _districtRepository.GetByIdAsync(id.Value) ?? throw new Exception();
            DistrictDto dto = new DistrictDto
            {
                Proviences = await _provienceRepository.GetAllProvienceAsync()
            };
            _districtAssembler.copyFrom(dto, entity);
            return View(dto);
        }
        [HttpPost()]
        [ValidateAntiForgeryToken()]
        public async Task<IActionResult> Update(DistrictDto dto)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    await _districtService.UpdateAsync(dto);
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
            var district = await _districtRepository.GetByIdAsync(id) ?? throw new Exception();
            return View(district);
        }

        [HttpPost()]
        [ValidateAntiForgeryToken()]
        public async Task<IActionResult> DeleteConfirmed(District district)
        {
            try
            {
                if (district != null)
                {
                    await _districtService.Delete(district.Id).ConfigureAwait(true);
                    return RedirectToAction(nameof(Index));
                }
            }
            catch (Exception ex)
            {

            }
            return View(district);
        }
    }
}
