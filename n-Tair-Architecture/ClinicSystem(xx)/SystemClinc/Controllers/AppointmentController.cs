using Microsoft.AspNetCore.Mvc;
using SystemClinc.BLL.Interface;

namespace SystemClinc.Controllers
{
    public class AppointmentController : Controller
    { 
        private readonly IAppointment _Appointment;
        public AppointmentController(IAppointment appointment) {
            _Appointment = appointment;

        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
