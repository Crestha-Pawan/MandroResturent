using FiboInfraStructure.BaseInfraStructure;
using FiboInfraStructure.Entity.FiboLodge;
using FiboLodge.InfraStructure.Assembler;
using FiboLodge.InfraStructure.Repository;
using FiboLodge.InfraStructure.Service;
using FiboLodge.Src.Dto;
using FiboLodge.Src.ViewModel;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FiboCounterSystem.Areas.Lodge
{
    public class RoomSetupController : Controller
    {
        private readonly IUserAndBranchInfo _userAndBranchInfo;
        private readonly IRoomSetupRepository _repo;
        private readonly IRoomSetupService _service;
        private readonly IRoomSetupAssembler _assembler;
        public RoomSetupController(IRoomSetupService service
            , IRoomSetupRepository repo
            , IRoomSetupAssembler assembler
            , IUserAndBranchInfo userAndBranchInfo
            )
        {
            _repo = repo;
            _service = service;
            _assembler = assembler;
            _userAndBranchInfo = userAndBranchInfo;
        }
        public async Task<IActionResult> Index(RoomSetupViewModel vm, string message)
        {
            vm.RoomSetupList = new List<RoomSetup>();
            var room = await _repo.GetAllRoomAsync();
            vm.RoomSetupList = room;
            ViewBag.Message = message;
            return View(vm);
        }

        [HttpGet()]
        public async Task<IActionResult> Create()
        {
            RoomSetupDto dto = new RoomSetupDto
            {
                //ExtendedDuration = 1,
                CreatedBy = await _userAndBranchInfo.getCurrentUser(),
                BranchId = await _userAndBranchInfo.getCurrentBranch(),
            };
            return View(dto);
        }
        [HttpPost()]
        [ValidateAntiForgeryToken()]
        public async Task<IActionResult> Create(RoomSetupDto dto)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    await _service.InsertAsync(dto);
                    return RedirectToAction("Index", "RoomSetup", new { message = "Room has been saved successfully." });
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
            var room = await _repo.GetByIdAsync(id.Value) ?? throw new Exception();
            RoomSetupDto dto = new RoomSetupDto();
            _assembler.copyFrom(dto, room);
            return View(dto);
        }
        [HttpPost()]
        [ValidateAntiForgeryToken()]
        public async Task<IActionResult> Update(RoomSetupDto dto)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    await _service.UpdateAsync(dto);
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
            var room = await _repo.GetByIdAsync(id) ?? throw new Exception();
            return View(room);
        }

        [HttpPost()]
        [ValidateAntiForgeryToken()]
        public async Task<IActionResult> DeleteConfirmed(RoomSetup room)
        {
            try
            {
                if (room != null)
                {
                    await _service.Delete(room.Id).ConfigureAwait(true);
                    return RedirectToAction(nameof(Index));
                }
            }
            catch (Exception ex)
            {
                throw new Exception();
            }
            return View(room);
        }
    }
}
