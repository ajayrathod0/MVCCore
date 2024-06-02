using CRUDUsingDBCodeFirstCore.Models;
using CRUDUsingDBCodeFirstCore.Models.Entitys;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CRUDUsingDBCodeFirstCore.Controllers
{
    public class ProductController : Controller
    {
        ProductDbContext _db;

        public ProductController(ProductDbContext db)
        {
            _db = db;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var category = _db.Products.ToList();
            return View(category);

        }

        [HttpGet]
        public IActionResult Details(int? id)
        {
            var category = _db.Products.Find(id);
            return View(category);
        }

        [HttpGet]
        public IActionResult Edit(int? Id)
        {
            var category = _db.Products.Find(Id);
            return View(category);
        }


        [HttpPost]
        public IActionResult Edit(Product product)
        {
            var DBProduct = _db.Products.Find(product.ProductId);

            if (ModelState.IsValid)
            {
                DBProduct.ProductName = product.ProductName;
                DBProduct.Price  = product.Price;

                _db.SaveChanges();

                return RedirectToAction("Index");
            }
            return View(product);
        }

        [HttpGet]
        public IActionResult Create()
        {

            return View();
        }

        [HttpPost]
        public IActionResult Create(Product product)
        {
            if (product != null)
            {
                _db.Products.Add(product);
                _db.SaveChanges();

                return RedirectToAction("Index");
            }
            return View(product);
        }

        [HttpGet]
        public IActionResult Delete(int? id)
        {
            var category = _db.Products.Find(id);
            return View(category);
        }

        [HttpPost]
        [ActionName("Delete")]
        public IActionResult ConfirmDelete(int? Id)
        {
            var product = _db.Products.Find(Id);
            _db.Products.Remove(product);
            _db.SaveChanges();

            return RedirectToAction("Index");
        }

    }
}
