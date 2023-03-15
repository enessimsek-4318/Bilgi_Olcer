using Bilgi_Olcer.Identity;
using Bilgi_Olcer.Models;
using Microsoft.AspNetCore.Cors.Infrastructure;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Bilgi_Olcer.Controllers
{
    public class UserController : Controller
    {
        private UserManager<User> _userManager;
        private SignInManager<User> _signInManager;
        
        public UserController(UserManager<User> userManager, SignInManager<User> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            
        }
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(LoginModel model)
        {
            return View();
        }
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Register(RegisterModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            var user = new User()
            {
                FullName = model.FullName,
                Email = model.Email,
                UserName = model.UserName,
                PhoneNumber = model.PhoneNumber
            };
            var result = await _userManager.CreateAsync(user, model.Password);
            if (result.Succeeded)
            {
                ////generate token
                //var code = await _userManager.GenerateEmailConfirmationTokenAsync(user);

                //var callbackUrl = Url.Action("ConfirmEmail", "Account", new
                //{
                //    userId = user.Id,
                //    token = code
                //});

                ////send email
                //string siteUrl = "https://localhost:7232";
                //string activateUrl = $"{siteUrl}{callbackUrl}";
                //string body = $"Merhaba {model.UserName};<br><br>Hesabınızı aktifleştirmek için <a href='{activateUrl}' target='_blank'> tıklayınız</a>.";

                //MailHelper.SendEmail(body, model.Email, "Marka User Activition");

                //TempData.Put("message", new ResultMessage()
                //{
                //    Title = "Hesap Onayı",
                //    Message = "Email adresinize gelen link ile hesabınızı onaylayınız",
                //    Css = "warning"
                //});
                //return RedirectToAction("login", "account");

            }
            ModelState.AddModelError("", "Kayıt Esnasında Bilinmeyen Bir Hata Oluştu!!");
            return View(model);
        }
        public IActionResult ForgotPassword()
        {
            return View();
        }
    }
}
