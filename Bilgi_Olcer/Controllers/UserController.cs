using Bilgi_Olcer.EmailServices;
using Bilgi_Olcer.Extensions;
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
        public async Task<IActionResult> Login(LoginModel model)
        {
            var user = await _userManager.FindByEmailAsync(model.Email);
            if (user != null)
            {
                if (await _userManager.IsEmailConfirmedAsync(user))
                {
                    var result = await _signInManager.PasswordSignInAsync(user, model.Password, true, false);
                    if (result.Succeeded)
                    {
                        return RedirectToAction("Index", "Home");
                    }
                    else
                    {
                        TempData.Put("message", new ResultMessage()
                        {
                            Title = "Kullanıcı İşlemleri",
                            Message = "Email veya Şifreniz Yanlış",
                            Css = "danger"
                        });
                        return View();
                    }
                }
                else
                {
                    TempData.Put("message", new ResultMessage()
                    {
                        Title = "Hesap Aktivasyonu",
                        Message = "Email adresinize gelen link ile hesabınızı onaylayınız",
                        Css = "warning"
                    });
                    return View(model);
                }
            }
            else
            {
                TempData.Put("message", new ResultMessage()
                {
                    Title = "Kullanıcı İşlemleri",
                    Message = "Kayıtlı Kullanıcı Bulunamadı",
                    Css = "danger"
                });
                return View(model);
            }
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
                var token = await _userManager.GenerateEmailConfirmationTokenAsync(user);


                var confirmationLink = Url.Action("ConfirmEmail", "User", new
                {
                    userId = user.Id,
                    token = token
                });

                //send email
                string siteUrl = "https://localhost:7281";
                string activateUrl = $"{siteUrl}{confirmationLink}";
                string body = $"Merhaba {model.UserName};<br><br>Hesabınızı aktifleştirmek için <a href='{activateUrl}' target='_blank'> tıklayınız</a>.";

                MailHelper.SendEmail(body, model.Email, "Bilgi Ölçer User Activition");

                TempData.Put("message", new ResultMessage()
                {
                    Title = "Hesap Onayı",
                    Message = "Email adresinize gelen link ile hesabınızı onaylayınız",
                    Css = "warning"
                });
                return RedirectToAction("Login", "User");

            }
            ModelState.AddModelError("", "Kayıt Esnasında Bilinmeyen Bir Hata Oluştu!!");
            return View(model);
        }
        public IActionResult ForgotPassword()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> ForgotPassword(string email)
        {
            if (string.IsNullOrEmpty(email))
            {
                TempData.Put("message", new ResultMessage()
                {
                    Title = "Forgot Password",
                    Message = "Bilgileriniz Hatalıdır.",
                    Css = "danger"
                });
                return View();
            }
            var user = await _userManager.FindByEmailAsync(email);
            if (user != null)
            {
                var code = _userManager.GeneratePasswordResetTokenAsync(user);
                var resetUrl = Url.Action("ResetPassword", "User", new
                {
                    token = code
                });
                string siteUrl = "https://localhost:7281";
                string body = $"Merhabalar, Parolanızı Yenilemek için  <a href='{siteUrl}{resetUrl}'> tıklayınız</a>.";

                MailHelper.SendEmail(body, email, "Bilgi Ölçer Password Reset");
                TempData.Put("message", new ResultMessage()
                {
                    Title = "Forgot Password",
                    Message = "Parola Yenilemek İçin Hesabınıza Email Gönderilmiştir.",
                    Css = "warning"
                });
                return RedirectToAction("Login", "User");
            }
            else
            {
                TempData.Put("message", new ResultMessage()
                {
                    Title = "Forgot Password",
                    Message = "Belirtmiş Olduğunuz Email Adresine Tanımlı Kullanıcı Bulunamadı.",
                    Css = "danger"
                });
                return View();
            }            
        }
        public async Task<IActionResult> ConfirmEmail(string userId, string token)
        {
            if (userId == null || token == null)
            {
                TempData.Put("message", new ResultMessage()
                {
                    Title = "Hesap Onayı",
                    Message = "Hesap Onayı İçin Bilgileriniz Yanlıştır.",
                    Css = "danger"
                });
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
            TempData.Put("message", new ResultMessage()
            {
                Title = "Hesap Onayı",
                Message = "Üzgünüz Hesabınızın Aktivasyonu Gerçekleştirilemedi.",
                Css = "danger"
            });
            return View();
        }
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }
    }
}
