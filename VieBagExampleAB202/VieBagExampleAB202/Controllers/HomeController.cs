using Microsoft.AspNetCore.Mvc;
using VieBagExampleAB202.Models;

namespace VieBagExampleAB202.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {

            List<Student> students = new List<Student>();
            students.Add(new Student { Id=1,Name="Fidan",Surname="Behbudova",Age=32});
            students.Add(new Student { Id=2,Name="Nubar",Surname="Abudova",Age=19});
            students.Add(new Student { Id=3,Name="Elbrus",Surname="Mirzayev",Age=19});
            students.Add(new Student { Id=4,Name="Amin",Surname="Pashayev",Age=19});

            //ViewBag.Students=students;

            //ViewData["Students"]=students;

            //TempData["Name"] = students;


            return View(students);
        }
        public IActionResult Detail()
        {
            string name = TempData["Name"].ToString();
            TempData.Keep("Name");


            return Content(name);
        }

        public IActionResult About()
        {
            //string name = TempData["Name"].ToString();
            //Console.WriteLine(name);

            return View();

            //string name = TempData["Name"].ToString();
            //TempData.Keep("Name");


            //return Content(name);
        }
        
    }
}
