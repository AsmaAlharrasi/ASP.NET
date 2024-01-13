using Bulky.Data;
using Bulky.Models;
using Microsoft.AspNetCore.Mvc;

namespace Bulky.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ApplicationDbContext _context;
        public CategoryController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var catg = _context.Categories.ToList();
            return View(catg);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Category item)
        {
            if (item.Name == item.DisplayOrder.ToString()) //client side validation
            {
                ModelState.AddModelError("name", "The Display Order cannot exactly match the Name.");
            }
            if (ModelState.IsValid) //server side validation
            {
            _context.Categories.Add(item);
            _context.SaveChanges();
                TempData["Sucsess"] = "Category Created Successfully";
            return RedirectToAction("Index");
            }
            return View();
        }

        public IActionResult Update(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            var catg = _context.Categories.Find(id);

            if (catg == null)
            {
                return NotFound();
            }
            return View(catg);
        }

        [HttpPost]
        public IActionResult Update(Category item)
        {
            
            if (ModelState.IsValid) //server side validation
            {
                _context.Categories.Update(item);
                _context.SaveChanges();
                TempData["Sucsess"] = "Category Updated Successfully";

                return RedirectToAction("Index");
            }
            return View();
        }

        public IActionResult Delete(int id)
        {
            if ( id == null || id == 0)
            {
                return NotFound();
            }
            Category? catg = _context.Categories.Find(id);
            if(catg == null)
            {
                return NotFound();
            }
            return View(catg);
        }

        [HttpPost , ActionName("Delete")]
        public IActionResult DeletePost(int? id)
        {
            var catg = _context.Categories.Find(id);
            if(catg == null)
            {
                return NotFound();
            }
            _context.Categories.Remove(catg);
            _context.SaveChanges();
            TempData["Sucsess"] = "Category Deleted Successfully";
            return RedirectToAction("Index");
        }
    }
}
