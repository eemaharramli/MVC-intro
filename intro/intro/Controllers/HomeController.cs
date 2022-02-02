using Microsoft.AspNetCore.Mvc;

namespace intro.Controllers
{
    public class HomeController : Controller
    {
        public string Index()
        {
            return "Home Index";
        }

        public string Create()
        {
            return "Home Create";
        }

        public string Detail(int? id)
        {
            return $"Student number {id}";
        }

        public ViewResult Update()
        {
            var viewResult = new ViewResult();
            viewResult.ViewName = "Update";

            return viewResult;
        }

        public ViewResult Delete()
        {
            var viewResult = new ViewResult();
            viewResult.ViewName = "Delete";
            return viewResult;
        }
    }
}