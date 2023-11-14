using Microsoft.AspNetCore.Mvc;

namespace MVCFirst.Controllers
{
    public class CorporativeSalesController : Controller
    {

        [Route("korporativ-satislar")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
