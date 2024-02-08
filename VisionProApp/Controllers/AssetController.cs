using Microsoft.AspNetCore.Mvc;
using VisionProApp.Data;
using VisionProApp.Interfaces;

namespace VisionProApp.Controllers
{
    public class AssetController : Controller
    {
        private readonly IAssetRepository _assetRepository;
        private readonly IRoomRepository _roomRepository;

        public AssetController(IAssetRepository assetRepository, IRoomRepository roomRepository)
        {
            _assetRepository = assetRepository;
            _roomRepository = roomRepository;
        }

        [HttpGet]
        [Route("/asset")]
        public async Task<IActionResult> IndexAsync()
        {
            var assets = await _assetRepository.GetAll();
            return View(assets);
        }
        [HttpGet]
        [Route("/asset/{id}")]
        public async Task<IActionResult> IndexAsync(int id)
        {
            var room = _roomRepository.GetById(id);
            var assets = await _assetRepository.GetAssetsByRoom(room);
            return View(assets);
        }
    }
}
