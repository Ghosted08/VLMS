using Microsoft.AspNetCore.Mvc;
using VLMS.Models;

namespace VLMS.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                // Authentication logic here
                return RedirectToAction("Index", "Home");
            }

            return View(model);
        }

        public IActionResult Register()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }
    }
}
