using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using FiboInfraStructure.Entity.Payroll;
using FiboParty.Infrastructure.Repository;
using Payroll.InfraStructure.Assembler;
using Payroll.Src.Dto;

namespace Payroll.InfraStructure.Service
{
    public interface IPettyCashFundService
    {
        Task<PettyCashFundDto> Insertasync(PettyCashFundDto dto);
        Task<PettyCashFund> Delete(long Id);
        Task<PettyCashFundDto> UpdateAsync(PettyCashFundDto dto);
    }
    public class PettyCashFundService : IPettyCashFundService
    {
        private readonly IPettyCashFundRepository _pettyRepository;
        private readonly IPettyCashFundAssembler _assembler;
        //private readonly ILocalLevelRepository _localRepo;
        //private readonly IDistrictRepository _districtRepo;
        public PettyCashFundService(IPettyCashFundRepository pettyRepository,
            IPettyCashFundAssembler assembler
            //ILocalLevelRepository localLevelRepository,
            //IDistrictRepository districtRepository
            )
        {
            _pettyRepository = pettyRepository;
            _assembler = assembler;
            //_localRepo = localLevelRepository;
            //_districtRepo = districtRepository;
        }
        public async Task<PettyCashFundDto> Insertasync(PettyCashFundDto dto)
        {
                PettyCashFund pettyCashFund = new PettyCashFund();
                _assembler.copyTo(pettyCashFund, dto);
                await _pettyRepository.AddAsync(pettyCashFund);
                dto.Id = pettyCashFund.Id;
           
            return dto;
        }

        public async Task<PettyCashFundDto> UpdateAsync(PettyCashFundDto dto)
        {
            PettyCashFund pettyCashFund = new PettyCashFund();
            _assembler.modifyTo(pettyCashFund, dto);
            await _pettyRepository.UpdateAsync(pettyCashFund);
            return dto;
        }

        public async Task<PettyCashFund> Delete(long Id)
        {
            var localLevel = await _pettyRepository.GetByIdAsync(Id) ?? throw new Exception();
            return await _pettyRepository.DeleteAsync(localLevel).ConfigureAwait(true);
        }

    }
}
