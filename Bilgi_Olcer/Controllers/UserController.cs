using Bilgi_Olcer.EmailServices;
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
                //generate token
                var code = await _userManager.GenerateEmailConfirmationTokenAsync(user);

                var callbackUrl = Url.Action("ConfirmEmail", "User", new
                {
                    userId = user.Id,
                    token = code
                });

                //send email
                string siteUrl = "https://localhost:7281";
                string activateUrl = $"{siteUrl}{callbackUrl}";
                string body = $"Merhaba {model.UserName};<br><br>Hesabınızı aktifleştirmek için <a href='{activateUrl}' target='_blank'> tıklayınız</a>.";

                MailHelper.SendEmail(body, model.Email, "Bilgi Ölçer User Activition");

                //TempData.Put("message", new ResultMessage()
                //{
                //    Title = "Hesap Onayı",
                //    Message = "Email adresinize gelen link ile hesabınızı onaylayınız",
                //    Css = "warning"
                //});
                return RedirectToAction("Login", "User");

            }
            ModelState.AddModelError("", "Kayıt Esnasında Bilinmeyen Bir Hata Oluştu!!");
            return View(model);
        }
        public IActionResult ForgotPassword()
        {
            return View();
        }
        public async Task<IActionResult> ConfirmEmail(string userId, string token)
        {
            if (userId == null || token == null)
            {
                //TempData.Put("message", new ResultMessage()
                //{
                //    Title = "Hesap Onayı",
                //    Message = "Hesap Onayı İçin Bilgileriniz Yanlıştır.",
                //    Css = "danger"
                //});
                return Redirect("~/");
            }
            var user = await _userManager.FindByIdAsync(userId);
            if (user != null)
            {
                var result = await _userManager.ConfirmEmailAsync(user, token);
                if (result.Succeeded)
                {
                    //_cartService.InitializeCart(user.Id);
                    //TempData.Put("message", new ResultMessage()
                    //{
                    //    Title = "Hesap Onayı",
                    //    Message = $"Hoşgeldiniz Sayın {user.FullName}, Hesabınız Onaylanmıştır.",
                    //    Css = "success"
                    //});
                    return RedirectToAction("Login", "User");
                }
            }
            //TempData.Put("message", new ResultMessage()
            //{
            //    Title = "Hesap Onayı",
            //    Message = "Üzgünüz Hesabınızın Aktivasyonu Gerçekleştirilemedi.",
            //    Css = "danger"
            //});
            return View();
        }
    }
}
