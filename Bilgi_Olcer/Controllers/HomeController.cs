using Microsoft.AspNetCore.Mvc;

namespace Bilgi_Olcer.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
