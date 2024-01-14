using CodeAcademy.BLL.Interface;
using CodeAcademy.DAL.Models;
using Microsoft.AspNetCore.Mvc;

namespace CodeAcademy.PL.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IEmployeeRepository _EmployeeRepo;
        public EmployeeController(IEmployeeRepository Employeerepo)
        {

            _EmployeeRepo = Employeerepo;
        }
        public IActionResult Index()
        {
            var deps = _EmployeeRepo.GetAll();
            return View(deps);
        }
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return BadRequest();
            }
            var emp = _EmployeeRepo.Get(id.Value);
            return View(emp);

        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Employee emp)
        {
            
            _EmployeeRepo.Create(emp);

            return RedirectToAction("Index");
        }
        public IActionResult Update(int id)
        {
            var emp = _EmployeeRepo.Get(id);
            return View(emp);
        }

        [HttpPost]
        public IActionResult Update(Employee emp)
        {
            if (ModelState.IsValid)
            {
                _EmployeeRepo.Update(emp);
                return RedirectToAction("Index");
            }
            return View(emp);
        }

        public IActionResult Delete(int id)
        {
            var emp = _EmployeeRepo.Get(id);
            _EmployeeRepo.Delete(emp);
            return RedirectToAction("Index");
        }
    }
}
