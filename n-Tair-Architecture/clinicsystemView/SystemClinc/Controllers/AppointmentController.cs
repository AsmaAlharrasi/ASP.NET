using Clinic_Registration_and_Management_System.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using SystemClinc.BLL.Interface;
using SystemClinc.DAL.MyDbContext;

namespace SystemClinc.Controllers
{
    public class AppointmentController : Controller
    { 
        private readonly IAppointment _Appointment;
        private readonly ISpecialization _Special;
        private readonly ApplicationDbContext _context;
        public AppointmentController(IAppointment appointment, ISpecialization special,ApplicationDbContext dbContext)
        {
            _Appointment = appointment;
            _Special = special;
            _context = dbContext;   
        }
        public IActionResult Index()
        {
            int USERID = (int)TempData["LoggedInUserId"];
            ViewBag.LoggedInUserName = USERID;
            //  ViewBag.Special = _Special.GetAll();

            return View();
        }
        public IActionResult Create()
        {
            // ViewBag.Special = _Special.GetAll();
            ViewBag.Special = new SelectList(_context.Specialization, "SpecializationID", "SpecializationName");

            return View();
        }

    [HttpPost]
    public IActionResult Create(Appointment appointment)
    {
        if (ModelState.IsValid)
            {
              
                ViewBag.Special = new SelectList(_context.Specialization, "SpecializationID", "SpecializationName");
                int PatientId = (int)TempData["Get Patient ID"];
                appointment.Specialization = _context.Specialization.Find(appointment.SpecializationID);

                appointment.PatientID = PatientId;
            _Appointment.Create(appointment);

                return RedirectToAction("Index", "Patient");
            }

        return View();

    }

}
}
