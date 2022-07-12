using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FiboInfraStructure.BaseInfraStructure;
using FiboInfraStructure.Entity.FiboInventory;
using FiboInventory.InfraStructure.Assembler;
using FiboInventory.InfraStructure.Repository;
using FiboInventory.InfraStructure.Service;
using FiboInventory.Src.Dto;
using FiboInventory.Src.ViewModel;
using FiboOffice.InfraStructure.Repository;
using FiboOffice.Src.Dto;
using Microsoft.AspNetCore.Mvc;

namespace FiboCounterSystem.Areas.Inventories.Controllers
{
    public class IngredientController : Controller
    {

        private readonly IIngredientService _ingredientService;
        private readonly IIngredientRepository _repo;
        private readonly IIngredientAssembler _assembler;
        private readonly IMeasuringUnitRepository _measuringUnitRepository;
        private readonly IUserAndBranchInfo _userAndBranchInfo;
        public IngredientController(IIngredientService ingredientService, IIngredientRepository ingredientRepository , IIngredientAssembler assembler ,
            IMeasuringUnitRepository measuringUnitRepository , IUserAndBranchInfo userAndBranchInfo)
        {
            _ingredientService = ingredientService;
            _repo = ingredientRepository;
            _assembler = assembler;
            _measuringUnitRepository = measuringUnitRepository;
            _userAndBranchInfo = userAndBranchInfo;
        }
        public async Task<IActionResult> Index(IngredientViewModel vm)
        {
            vm.Ingredients = new List<Ingredient>();
            var ingredient = await _repo.GetAllIngredientAsync();
            vm.Ingredients = ingredient;
            return View(vm);
        }
        [HttpGet()]
        public async Task<IActionResult> Create()
        {
            IngredientDto dto = new IngredientDto
            {
                MeasuringUnits = await _measuringUnitRepository.GetAllMeasuringUnitAsync(),
                CreatedBy = await _userAndBranchInfo.getCurrentUser(),
                BranchId = await _userAndBranchInfo.getCurrentBranch(),
            };
            return View(dto);
        }

        [HttpPost()]
        [ValidateAntiForgeryToken()]
        public async Task<IActionResult> Create(IngredientDto dto)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    await _ingredientService.InsertAsync(dto);
                    return RedirectToAction(nameof(Index));
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Ingredient with {dto.Id} not found.");
            }
            return View(dto);
        }

        [HttpGet()]
        public async Task<IActionResult> Update(long? id)
        {
            if (!id.HasValue)
            {

            }
            var ingredient = await _repo.GetByIdAsync(id.Value) ?? throw new Exception();
            IngredientDto dto = new IngredientDto()
            {
                MeasuringUnits = await _measuringUnitRepository.GetAllMeasuringUnitAsync()
            };
            _assembler.copyFrom(dto, ingredient);
            return View(dto);
        }
        [HttpPost()]
        [ValidateAntiForgeryToken()]
        public async Task<IActionResult> Update(IngredientDto dto)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    await _ingredientService.UpdateAsync(dto);
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
            var ingredient = await _repo.GetByIdAsync(id) ?? throw new Exception();
            return View(ingredient);
        }

        [HttpPost()]
        [ValidateAntiForgeryToken()]
        public async Task<IActionResult> DeleteConfirmed(Ingredient ingredient)
        {
            try
            {
                if (ingredient != null)
                {
                    await _ingredientService.Delete(ingredient.Id).ConfigureAwait(true);
                    return RedirectToAction(nameof(Index));
                }
            }
            catch (Exception ex)
            {
                throw new Exception();
            }
            return View(ingredient);
        }
    }
}
