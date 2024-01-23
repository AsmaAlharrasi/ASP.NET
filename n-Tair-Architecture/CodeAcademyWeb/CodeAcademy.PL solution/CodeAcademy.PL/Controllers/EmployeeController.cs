using AutoMapper;
using CodeAcademy.BLL.Interface;
using CodeAcademy.BLL.Repository;
using CodeAcademy.DAL.Models;
using CodeAcademy.PL.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CodeAcademy.PL.Controllers
{
    [Authorize]
    public class EmployeeController : Controller
    {

        //private readonly IEmployeeRepository _EmployeeRepo;
        //private readonly IDepartmentRepository _departmentrepo;

        //public EmployeeController(IEmployeeRepository Employeerepo, IDepartmentRepository departmentrepo)
        //{

        //    _EmployeeRepo = Employeerepo;
        //    _departmentrepo = departmentrepo;
        //}

        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public EmployeeController(IUnitOfWork unitOfWork , IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }


        public IActionResult Index(string search)
        {
            IEnumerable<Employee> emps;
            if (string.IsNullOrEmpty(search))
            {
                emps = _unitOfWork.EmployeeRepository.GetAll();
            }
            else
            {
                emps = _unitOfWork.EmployeeRepository.Search(search);
            }
            return View(emps);
        }
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return BadRequest();
            }
            var emp = _unitOfWork.EmployeeRepository.Get(id.Value);
            return View(emp);

        }
        public IActionResult Create()
        {
            ViewBag.Departments = _unitOfWork.EmployeeRepository.GetAll();
            return View();
        }
        [HttpPost]
        public IActionResult Create(EmployeeVM emp)
        {
            var MappedEmp = _mapper.Map<EmployeeVM, Employee>(emp);
            _unitOfWork.EmployeeRepository.Create(MappedEmp);

            return RedirectToAction("Index");
        }


        public IActionResult Update(int id)
        {
            var emp = _unitOfWork.EmployeeRepository.Get(id);
            ViewBag.Departments = _unitOfWork.EmployeeRepository.GetAll();
            return View(emp);
        }

        [HttpPost]
        public IActionResult Update(EmployeeVM emp)
        {
            if (ModelState.IsValid)
            {
                var MappedEmp = _mapper.Map<EmployeeVM, Employee>(emp);
                _unitOfWork.EmployeeRepository.Update(MappedEmp);
                return RedirectToAction("Index");
            }
            return View(emp);
        }

        public IActionResult Delete(int id)
        {
            var emp = _unitOfWork.EmployeeRepository.Get(id);
            return View(emp);
        }
        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirm(int id)
        {
            var emp = _unitOfWork.EmployeeRepository.Get(id);
            _unitOfWork.EmployeeRepository.Delete(emp);
            return RedirectToAction("Index");
        }

    }
}
