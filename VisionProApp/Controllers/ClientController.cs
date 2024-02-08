using Microsoft.AspNetCore.Mvc;
using VisionProApp.Data;
using VisionProApp.Interfaces;

//using VisionProApp.Interfaces;
using VisionProApp.Models;

namespace VisionProApp.Controllers
{
    public class ClientController : Controller
    {
        //private readonly IClientRepository _clientRepository;
        private readonly ApplicationDbContext _context;
        private readonly IClientRepository _clientRepository;

        public ClientController(IClientRepository clientRepository)
        {
            _clientRepository = clientRepository;
        }
        public async Task<IActionResult> IndexAsync()
        {
            var clients = await _clientRepository.GetAll();
            return View(clients);
        }

    }
}
