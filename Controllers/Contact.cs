using Microsoft.AspNetCore.Mvc;

namespace VLMS.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
