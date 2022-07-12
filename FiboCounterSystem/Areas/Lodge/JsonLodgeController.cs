using FiboLodge.InfraStructure.Repository;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace FiboCounterSystem.Areas.Lodge
{
    public class JsonLodgeController : Controller
    {
        private readonly IRoomSetupRepository _roomRepo;
        public JsonLodgeController(IRoomSetupRepository roomRepo)
        {
            _roomRepo = roomRepo;
        }
        public async Task<JsonResult> LoadRoomRate(long RoomId)
        {
            var room = await _roomRepo.GetByIdAsync(RoomId);
            return Json(room);
        }
    }
}
