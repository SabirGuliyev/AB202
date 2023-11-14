using Microsoft.AspNetCore.Mvc;

namespace MVCFirst.Controllers
{
    public class ProductController:Controller
    {
        public IActionResult Index()
        {
            return View();
            //return RedirectToAction("Detail");
        }

        public IActionResult Detail()
        {
            return View("Product");
        }
    }
}
