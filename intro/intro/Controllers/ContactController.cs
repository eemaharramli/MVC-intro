using Microsoft.AspNetCore.Mvc;

namespace intro.Controllers
{
    public class ContactController : Controller
    {
        // GET
        public IActionResult Index(int? id)
        {
            ViewBag.Name = "Elnur";
            ViewBag.Surname = "Maharramli";
            ViewBag.id = id;
            return View();
        }

        public IActionResult Create()
        {
            ViewData["Name"] = "Fuad";
            ViewData["Surname"] = "Aghazadeh";

            return View();
        }

        public IActionResult Update()
        {
            TempData["FuadAge"] = 29;
            return View();
        }
    }
}