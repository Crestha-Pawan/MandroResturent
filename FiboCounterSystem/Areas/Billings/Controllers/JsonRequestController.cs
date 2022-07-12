using FiboInventory.InfraStructure.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FiboCounterSystem.Areas.Billings.Controllers
{
    public class JsonRequestController : Controller
    {
        private readonly IProductRepository _repo;
        public JsonRequestController(IProductRepository repo)
        {
            _repo = repo;
        }
        public async Task<JsonResult> LoadProductRate(long productId)
        {
            var product = await _repo.GetByIdAsync(productId);
            return Json(product);
        }

    }
}
