using Microsoft.AspNetCore.Mvc;
using VisionProApp.Data;
using VisionProApp.Interfaces;

namespace VisionProApp.Controllers
{
    public class BuildingController : Controller
    {
        private readonly IBuildingRepository _buildingRepository;
        private readonly ISiteRepository _siteRepository;
        private readonly IClientRepository _clientRepository;

        public BuildingController(IBuildingRepository buildingRepository, ISiteRepository siteRepository, IClientRepository clientRepository)
        {
            _buildingRepository = buildingRepository;
            _siteRepository = siteRepository;
            _clientRepository = clientRepository;
        }

        [HttpGet]
        [Route("/building")]
        public async Task<IActionResult> IndexAsync()
        {
            var buildings = await _buildingRepository.GetAll();
            return View(buildings);
        }
        [HttpGet]
        [Route("/building/{id}")]
        public async Task<IActionResult> IndexAsync(int id)
        {
            var site = _siteRepository.GetByID(id);
            var buildings = await _buildingRepository.GetBuildingsBySite(site);
            return View(buildings);
        }
    }
}
