using Bilgi_Olcer.Identity;
using Bilgi_Olcer.Models;
using Microsoft.AspNetCore.Mvc;

namespace Bilgi_Olcer.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(LoginModel entity)
        {
            return View();
        }
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Register(User entity)
        {
            return View();
        }
        public IActionResult ForgotPassword()
        {
            return View();
        }
    }
}
