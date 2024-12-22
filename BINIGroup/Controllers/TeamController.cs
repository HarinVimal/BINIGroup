using Microsoft.AspNetCore.Mvc;

namespace BINIGroup.Controllers
{
    public class TeamController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
