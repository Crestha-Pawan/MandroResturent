using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FiboAddress.InfraStructure.Repository;
using FiboInventory.InfraStructure.Repository;
using FiboLodge.InfraStructure.Repository;
using FiboOffice.InfraStructure.Repository;
using Microsoft.AspNetCore.Mvc;

namespace FiboCounterSystem.Areas.Inventory.Controllers
{
    public class JsonLoadCategoryController : Controller
    {
        private readonly IProductSubCategoryRepository _subcatRepository;
        private readonly IVendorRepository _vendorRepo;
        private readonly IMeasuringUnitRepository _muRepo;
        private readonly IRoomSetupRepository _roomRepo;
        private readonly IRoomCheckInRepository _roomCheckInRepo;
        private readonly IItemRepository _itemRepo;
        public JsonLoadCategoryController(IProductSubCategoryRepository productSubCategoryRepository
            , IVendorRepository vendorRepo
            , IMeasuringUnitRepository muRepo
            , IRoomSetupRepository roomRepo
            , IRoomCheckInRepository roomCheckInRepo
            , IItemRepository itemRepo
            )
        {
            _subcatRepository = productSubCategoryRepository;
            _vendorRepo = vendorRepo;
            _muRepo = muRepo;
            _roomRepo = roomRepo;
            _roomCheckInRepo = roomCheckInRepo;
            _itemRepo = itemRepo;
        }
        public async Task<JsonResult> LoadSubCategoryFromCategory(long categoryId)
        {
            long catId = categoryId;
            var subcat = await _subcatRepository.GetAllProductSubCategoryAsync();
            var subcategory = subcat.Where(x => x.ProductCategoryId == catId).ToList();
            return Json(subcategory);
        }

        public async Task<JsonResult> LoadVendorDetail(long id)
        {
            long vendorId = id;
            var vendorList = await _vendorRepo.GetAllVendorAsync();
            var vendor = vendorList.Where(x => x.Id == vendorId).ToList();
            return Json(vendor);
        }

        public async Task<JsonResult> GetMeasuringUnit(long id)
        {
            var itemList = await _itemRepo.GetAllItemAsync();
            var item = itemList.Where(x => x.Id == id).FirstOrDefault();
            return Json(item);
        }

        public async Task<JsonResult> CheckRoomList(string id)
        {

            string message=string.Empty;
            var roomList = await _roomRepo.GetAllRoomAsync();
            if (id.Contains(","))
            {
                string[] roomsetupId = id.Split(",");
                for (int i = 0; i < roomsetupId.Length; i++)
                {
                    foreach (var item in roomList)
                    {
                        if (item.Id == long.Parse(roomsetupId[i]) && item.Status != FiboInfraStructure.Enums.Status.VacantClean.ToString())
                        {
                            var roomSetup = await _roomRepo.GetByIdAsync(long.Parse(roomsetupId[i]));

                            if (item.Status == FiboInfraStructure.Enums.Status.Engaged.ToString())
                            {
                                message += string.Format("{0}: Room is Already Checked-In.{1}", roomSetup.RoomName, "\n");
                            }
                            else if (item.Status == FiboInfraStructure.Enums.Status.VacantDirty.ToString())
                            {
                                message += string.Format("{0}: Room is dirty.{1}", roomSetup.RoomName, "\n");
                            }
                        }
                    }
                }
            }
            else
            {
                foreach (var item in roomList)
                {
                    if (item.Id == long.Parse(id) && item.Status != FiboInfraStructure.Enums.Status.VacantClean.ToString())
                    {
                        var roomSetup = await _roomRepo.GetByIdAsync(long.Parse(id));

                        if (item.Status == FiboInfraStructure.Enums.Status.Engaged.ToString())
                        {
                            message += string.Format("{0}: Room is Already Checked-In.{1}", roomSetup.RoomName, "\n");
                        }
                        else if (item.Status == FiboInfraStructure.Enums.Status.VacantDirty.ToString())
                        {
                            message += string.Format("{0}: Room is dirty.{1}", roomSetup.RoomName, "\n");
                        }
                    }
                }
            }

            return Json(message);
        }
    }
}
