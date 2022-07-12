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
using Microsoft.AspNetCore.Mvc;

namespace FiboCounterSystem.Areas.Inventories.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _productService;
        private readonly IProductRepository _productRepository;
        private readonly IProductAssembler _productAssembler;
        private readonly IProductCategoryRepository _productCategoryRepository;
        private readonly IProductSubCategoryRepository _productSubCategoryRepository;
        private readonly IIngredientRepository _ingredientRepository;
        private readonly IMeasuringUnitRepository _muRepo;
        private readonly IItemRepository _itemRepository;
        private readonly IUserAndBranchInfo _userAndBranchInfo;
        public ProductController(IProductService productService
            , IProductRepository productRepository
            , IProductAssembler productAssembler
            , IProductCategoryRepository productCategoryRepository
            , IProductSubCategoryRepository productSubCategoryRepository
            , IIngredientRepository ingredientRepository 
            , IMeasuringUnitRepository measuringUnitRepository 
            , IUserAndBranchInfo userAndBranchInfo
            , IItemRepository itemRepository)
        {
            _productService = productService;
            _productSubCategoryRepository = productSubCategoryRepository;
            _productAssembler = productAssembler;
            _productCategoryRepository = productCategoryRepository;
            _productRepository = productRepository;
            _ingredientRepository = ingredientRepository;
            _muRepo = measuringUnitRepository;
            _userAndBranchInfo = userAndBranchInfo;
            _itemRepository = itemRepository;
        }
        public async Task<IActionResult> Index(ProductViewModel vm)
        {
            var productsss = await _productRepository.GetAllProductAsync();
            vm.products = new List<Product>();
            vm.Productss = await _productRepository.GetAllProductAsync();
           
            var productcategory = await _productCategoryRepository.GetAllProductCategoryAsync();
            var productsubcategory = await _productSubCategoryRepository.GetAllProductSubCategoryAsync();
           
            if (vm.ProductId > 0)
            {
                productsss = productsss.Where(x => x.Id == vm.ProductId).ToList();
            }
            vm.ProductCategories = productcategory;
            vm.ProductSubCategories = productsubcategory;
            vm.products = productsss;
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
        public async Task<IActionResult> IngredientList(long ProductId)
        {
            var ingredients = await _ingredientRepository.GetAllIngredientAsync();
            IngredientViewModel vm = new IngredientViewModel
            {
                Ingredients = await _ingredientRepository.GetByProductId(ProductId),
                Product = await _productRepository.GetByIdAsync(ProductId)
            };
            return View(vm);
        }

        [HttpGet()]
        public async Task<IActionResult> Create()

        {
            ProductDto dto = new ProductDto
            {
                ProductCategories = await _productCategoryRepository.GetAllProductCategoryAsync(),
                ProductSubCategories = await _productSubCategoryRepository.GetAllProductSubCategoryAsync(),
                MeasuringUnits = await _muRepo.GetAllMeasuringUnitAsync(),
                CreatedBy = await _userAndBranchInfo.getCurrentUser(),
                BranchId = await _userAndBranchInfo.getCurrentBranch(),
                items = await _itemRepository.GetAllItemAsync(),
                IngredientDtos = new List<IngredientDto>()
            };

            return View(dto);
        }

        [HttpPost()]
        [ValidateAntiForgeryToken()]
        public async Task<IActionResult> Create(ProductDto dto)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    await _productService.InsertAsync(dto);
                    return RedirectToAction(nameof(Index));
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Product with {dto.Id} not found.");
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
            var product = await _productRepository.GetByIdAsync(id.Value) ?? throw new Exception();
            ProductDto dto = new ProductDto()
            {
                ProductCategories = await _productCategoryRepository.GetAllProductCategoryAsync(),
                ProductSubCategories = await _productSubCategoryRepository.GetAllProductSubCategoryAsync(),
                MeasuringUnits = await _muRepo.GetAllMeasuringUnitAsync(),
                items = await _itemRepository.GetAllItemAsync(),
            };
            _productAssembler.copyFrom(dto, product);
            return View(dto);
        }
        [HttpPost()]
        [ValidateAntiForgeryToken()]
        public async Task<IActionResult> Update(ProductDto dto)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    await _productService.UpdateAsync(dto);
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
            var product = await _productRepository.GetByIdAsync(id) ?? throw new Exception();
            return View(product);
        }

        [HttpPost()]
        [ValidateAntiForgeryToken()]
        public async Task<IActionResult> DeleteConfirmed(Product product)
        {
            try
            {
                if (product != null)
                {
                    await _productService.Delete(product.Id).ConfigureAwait(true);
                    return RedirectToAction(nameof(Index));
                }
            }
            catch (Exception ex)
            {
                throw new Exception();
            }
            return View(product);
        }
    }
}
