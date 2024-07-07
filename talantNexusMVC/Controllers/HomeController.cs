using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using talantNexusMVC.Models;
using talantNexusMVC.Servives;
using BAL;

namespace talantNexusMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly Services _Service;

      
        public HomeController(ILogger<HomeController> logger,Services service)
        {
            _logger = logger;
            _Service = service;
        }

        public async Task<IActionResult> Index()
        {
            // return View();
            var Students = await _Service.GetAllStudents();
            return View(Students);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
