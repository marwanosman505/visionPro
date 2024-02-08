using Microsoft.AspNetCore.Mvc;
using VisionProApp.Data;
using VisionProApp.Interfaces;
using VisionProApp.Repository;

namespace VisionProApp.Controllers
{
    public class RoomController : Controller
    {
        private readonly IRoomRepository _roomRepository;
        private readonly IBuildingRepository _buildingRepository;


        public RoomController(IRoomRepository roomRepository, IBuildingRepository buildingRepository)
        {
            _roomRepository = roomRepository;
            _buildingRepository = buildingRepository;
        }

        [HttpGet]
        [Route("/room")]
        public async Task<IActionResult> IndexAsync()
        {
            var rooms = await _roomRepository.GetAll();
            return View(rooms);
        }
        [HttpGet]
        [Route("room/{id}")]
        public async Task<IActionResult> IndexAsync(int id)
        {
            var building = _buildingRepository.GetByID(id);
            var sites = await _roomRepository.GetRoomsByBuilding(building);
            return View(sites);
        }
    }
}
