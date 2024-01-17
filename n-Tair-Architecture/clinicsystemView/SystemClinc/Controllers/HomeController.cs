using Clinic_Registration_and_Management_System.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using SystemClinc.BLL.Interface;
using SystemClinc.DAL.MyDbContext;
using SystemClinc.Models;

namespace SystemClinc.Controllers
{
    public class HomeController : Controller
    {
      
        private readonly ApplicationDbContext _context;

        public HomeController( ApplicationDbContext context)
        {
           
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(int userId, string UserName)
        {
            
            
           // var visitorlogin = (from x in _context.Patients where x.PatientID == userId select x).FirstOrDefault();
            var visitorlogin = _context.Patients.Where(e => e.FName.Equals(UserName) && e.PatientID.Equals(userId)).FirstOrDefault();

            if (visitorlogin != null)
            {
                var persoName = visitorlogin.FName;
                int personID = visitorlogin.PatientID;

                TempData["LoggedInUserName"] = persoName;
                TempData["LoggedInUserId"] = personID;


                return RedirectToAction("Index", "Patient");
            }
            else
            {
                return View("Index");
            }
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}