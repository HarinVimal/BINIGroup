using Microsoft.AspNetCore.Mvc;

namespace BINIGroup.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
