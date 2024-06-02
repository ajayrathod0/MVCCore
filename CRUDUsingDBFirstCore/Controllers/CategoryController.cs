using CRUDUsingDBFirstCore.Models;
using Microsoft.AspNetCore.Mvc;

namespace CRUDUsingDBFirstCore.Controllers
{
    public class CategoryController : Controller
    {
        CategoryDBContext _db;

        public CategoryController(CategoryDBContext db)
        {
            _db = db;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var category = _db.Categories.ToList();
            return View(category);

        }

        [HttpGet]
        public IActionResult Details(int? id)
        {
            var category = _db.Categories.Find(id);
            return View(category);
        }

        [HttpGet]
        public IActionResult Edit(int? Id)
        {
            var category = _db.Categories.Find(Id);
            return View(category);
        }


        [HttpPost]
        public IActionResult Edit(Category category)
        {
            var DBCategory = _db.Categories.Find(category.Id);
            if (ModelState.IsValid)
            {
                DBCategory.Name = category.Name;
                DBCategory.SellerName = category.SellerName;

                _db.SaveChanges();

                return RedirectToAction("Index");
            }
            return View(category);
        }

        [HttpGet]
        public IActionResult Create()
        {

            return View();
        }

        [HttpPost]
        public IActionResult Create(Category category)
        {
            if (category != null)
            {
                _db.Categories.Add(category);
                _db.SaveChanges();

                return RedirectToAction("Index");
            }
            return View(category);
        }

        [HttpGet]
        public IActionResult Delete(int? id)
        {
            var category = _db.Categories.Find(id);
            return View(category);
        }

        [HttpPost]
        [ActionName("Delete")]
        public IActionResult ConfirmDelete(int? Id)
        {
            var category = _db.Categories.Find(Id);
            _db.Categories.Remove(category);
            _db.SaveChanges();
            
            return RedirectToAction("Index");
        }

    }
}
