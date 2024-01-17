using Microsoft.AspNetCore.Mvc;
using SystemClinc.BLL.Interface;

namespace SystemClinc.Controllers
{
    public class SplizationController : Controller
    {
        private readonly ISpecialization _Specialization;
        public SplizationController(ISpecialization Specialization)
        {
            _Specialization = Specialization;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
