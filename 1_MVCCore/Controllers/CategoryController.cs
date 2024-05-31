using _1_MVCCore.Models;
using Microsoft.AspNetCore.Mvc;

namespace _1_MVCCore.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            List<Category> categories = new List<Category>() {
            new Category(){CategoryId =1,CategoryName=" Mens Wear" },
            new Category(){CategoryId =2,CategoryName = "Women Wear"}
            };
            return View(categories);
        }

     
    }
}
