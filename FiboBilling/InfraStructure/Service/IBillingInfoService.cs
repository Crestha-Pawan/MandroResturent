using FiboBilling.InfraStructure.Assembler;
using FiboBilling.InfraStructure.Repository;
using FiboBilling.Src.Dto;
using FiboInfraStructure.Entity.FiboBilling;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using System.Linq;
using FiboInventory.InfraStructure.Repository;
using FiboInfraStructure;
using FiboInventory;
using FiboInventory.Src.Dto;
using FiboInventory.InfraStructure.Service;

namespace FiboBilling.InfraStructure.Service
{
    public interface IBillingInfoService
    {
        Task<BillingInfoDto> InsertAsync(BillingInfoDto dto);
        Task<IEnumerable<BillingInfo>> InsertListAsync(IEnumerable<BillingInfo> entities);
        Task<BillingInfo> Delete(long Id);
        Task<BillingInfo> DeleteRange(IEnumerable<BillingInfo> entities);
        Task<BillingInfoDto> UpdateAsync(BillingInfoDto dto);
        Task<BillingDto> SaveAndDelete(BillingDto dto);
    }
    public class BillingInfoService : IBillingInfoService
    {
        private readonly IBillingInfoRepository _repo;
        private readonly IBillingInfoAssembler _assembler;
        private readonly IIngredientRepository _iRepo;
        private readonly IInventoryService _iInvService;
        private readonly IProductCategoryRepository _pcRepo;
        private readonly IProductRepository _pRepo;
        public BillingInfoService(IBillingInfoRepository repo
            , IBillingInfoAssembler assembler
            , IIngredientRepository iRepo
            , IInventoryService iInvService
            , IProductCategoryRepository pcRepo
            , IProductRepository pRepo
            )
        {
            _repo = repo;
            _assembler = assembler;
            _iRepo = iRepo;
            _iInvService = iInvService;
            _pcRepo = pcRepo;
            _pRepo = pRepo;
        }

        public async Task<BillingInfo> Delete(long Id)
        {
            var billingInfo = await _repo.GetByIdAsync(Id) ?? throw new Exception();
            return await _repo.DeleteAsync(billingInfo).ConfigureAwait(true);
        }

        public async Task<BillingInfo> DeleteRange(IEnumerable<BillingInfo> entities)
        {
            throw new NotImplementedException();
        }

        public async Task<BillingInfoDto> InsertAsync(BillingInfoDto dto)
        {
            BillingInfo billingInfo = new BillingInfo();
            _assembler.copyTo(billingInfo, dto);
            await _repo.AddAsync(billingInfo);
            dto.Id = billingInfo.Id;
            return dto;
        }

        public async Task<IEnumerable<BillingInfo>> InsertListAsync(IEnumerable<BillingInfo> entities)
        {
            return await _repo.AddRangeAsync(entities).ConfigureAwait(true);
        }

        public async Task<BillingDto> SaveAndDelete(BillingDto dto)
        {
            var billingInfoes = await _repo.GetByBillingId(dto.Id);

            foreach (var item in billingInfoes)
            {
                await Delete(item.Id);
            }
            List<BillingInfo> entities = new List<BillingInfo>();
            foreach (var dto_info in dto.BillingInfo)
            {
                BillingInfo info = new BillingInfo();
                var _product = await _pRepo.GetByIdAsync(long.Parse(dto_info.ProductId.ToString()));
                var _category = await _pcRepo.GetByIdAsync(long.Parse(_product.ProductCategoryId.ToString()));
                if (_category != null)
                {
                    if (_category.Name.ToLower() == "beverage")
                    {
                        dto_info.IsKOT = false;
                    }
                    else
                    {
                        dto_info.IsKOT = true;
                    }
                }
                dto_info.BillingId = dto.Id;
                dto_info.CreatedBy = dto.CreatedBy;
                dto_info.BranchId = dto.BranchId;
                if (dto_info.Amount != 0 && dto_info.Amount != null)
                {
                    _assembler.copyTo(info, dto_info);
                    entities.Add(info);
                }
            }

            await InsertListAsync(entities);
            return dto;
        }

        public async Task<BillingInfoDto> UpdateAsync(BillingInfoDto dto)
        {
            BillingInfo billingInfo = new BillingInfo();
            _assembler.modifyTo(billingInfo, dto);
            await _repo.UpdateAsync(billingInfo);
            return dto;
        }

    }
}
