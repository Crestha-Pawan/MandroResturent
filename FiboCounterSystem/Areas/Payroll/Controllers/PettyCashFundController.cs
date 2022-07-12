using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FiboInfraStructure.Entity.Payroll;
using FiboParty.Infrastructure.Repository;
using Microsoft.AspNetCore.Mvc;
using Payroll.InfraStructure.Assembler;
using Payroll.InfraStructure.Service;
using Payroll.Src.Dto;
using Payroll.Src.ViewModel;
using FiboInfraStructure;
namespace FiboCounterSystem.Areas.Payroll.Controllers
{
    public class PettyCashFundController : Controller
    {
        private readonly IPettyCashFundService _pettyCashFundService;
        private readonly IPettyCashFundRepository _pettyCashFundRepository;
        private readonly IPettyCashFundAssembler _pettyCashFundAssembler;
        public PettyCashFundController(IPettyCashFundService pettyCashFundService
            , IPettyCashFundRepository pettyCashFundRepository
            , IPettyCashFundAssembler pettyCashFundAssembler)
        {
            _pettyCashFundService = pettyCashFundService;
            _pettyCashFundRepository = pettyCashFundRepository;
            _pettyCashFundAssembler = pettyCashFundAssembler;
        }
        public async Task<IActionResult> Index(PettyCashFundViewModel vm)
        {
            vm.pettyCashFundList = new List<PettyCashFund>();
            var pettys = await _pettyCashFundRepository.GetAllPettyCashFundAsync();

            //if (string.IsNullOrEmpty(vm.FromMiti) && string.IsNullOrEmpty(vm.ToMiti))
            //{
            //    vm.FromDate = DateTime.Now.AddDays(-1);
            //    vm.ToDate = DateTime.Now;
            //    pettys = pettys.Where(x => x.Date.ToDateTime() > vm.FromDate && x.Date.ToDateTime() < vm.ToDate).ToList();

            //}
            //if (!string.IsNullOrEmpty(vm.FromMiti))
            //{
            //    vm.FromDate = vm.FromMiti.ToEnglishDate();
            //    pettys = pettys.Where(x => x.Date.ToDateTime() >= vm.FromDate).ToList();
            //}
            //if (!string.IsNullOrEmpty(vm.ToMiti))
            //{
            //    vm.ToDate = vm.ToMiti.ToEnglishDate();
            //    pettys = pettys.Where(x => x.Date.ToDateTime() <= vm.ToDate).ToList();
            //}

            vm.pettyCashFundList = pettys;
            return View(vm);
        }
        [HttpGet()]
        public async Task<IActionResult> Create()
        {
            PettyCashFundDto pettyCashFund = new PettyCashFundDto
            {
                Date = DateTime.Now.ToDateTime().ToNepDate(),
            };
            return View(pettyCashFund);
        }

        [HttpPost()]
        [ValidateAntiForgeryToken()]
        public async Task<IActionResult> Create(PettyCashFundDto dto)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    foreach (var item in dto.pettyCashFundDtos)
                    {
                        item.Date = dto.Date;
                        await _pettyCashFundService.Insertasync(item);
                    }
                    return RedirectToAction("Index", "PettyCashFund");
                    
                }
            }
            catch (Exception ex)
            {
                throw new Exception();
            }
            return View(dto);
        }

        [HttpGet()]
        public async Task<IActionResult> Update(long? id)
        {
            if (!id.HasValue)
            {

            }
            var petty = await _pettyCashFundRepository.GetByIdAsync(id.Value) ?? throw new Exception();
            PettyCashFundDto dto = new PettyCashFundDto();
            _pettyCashFundAssembler.copyFrom(dto, petty);
            return View(dto);
        }
        [HttpPost()]
        [ValidateAntiForgeryToken()]
        public async Task<IActionResult> Update(PettyCashFundDto dto)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    await _pettyCashFundService.UpdateAsync(dto);
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
            var pettys = await _pettyCashFundRepository.GetByIdAsync(id) ?? throw new Exception();
            return View(pettys);
        }

        [HttpPost()]
        [ValidateAntiForgeryToken()]
        public async Task<IActionResult> DeleteConfirmed(PettyCashFund pettyCashFund)
        {
            try
            {
                if (pettyCashFund != null)
                {
                    await _pettyCashFundService.Delete(pettyCashFund.Id).ConfigureAwait(true);
                    return RedirectToAction(nameof(Index));
                }
            }
            catch (Exception ex)
            {

            }
            return View(pettyCashFund);
        }
    }
}
