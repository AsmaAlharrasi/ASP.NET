using Microsoft.AspNetCore.Mvc;
using SystemClinc.BLL.Interface;

namespace SystemClinc.Controllers
{
    public class PationController : Controller
    {
        private readonly IPatient _pation;
        public PationController(IPatient pation)
        {
            _pation = pation;
        }
        public IActionResult Index()
        {
            return View();
        }
    }


}
