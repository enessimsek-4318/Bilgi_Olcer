using Bilgi_Olcer.Identity;
using Bilgi_Olcer.Models;
using Bilgi_Olcer_BLL.Absract;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Bilgi_Olcer.Controllers
{
    public class ProfileController : Controller
    {
        private IResultService _resultService;
        private UserManager<User> _userManager;
        public ProfileController(IResultService resultService, UserManager<User> userManager)
        {
            _resultService = resultService;
            _userManager = userManager;
        }

        public IActionResult Dashboard()
        {
            var user = GetUser();
            var results = _resultService.GetResult(user.Result.Id);
            List<ResultModel> model = new List<ResultModel>();            
            ViewData["Name"] = user.Result.FullName;
            foreach (var item in results)
            {
                model.Add(new ResultModel
                {
                    Correct = item.Correct,
                    Incorrect = item.False,
                    Empty = item.Empty,
                    Lesson = item.Lesson,
                    Subject = item.Subject,
                    Date=item.Date,
                    Name=user.Result.FullName
                });
            }
            return View(model);
        }
        public async Task<User> GetUser()
        {
            User user = await _userManager.GetUserAsync(User);
            return user;
        }
    }
}
