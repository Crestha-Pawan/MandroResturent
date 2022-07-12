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
using Microsoft.AspNetCore.Mvc;

namespace FiboCounterSystem.Areas.Inventories.Controllers
{
    public class ProductSubCategoryController : Controller
    {
        private readonly IProductSubCategoryService _productSubCategoryService;
        private readonly IProductSubCategoryRepository _productSubCategoryRepository;
        private readonly IProductSubCategoryAssembler _productSubCategoryAssembler;
        private readonly IProductCategoryRepository _productCategoryRepository;
        private readonly IUserAndBranchInfo _userAndBranchInfo;
        public ProductSubCategoryController(IProductSubCategoryService productSubCategoryService , IProductSubCategoryRepository productSubCategoryRepository , IProductSubCategoryAssembler productSubCategoryAssembler , IProductCategoryRepository productCategoryRepository , IUserAndBranchInfo userAndBranchInfo )
        {
            _productSubCategoryService = productSubCategoryService;
            _productSubCategoryRepository = productSubCategoryRepository;
            _productSubCategoryAssembler = productSubCategoryAssembler;
            _productCategoryRepository = productCategoryRepository;
            _userAndBranchInfo = userAndBranchInfo;
        }
        public async Task<IActionResult> Index(ProductSubCategoryViewModel vm)
        {
            vm.productSubCategory = new List<ProductSubCategory>();
            var productSubCategory = await _productSubCategoryRepository.GetAllProductSubCategoryAsync();
            //vm.Employees = emp.Where(x => x.IsActive()).ToList();
            vm.productSubCategory = productSubCategory;
            return View(vm);
        }

        [HttpGet()]
        public async Task<IActionResult> Create()
        {
            ProductSubCategoryDto dto = new ProductSubCategoryDto
            {
                ProductCategories = await _productCategoryRepository.GetAllProductCategoryAsync(),
                CreatedBy = await _userAndBranchInfo.getCurrentUser(),
                BranchId = await _userAndBranchInfo.getCurrentBranch(),
            };
            return View(dto);
        }

        [HttpPost()]
        [ValidateAntiForgeryToken()]
        public async Task<IActionResult> Create(ProductSubCategoryDto dto)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    await _productSubCategoryService.InsertAsync(dto);
                    return RedirectToAction(nameof(Index));
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"ProductSubCategory with {dto.Id} not found.");
            }
            return View(dto);
        }
        [HttpGet()]
        public async Task<IActionResult> Update(long? id)
        {
            if (!id.HasValue)
            {
                throw new Exception();
            }
            var productSubCategory = await _productSubCategoryRepository.GetByIdAsync(id.Value) ?? throw new Exception();
            ProductSubCategoryDto dto = new ProductSubCategoryDto()
            {
                ProductCategories = await _productCategoryRepository.GetAllProductCategoryAsync()
            };
            _productSubCategoryAssembler.copyFrom(dto, productSubCategory);
            return View(dto);
        }
        [HttpPost()]
        [ValidateAntiForgeryToken()]
        public async Task<IActionResult> Update(ProductSubCategoryDto dto)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    await _productSubCategoryService.UpdateAsync(dto);
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
            var productsubCategory = await _productSubCategoryRepository.GetByIdAsync(id) ?? throw new Exception();
            return View(productsubCategory);
        }

        [HttpPost()]
        [ValidateAntiForgeryToken()]
        public async Task<IActionResult> DeleteConfirmed(ProductSubCategory productsubCategory)
        {
            try
            {
                if (productsubCategory != null)
                {
                    await _productSubCategoryService.Delete(productsubCategory.Id).ConfigureAwait(true);
                    return RedirectToAction(nameof(Index));
                }
            }
            catch (Exception ex)
            {
                throw new Exception();
            }
            return View(productsubCategory);
        }
    }
}
