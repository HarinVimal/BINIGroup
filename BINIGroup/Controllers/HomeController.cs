using System.Diagnostics;
using BINIGroup.Models;
using Microsoft.AspNetCore.Mvc;

namespace BINIGroup.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        public IActionResult Home()
        {
            return View();
        }

    }
}
