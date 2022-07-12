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
    public class ProductCategoryController : Controller
    {
        private readonly IProductCategoryService _productCategoryService;
        private readonly IProductCategoryRepository _productCategoryRepository;
        private readonly IProductCategoryAssembler _productCategoryAssembler;
        private readonly IProductSubCategoryRepository _productSubCategoryRepository;
        private readonly IUserAndBranchInfo _userAndBranchInfo;
        public ProductCategoryController(IProductCategoryService productCategoryService , IProductCategoryRepository productCategoryRepository , IProductCategoryAssembler productCategoryAssembler, IProductSubCategoryRepository productSubCategoryRepository, IUserAndBranchInfo userAndBranchInfo)
        {
            _productCategoryService  = productCategoryService;
            _productCategoryRepository = productCategoryRepository;
            _productCategoryAssembler = productCategoryAssembler;
            _productSubCategoryRepository = productSubCategoryRepository;
            _userAndBranchInfo = userAndBranchInfo;
        }
        public async Task<IActionResult> Index(ProductcategoryViewModel vm)
        {
            vm.ProductCategory = new List<ProductCategory>();
            var productcategory = await _productCategoryRepository.GetAllProductCategoryAsync();
            //vm.Employees = emp.Where(x => x.IsActive()).ToList();
            vm.ProductSubCategories = await _productSubCategoryRepository.GetAllProductSubCategoryAsync();
            vm.ProductCategory = productcategory;
            return View(vm);
        }

        public async Task<IActionResult> SubCategoryList(long ProductCategoryId)
        {
            //var ingredients = await _ingredientRepository.GetAllIngredientAsync();
            ProductSubCategoryViewModel vm = new ProductSubCategoryViewModel
            {
                productSubCategory = await _productSubCategoryRepository.GetByCategoryId(ProductCategoryId),
                ProductCategory = await _productCategoryRepository.GetByIdAsync(ProductCategoryId)
            };
            return View(vm);
        }

        [HttpGet()]
        public async Task<IActionResult> Create()
        {
            ProductCategoryDto dto = new ProductCategoryDto
            {
                SubCategoryDtos = new List<ProductSubCategoryDto>(),
                CreatedBy = await _userAndBranchInfo.getCurrentUser(),
                BranchId = await _userAndBranchInfo.getCurrentBranch(),
            };
            return View(dto);
        }

        [HttpPost()]
        [ValidateAntiForgeryToken()]
        public async Task<IActionResult> Create(ProductCategoryDto dto)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    await _productCategoryService.InsertAsync(dto);
                    return RedirectToAction(nameof(Index));
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"ProductCategory with {dto.Id} not found.");
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
            var productcat = await _productCategoryRepository.GetByIdAsync(id.Value) ?? throw new Exception();
            ProductCategoryDto dto = new ProductCategoryDto();
            _productCategoryAssembler.copyFrom(dto, productcat);
            return View(dto);
        }
        [HttpPost()]
        [ValidateAntiForgeryToken()]
        public async Task<IActionResult> Update(ProductCategoryDto dto)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    await _productCategoryService.UpdateAsync(dto);
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
            var productCategory = await _productCategoryRepository.GetByIdAsync(id) ?? throw new Exception();
            return View(productCategory);
        }

        [HttpPost()]
        [ValidateAntiForgeryToken()]
        public async Task<IActionResult> DeleteConfirmed(ProductCategory productCategory)
        {
            try
            {
                if (productCategory != null)
                {
                    await _productCategoryService.Delete(productCategory.Id).ConfigureAwait(true);
                    return RedirectToAction(nameof(Index));
                }
            }
            catch (Exception ex)
            {
                throw new Exception();
            }
            return View(productCategory);
        }
    }
}
