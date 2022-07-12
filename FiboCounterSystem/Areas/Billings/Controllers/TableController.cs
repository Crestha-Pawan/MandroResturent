using FiboBilling.InfraStructure.Assembler;
using FiboBilling.InfraStructure.Repository;
using FiboBilling.InfraStructure.Service;
using FiboBilling.Src.Dto;
using FiboBilling.Src.ViewModel;
using FiboInfraStructure.BaseInfraStructure;
using FiboInfraStructure.Entity.FiboBilling;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FiboCounterSystem.Areas.Billings.Controllers
{
    public class TableController : Controller
    {
        private readonly ITableService _tableService;
        private readonly ITableRepository _tableRepository;
        private readonly ITableAssembler _tableAssembler;
        private readonly IUserAndBranchInfo _userAndBranchInfo;
        public TableController(ITableService tableService, ITableRepository tableRepository,
            ITableAssembler tableAssembler, IUserAndBranchInfo userAndBranchInfo)
        {
            _tableService = tableService;
            _tableRepository = tableRepository;
            _tableAssembler = tableAssembler;
            _userAndBranchInfo = userAndBranchInfo;
        }
        public async Task<IActionResult> Index(TableViewModel vm, string message)
        {
            vm.Tables = new List<Table>();
            var table = await _tableRepository.GetAllTableAsync();
            vm.Tables = table;
            ViewBag.Message = message;
            return View(vm);
        }
        [HttpGet()]
        public async Task<IActionResult> Create(TableType type)
        {
            TableDto dto = new TableDto
            {
                ReferenceType = (int)type,
                CreatedBy = await _userAndBranchInfo.getCurrentUser(),
                BranchId = await _userAndBranchInfo.getCurrentBranch()
            };
            return View(dto);
        }

        [HttpPost()]
        [ValidateAntiForgeryToken()]
        public async Task<IActionResult> Create(TableDto dto)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    await _tableService.Insertasync(dto);
                    if (((int)TableType.TypeBilling) == dto.ReferenceType)
                    {
                        return RedirectToAction("Index", "Billing",new { message="Table has been saved successfully."});
                    }
                    else
                    {
                        ViewBag.Message = "Error: Invalid data !";
                    }
                    return RedirectToAction("Index", "Table", new { message = "Table has been saved successfully." });
                }
            }
            catch (Exception ex)
            {
                ViewBag.Message = "Error: Please contact System Administrator.";
            }
            return View(dto);
        }

        [HttpGet()]
        public async Task<IActionResult> Update(long? id)
        {
            if (!id.HasValue)
            {

            }
            var entity = await _tableRepository.GetByIdAsync(id.Value) ?? throw new Exception();
            TableDto dto = new TableDto();
            _tableAssembler.copyFrom(dto, entity);
            return View(dto);
        }
        [HttpPost()]
        [ValidateAntiForgeryToken()]
        public async Task<IActionResult> Update(TableDto dto)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    await _tableService.UpdateAsync(dto);
                    return RedirectToAction("Index", "Table", new { message = "Table has been saved successfully." });
                }
                else
                {
                    ViewBag.Message = "Error: Invalid data !";
                }
            }
            catch (Exception ex)
            {
                ViewBag.Message = "Error: Please contact System Administrator.";
            }
            return View();
        }

        [HttpGet()]
        public async Task<IActionResult> Delete(long id)
        {
            var table = await _tableRepository.GetByIdAsync(id) ?? throw new Exception();
            return View(table);
        }

        [HttpPost()]
        [ValidateAntiForgeryToken()]
        public async Task<IActionResult> DeleteConfirmed(Table table)
        {
            try
            {
                if (table != null)
                {
                    await _tableService.Delete(table.Id).ConfigureAwait(true);
                    return RedirectToAction(nameof(Index));
                }
            }
            catch (Exception ex)
            {

            }
            return View(table);
        }
    }
}
