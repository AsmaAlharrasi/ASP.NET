using AutoMapper;
using CodeAcademy.BLL.Interface;
using CodeAcademy.BLL.Repository;
using CodeAcademy.DAL.Models;
using CodeAcademy.PL.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.Intrinsics.Arm;

namespace CodeAcademy.PL.Controllers
{
    public class DepartmentController : Controller
    {
        //    private readonly IDepartmentRepository _departmentRepo;

        //    public DepartmentController(IDepartmentRepository departmentrepo)
        //    {

        //        _departmentRepo = departmentrepo;
        //    }

        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public DepartmentController(IUnitOfWork unitOfWork , IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public IActionResult Index()
        {

            
            //ViewBag.massage = "Hello from Action";
            //ViewData["msg"] = "Hello from ViewData";
            var deps = _unitOfWork.DepartmentRepository.GetAll();
            return View(deps);
        }
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return BadRequest();
            }
            var dep = _unitOfWork.DepartmentRepository.Get(id.Value);
            return View(dep);

        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(DepartmentVM dep)
        {

            if (ModelState.IsValid)
            {
                var MappedDep = _mapper.Map<DepartmentVM, Department>(dep);
                _unitOfWork.DepartmentRepository.Create(MappedDep);
                TempData["success"] = "Added Successfully";
                return RedirectToAction("Index");
            }
            return View();
        }


        public IActionResult Update(int id)
        {
            var dep = _unitOfWork.DepartmentRepository.Get(id);
            return View(dep);
        }

        [HttpPost]
        public IActionResult Update(DepartmentVM dep)
        {
            if (ModelState.IsValid)
            {
                var MappedDep = _mapper.Map<DepartmentVM, Department>(dep);
                _unitOfWork.DepartmentRepository.Update(MappedDep);
                return RedirectToAction("Index");
            }
            return View(dep);
        }

        public ActionResult Delete(int id)
        {
            var dep = _unitOfWork.DepartmentRepository.Get(id);
            _unitOfWork.DepartmentRepository.Delete(dep);
            return RedirectToAction("Index");
        }
    }
}
