using Microsoft.AspNetCore.Mvc;

namespace Bilgi_Olcer.Controllers
{
    public class ProfileController : Controller
    {
        public IActionResult Dashboard()
        {
            return View();
        }
    }
}
