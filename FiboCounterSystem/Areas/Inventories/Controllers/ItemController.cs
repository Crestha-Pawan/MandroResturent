using FiboInfraStructure.BaseInfraStructure;
using FiboInfraStructure.Entity.FiboInventory;
using FiboInventory.InfraStructure.Assembler;
using FiboInventory.InfraStructure.Repository;
using FiboInventory.InfraStructure.Service;
using FiboInventory.Src.Dto;
using FiboInventory.Src.ViewModel;
using FiboOffice.InfraStructure.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FiboCounterSystem.Areas.Inventories.Controllers
{
    public class ItemController : Controller
    {
        private readonly IItemService _itemService;
        private readonly IItemRepository _repo;
        private readonly IItemAssembler _assembler;
        private readonly IUserAndBranchInfo _userAndBranchInfo;
        private readonly IMeasuringUnitRepository _muRepo;
        public ItemController(IItemService itemService
            , IItemRepository repo
            , IItemAssembler assembler
            , IUserAndBranchInfo userAndBranchInfo
            , IMeasuringUnitRepository muRepo
            )
        {
            _repo = repo;
            _assembler = assembler;
            _itemService = itemService;
            _muRepo = muRepo;
            _userAndBranchInfo = userAndBranchInfo;
        }
        public async Task<IActionResult> Index(ItemViewModel vm, string message)
        {
            vm.Items = new List<Item>();
            var item = await _repo.GetAllItemAsync();
            vm.Items = item;
            ViewBag.Message = message;
            return View(vm);
        }
        [HttpGet()]
        public async Task<IActionResult> Create()
        {
            ItemDto dto = new ItemDto
            {
                CreatedBy = await _userAndBranchInfo.getCurrentUser(),
                BranchId = await _userAndBranchInfo.getCurrentBranch(),
                MeasuringUnits = await _muRepo.GetAllMeasuringUnitAsync(),
            };
            return View(dto);
        }

        [HttpPost()]
        [ValidateAntiForgeryToken()]
        public async Task<IActionResult> Create(ItemDto dto)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    await _itemService.Insertasync(dto);
                    return RedirectToAction("Index", "Item", new { message = "Item has been saved successfully." });
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
            var item = await _repo.GetByIdAsync(id.Value) ?? throw new Exception();
            ItemDto dto = new ItemDto()
            {
                MeasuringUnits = await _muRepo.GetAllMeasuringUnitAsync(),
            };
            _assembler.copyFrom(dto, item);
            return View(dto);
        }
        [HttpPost()]
        [ValidateAntiForgeryToken()]
        public async Task<IActionResult> Update(ItemDto dto)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    await _itemService.UpdateAsync(dto);
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
            var item = await _repo.GetByIdAsync(id) ?? throw new Exception();
            return View(item);
        }

        [HttpPost()]
        [ValidateAntiForgeryToken()]
        public async Task<IActionResult> DeleteConfirmed(Item item)
        {
            try
            {
                if (item != null)
                {
                    await _itemService.Delete(item.Id).ConfigureAwait(true);
                    return RedirectToAction(nameof(Index));
                }
            }
            catch (Exception ex)
            {
                throw new Exception();
            }
            return View(item);
        }
    }
}
