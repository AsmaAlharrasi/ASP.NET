
using Clinic_Registration_and_Management_System.Model;
using Microsoft.AspNetCore.Mvc;
using SystemClinc.BLL.Interface;

namespace SystemClinc.Controllers
{
    public class DoctorController : Controller
    {
       
        private readonly IAppointment _appointment;
        public DoctorController(IAppointment appointment)
        {
            _appointment = appointment;
        }
        public IActionResult Index()
        {
            var dep = _appointment.GetAll();
            return View(dep);
        }

        public IActionResult Update(int id)
        {
            var dep = _appointment.Get(id);
            return View(dep);
        }

        [HttpPost]
        public IActionResult Update(Appointment appointment)
        {
            if (ModelState.IsValid)
            {
                _appointment.Update(appointment);
                return RedirectToAction("Index");
            }
            return View(appointment);
        }


        public ActionResult Delete(int id)
        {
           
            var dep = _appointment.Get(id);
            _appointment.Delete(dep);
            
            return RedirectToAction("Index");
        }
    }
}
