using Microsoft.AspNetCore.Mvc;

namespace intro.Controllers
{
    public class AboutController : Controller
    {
        public string Index()
        {
            return "Home About";
        }

        public IActionResult Create()
        {
            // return View();
            // return RedirectToAction("Index");
            return RedirectToAction(nameof(Index), "Products");
        }
    }
}