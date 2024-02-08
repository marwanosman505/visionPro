using Microsoft.AspNetCore.Mvc;
using VisionProApp.Data;
using VisionProApp.Interfaces;

namespace VisionProApp.Controllers
{
    public class SiteController : Controller
    {
        private readonly ISiteRepository _siteRepository;
        private readonly IClientRepository _clientRepository;
        public SiteController(ISiteRepository siteRepository, IClientRepository clientRepository)
        {
            _siteRepository = siteRepository;
            _clientRepository = clientRepository;
        }
        [HttpGet]
        [Route("/site")]
        public async Task<IActionResult> IndexAsync()
        {
            var sites = await _siteRepository.GetAll();
            return View(sites);
        }
        [HttpGet]
        [Route("site/{id}")]
        public async Task<IActionResult> IndexAsync(int id)
        {
            var client = _clientRepository.GetByID(id);
            var sites = await _siteRepository.GetSitesByClient(client);
            return View(sites);
        }
    }
}
