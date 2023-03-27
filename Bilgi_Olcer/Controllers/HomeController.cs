using Microsoft.AspNetCore.Mvc;

namespace Bilgi_Olcer.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Contact()
        {
            return View();
        }
        public IActionResult About()
        {
            return View();
        }
        public IActionResult Grade()
        {
            return View();
        }


    }
}
