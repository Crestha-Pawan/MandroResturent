using FiboBilling.InfraStructure.Service;
using FiboBilling.Src.Dto;
using FiboInfraStructure.BaseInfraStructure;
using FiboInfraStructure.Data;
using FiboInfraStructure.Entity.FiboLodge;
using FiboLodge.InfraStructure.Assembler;
using FiboLodge.InfraStructure.Repository;
using FiboLodge.InfraStructure.Service;
using FiboLodge.Src.Dto;
using FiboLodge.Src.ViewModel;
using FiboOffice.InfraStructure.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FiboInfraStructure;
using FiboBilling.Src.ViewModel;
using FiboBilling.InfraStructure.Repository;

namespace FiboCounterSystem.Areas.Lodge
{
    public class RoomCheckInController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IUserAndBranchInfo _userAndBranchInfo;
        private readonly IRoomSetupRepository _roomSetuRrepo;
        private readonly IRoomCheckInService _service;
        private readonly IRoomCheckInAssembler _assembler;
        private readonly IRoomCheckInRepository _repo;
        private readonly IRoomSetupService _roomSetupService;
        private readonly IRoomSetupAssembler _roomSetupAssembler;
        private readonly ITaxRepository _taxRepo;
        private readonly IServiceChargeRepository _serviceChargeRepo;
        private readonly IBillingService _billingService;
        private readonly ILodgeBillingService _lodgeService;
        private readonly ILodgeBillingRepository _lodgeRepo;
        public RoomCheckInController(IRoomCheckInService service
            , IRoomSetupRepository roomSetuRrepo
            , IRoomCheckInAssembler assembler
            , IRoomCheckInRepository repo
            , IRoomSetupAssembler roomSetupAssembler
            , IRoomSetupService roomSetupService
            , IUserAndBranchInfo userAndBranchInfo
            , ApplicationDbContext context
            , ITaxRepository taxRepo
            , IServiceChargeRepository serviceChargeRepo
            , IBillingService billingService
            , ILodgeBillingService lodgeService
            , ILodgeBillingRepository lodgeRepo
            )
        {
            _roomSetuRrepo = roomSetuRrepo;
            _service = service;
            _assembler = assembler;
            _repo = repo;
            _roomSetupAssembler = roomSetupAssembler;
            _roomSetupService = roomSetupService;
            _userAndBranchInfo = userAndBranchInfo;
            _context = context;
            _taxRepo = taxRepo;
            _serviceChargeRepo = serviceChargeRepo;
            _billingService = billingService;
            _lodgeService = lodgeService;
            _lodgeRepo = lodgeRepo;
        }
        public async Task<IActionResult> Index(RoomCheckInViewModel vm, string message)
        {
            vm.RoomCheckInList = new List<RoomCheckIn>();
            var room = await _repo.GetAllRoomCheckInAsync();
            var roomsetup = await _roomSetuRrepo.GetAllRoomAsync();
            if (vm.RoomSetupId != null)
            {
                if (vm.RoomSetupId.Contains(","))
                {
                    string[] roomsetupId = vm.RoomSetupId.Split(",");
                    for (int i = 0; i < roomsetupId.Length; i++)
                    {
                        room = room.Where(x => x.RoomSetupId == roomsetupId[i].ToString()).ToList();
                    }
                }
                else
                {
                    room = room.Where(x => x.RoomSetupId == vm.RoomSetupId).ToList();
                }
            }
            vm.RoomSetups = roomsetup;
            vm.RoomCheckInList = room;
            ViewBag.Message = message;
            return View(vm);
        }
        public async Task<IActionResult> RoomSetupList(RoomCheckInViewModel vm, string message)
        {
            vm.RoomSetupList = new List<RoomSetup>();
            var room = await _roomSetuRrepo.GetAllRoomAsync();
            vm.RoomSetupList = room;
            ViewBag.Message = message;
            return View(vm);
        }
        [HttpGet()]
        public async Task<IActionResult> Create()
        {
            RoomCheckInDto dto = new RoomCheckInDto
            {
                CreatedBy = await _userAndBranchInfo.getCurrentUser(),
                BranchId = await _userAndBranchInfo.getCurrentBranch(),
                RoomSetups = await _roomSetuRrepo.GetAllRoomAsync(),
            };
            return View(dto);
        }
        [HttpPost()]
        [ValidateAntiForgeryToken()]
        public async Task<IActionResult> Create(RoomCheckInDto dto)
        {
            using (IDbContextTransaction tran = _context.Database.BeginTransaction())
            {
                try
                {
                    if (ModelState.IsValid)
                    {
                        if (dto.RoomList != null)
                        {
                            dto.RoomSetupId = string.Join(",", dto.RoomList);
                        }
                        await _service.InsertAsync(dto).ConfigureAwait(true);

                        #region Update Room Setup
                        await _roomSetupService.UpdateFromCheckInAsync(dto, FiboInfraStructure.Enums.Status.Engaged.ToString());
                        #endregion
                        await tran.CommitAsync();
                        return RedirectToAction("Index", "RoomCheckIn", new { message = "Room Check In has been saved successfully." });
                    }
                    else
                    {
                        ViewBag.Message = "Error: Invalid data !";
                    }
                }
                catch (Exception ex)
                {
                    await tran.RollbackAsync();
                    ViewBag.Message = "Error: Please contact Administrator.";
                }
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
            RoomCheckInDto dto = new RoomCheckInDto()
            {
                RoomSetups = await _roomSetuRrepo.GetAllRoomAsync(),
            };
            _assembler.copyFrom(dto, room);
            return View(dto);
        }
        [HttpPost()]
        [ValidateAntiForgeryToken()]
        public async Task<IActionResult> Update(RoomCheckInDto dto)
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
        public async Task<IActionResult> RoomCheckOut(RoomCheckInViewModel vm, string message)

        {
            vm.RoomCheckInList = new List<RoomCheckIn>();
            var room = await _repo.GetAllRoomCheckInAsync();
            var roomsetup = await _roomSetuRrepo.GetAllRoomAsync();
            if (vm.RoomSetupId != null)
            {
                if (vm.RoomSetupId.Contains(","))
                {
                    string[] roomsetupId = vm.RoomSetupId.Split(",");
                    for (int i = 0; i < roomsetupId.Length; i++)
                    {
                        room = room.Where(x => x.RoomSetupId == roomsetupId[i].ToString()).ToList();
                    }
                }
                else
                {
                    room = room.Where(x => x.RoomSetupId == vm.RoomSetupId).ToList();
                }
            }
            vm.RoomSetups = roomsetup;
            vm.RoomCheckInList = room;

            ViewBag.Message = message;
            return View(vm);
        }

        [HttpGet()]
        public async Task<IActionResult> ToggleStatus(long id)
        {
            var room = await _repo.GetByIdAsync(id) ?? throw new Exception();
            return View(room);
        }

        [HttpPost()]
        public async Task<IActionResult> ToggleStatus(RoomCheckIn room)
        {
            try
            {
                if (room != null)
                {
                    room = await _repo.GetByIdAsync(room.Id) ?? throw new Exception();
                    await _service.ToggleStatus(room).ConfigureAwait(true);

                    #region Update Room Setup
                    if (room.RoomSetupId.Contains(","))
                    {
                        string[] roomsetupId = room.RoomSetupId.Split(",");
                        for (int i = 0; i < roomsetupId.Length; i++)
                        {
                            var roomSetup = await _roomSetuRrepo.GetByIdAsync(long.Parse(roomsetupId[i])) ?? throw new Exception();
                            roomSetup.Status = FiboInfraStructure.Enums.Status.VacantDirty.ToString();
                            await _roomSetuRrepo.UpdateAsync(roomSetup);
                        }
                    }
                    else
                    {
                        var roomSetup = await _roomSetuRrepo.GetByIdAsync(long.Parse(room.RoomSetupId)) ?? throw new Exception();
                        roomSetup.Status = FiboInfraStructure.Enums.Status.VacantDirty.ToString();
                        await _roomSetuRrepo.UpdateAsync(roomSetup);
                    }
                    #endregion


                    return RedirectToAction(nameof(Index));
                }
            }
            catch (Exception ex)
            {
                throw new Exception();
            }
            return View(room);
        }

        [HttpGet()]
        public async Task<IActionResult> CheckOut(long id)
        {
            var room = await _repo.GetByIdAsync(id) ?? throw new Exception();

            return View(room);
        }
        [HttpPost()]
        public async Task<IActionResult> CheckOut(RoomCheckIn room)
        {
            try
            {
                if (room != null)
                {
                    var taxes = await _taxRepo.GetAllTaxAsync() ?? throw new Exception();
                    var tax = taxes.Where(x => x.IsActive()).FirstOrDefault();

                    var scs = await _serviceChargeRepo.GetAllServiceChargeAsync() ?? throw new Exception();
                    var sc = scs.Where(x => x.IsActive()).FirstOrDefault();

                    room = await _repo.GetByIdAsync(room.Id) ?? throw new Exception();
                    await _service.ToggleStatus(room).ConfigureAwait(true);
                    #region Update Room Setup
                    if (room.RoomSetupId.Contains(","))
                    {
                        decimal amount = 0;
                        decimal extendedCharge = 0;
                        var days = 0;
                        string[] roomsetupId = room.RoomSetupId.Split(",");
                        for (int i = 0; i < roomsetupId.Length; i++)
                        {
                            var roomSetup = await _roomSetuRrepo.GetByIdAsync(long.Parse(roomsetupId[i])) ?? throw new Exception();
                            roomSetup.Status = FiboInfraStructure.Enums.Status.VacantDirty.ToString();
                            await _roomSetuRrepo.UpdateAsync(roomSetup);
                            days = (DateTime.Now - room.CreatedDate).Days;
                            var duration = (DateTime.Now.Hour - room.CreatedDate.Hour) % 24;

                            amount += days * roomSetup.Charges;
                            extendedCharge += duration * roomSetup.ExtendedRate;
                        }
                        #region Billing
                        var _roomSetup = await _roomSetuRrepo.GetByIdAsync(long.Parse(roomsetupId[0]));

                        LodgeBillingDto dto = new LodgeBillingDto();
                        dto.RoomSetupId = room.RoomSetupId;
                        dto.GuestName = room.CustomerName;
                        dto.Days = days.ToString();
                        dto.Total = amount + extendedCharge;
                        dto.Advance = room.Advance;
                        if (tax != null)
                        {
                            dto.TaxAmount = tax.TaxPercent * dto.Total / 100;
                        }
                        if (sc != null)
                        {
                            dto.ServiceCharge = sc.ServicePercent * dto.Total / 100;
                        }

                        dto.NetAmtPayable = dto.Total + dto.TaxAmount + dto.ServiceCharge;
                        dto.BillingNumber = _roomSetup.RoomName + "-" + DateTime.Now.ToShortDateString();

                        await _lodgeService.InsertAsync(dto);
                        return RedirectToAction(nameof(PrintCheckOut), new { id = dto.Id });
                        #endregion
                    }
                    else
                    {
                        var roomSetup = await _roomSetuRrepo.GetByIdAsync(long.Parse(room.RoomSetupId)) ?? throw new Exception();
                        roomSetup.Status = FiboInfraStructure.Enums.Status.VacantDirty.ToString();
                        await _roomSetuRrepo.UpdateAsync(roomSetup);

                        #region Billing
                        var days = (DateTime.Now - room.CreatedDate).Days;
                        var duration = (DateTime.Now.Hour - room.CreatedDate.Hour) % 24;

                        decimal amount = days * roomSetup.Charges;
                        decimal extendedCharge = duration * roomSetup.ExtendedRate;

                        LodgeBillingDto dto = new LodgeBillingDto();
                        dto.RoomSetupId = room.RoomSetupId;
                        dto.Days = days.ToString();
                        dto.GuestName = room.CustomerName;
                        dto.Total = amount + extendedCharge;
                        dto.Advance = room.Advance;
                        if (tax != null)
                        {
                            dto.TaxAmount = tax.TaxPercent * dto.Total / 100;
                        }
                        if (sc != null)
                        {
                            dto.ServiceCharge = sc.ServicePercent * dto.Total / 100;
                        }

                        dto.NetAmtPayable = dto.Total + dto.TaxAmount + dto.ServiceCharge;
                        dto.BillingNumber = roomSetup.RoomName + "-" + DateTime.Now.ToShortDateString();

                        await _lodgeService.InsertAsync(dto);
                        #endregion

                        return RedirectToAction(nameof(PrintCheckOut), new { id = dto.Id });
                    }

                    #endregion
                    return RedirectToAction(nameof(Index));
                }
            }
            catch (Exception ex)
            {
                throw new Exception();
            }
            return View(room);
        }

        public async Task<IActionResult> ReservedStatus(long id)
        {
            var room = await _repo.GetByIdAsync(id) ?? throw new Exception();
            return View(room);
        }

        [HttpPost()]
        public async Task<IActionResult> ReservedStatus(RoomCheckIn room)
        {
            try
            {
                if (room != null)
                {
                    room = await _repo.GetByIdAsync(room.Id) ?? throw new Exception();
                    await _service.ToggleStatus(room).ConfigureAwait(true);

                    #region Update Room Setup
                    if (room.RoomSetupId.Contains(","))
                    {
                        string[] roomsetupId = room.RoomSetupId.Split(",");
                        for (int i = 0; i < roomsetupId.Length; i++)
                        {
                            var roomSetup = await _roomSetuRrepo.GetByIdAsync(long.Parse(roomsetupId[i])) ?? throw new Exception();
                            roomSetup.Status = FiboInfraStructure.Enums.Status.Reserved.ToString();
                            await _roomSetuRrepo.UpdateAsync(roomSetup);
                        }
                    }
                    else
                    {
                        var roomSetup = await _roomSetuRrepo.GetByIdAsync(long.Parse(room.RoomSetupId)) ?? throw new Exception();
                        roomSetup.Status = FiboInfraStructure.Enums.Status.Reserved.ToString();
                        await _roomSetuRrepo.UpdateAsync(roomSetup);
                    }
                    #endregion


                    return RedirectToAction(nameof(Index));
                }
            }
            catch (Exception ex)
            {
                throw new Exception();
            }
            return View(room);
        }

        [HttpGet()]
        public async Task<IActionResult> UpdateStatus(long? id)
        {
            if (!id.HasValue)
            {

            }
            var room = await _roomSetuRrepo.GetByIdAsync(id.Value) ?? throw new Exception();
            RoomSetupDto dto = new RoomSetupDto();

            _roomSetupAssembler.copyFrom(dto, room);
            return View(dto);
        }
        [HttpPost()]
        [ValidateAntiForgeryToken()]
        public async Task<IActionResult> UpdateStatus(RoomSetupDto dto)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    await _roomSetupService.UpdateAsync(dto);
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
        public async Task<IActionResult> DeleteConfirmed(RoomCheckIn room)
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

        [HttpGet()]
        public async Task<IActionResult> PrintCheckOut(long? id, string message)
        {
            LodgeBillingViewModel vm = new LodgeBillingViewModel();
            vm.LodgeBillings = await _lodgeRepo.GetAllLodgeBillingAsync();
            vm.LodgeBillings = vm.LodgeBillings.Where(x => x.Id == id).ToList();
            ViewBag.Message = message;
            return View(vm);
        }
    }
}
