using Microsoft.AspNetCore.Mvc;

namespace MVCFirst.Controllers
{
    public class HomeController:Controller
    {
       
            public IActionResult Index()
        {

            return View();
            
            //JsonResult json = new JsonResult(new
            //{
            //    name = "Fidan",
            //    surname = "Behbudova",
            //    age = 30
            //});

            //if (true)
            //{
            //    return View();
            //}

            //return json;


            //return Content("sadsda");




        }

        public IActionResult Detail(int id)
        {
            return View("Product");
        }

    }
}
