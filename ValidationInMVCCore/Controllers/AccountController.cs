using Microsoft.AspNetCore.Mvc;
using ValidationInMVCCore.Models;
using ValidationInMVCCore.Models.Entitys;


namespace ValidationInMVCCore.Controllers
{
    public class AccountController : Controller
    {
        UserDBContext _db;

        public AccountController(UserDBContext db)
        {
            _db = db;
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(UserModel user)
        {
            if (ModelState.IsValid)
            {
                string encryptedPassword =
                      BCrypt.Net.BCrypt.HashPassword(user.Password);

                User u = new User()
                {
                    FirstName = user.FirstName,
                    LastName = user.LastName,
                    Password = encryptedPassword,
                    DateOfBirth = user.DateOfBirth,
                };

                _db.Users.Add(u);
                _db.SaveChanges();
                return RedirectToAction("Success");
            }
            return View(user);
        }


        [HttpGet]
        public IActionResult Success()
        {

            return View();
        }

    }
}
