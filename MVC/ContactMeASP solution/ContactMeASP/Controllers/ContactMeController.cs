using Microsoft.AspNetCore.Mvc;

namespace ContactMeASP.Controllers
{
    public class ContactMeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
