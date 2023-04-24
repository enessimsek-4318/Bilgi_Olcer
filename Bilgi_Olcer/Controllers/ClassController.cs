using Bilgi_Olcer.Identity;
using Bilgi_Olcer.Models;
using Bilgi_Olcer_BLL.Absract;
using Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Components.Server.ProtectedBrowserStorage;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Linq.Expressions;

namespace Bilgi_Olcer.Controllers
{
    public class ClassController : Controller
    {
        private IQuestionService _questionService;
        private IResultService _resultService;
        private UserManager<User> _userManager;
        public ClassController(IQuestionService questionService, IResultService resultService, UserManager<User> userManager)
        {
            _questionService = questionService;
            _resultService = resultService;
            _userManager = userManager;
        }

        public IActionResult Index(GradeModel model)
        {
            List<Question> subject=_questionService.GetSubject(model.Id);
            List<Question> distinctList = subject.GroupBy(q => q.Subject).Select(g => g.First()).ToList();
            return View(distinctList);
        }
        [HttpGet]
        public IActionResult Subject(ClassModel model)
        {
            

            return View();
        }
        [Authorize]
        [HttpGet]
        public IActionResult Test(int? index,string data)
        {            
            List<Question> questions = _questionService.GetQuestion(data);           
            TestModel model = new TestModel();
            model.Questions = questions;
            if (index==null)
            {
                ViewBag.Index = 0;
            }
            else
            {
                ViewBag.Index = index;
            }                 
            return View(model);            
        }
        [HttpPost]
        public IActionResult Test(TestModel model)
        {
            if (Request.Cookies["correct"]==null)
            {
                Response.Cookies.Append("correct", "0");
                Response.Cookies.Append("incorrect", "0");
                Response.Cookies.Append("empty", "0");
            }
            if (model.Option == model.Answer)
            {
                int correctCount = 0;
                if (Request.Cookies["correct"] != null)
                {
                    int.TryParse(Request.Cookies["correct"], out correctCount);
                }
                correctCount++;
                Response.Cookies.Append("correct", correctCount.ToString());
            }
            else if (model.Option == null)
            {
                int emptyCount = 0;
                if (Request.Cookies["empty"] != null)
                {
                    int.TryParse(Request.Cookies["empty"], out emptyCount);
                }
                emptyCount++;
                Response.Cookies.Append("empty", emptyCount.ToString());
            }
            else
            {
                int incorrectCount = 0;
                if (Request.Cookies["incorrect"] != null)
                {
                    int.TryParse(Request.Cookies["incorrect"], out incorrectCount);
                }
                incorrectCount++;
                Response.Cookies.Append("incorrect", incorrectCount.ToString());
            }
            if (model.QuestionNumber <= model.Index + 1)
            {                
                return RedirectToAction("Result");
            }            
            return RedirectToAction("Test", new { index = model.Index + 1, data = model.Subject });
        }

        [HttpGet]
        public IActionResult Result()
        {         
            ResultModel model = new ResultModel()
            {
                Correct = Convert.ToInt32(Request.Cookies["correct"]),
                Incorrect = Convert.ToInt32(Request.Cookies["incorrect"]),
                Empty = Convert.ToInt32(Request.Cookies["empty"]),
                Name = User.Identity.Name
            };
            var user = GetUserInfo();
            Result entity = new Result()
            {
                userId=user.Result.Id,
                Correct=model.Correct,
                False=model.Incorrect,
                Empty=model.Empty
            };
            _resultService.Save(entity);
            HttpContext.Response.Cookies.Delete("correct");
            HttpContext.Response.Cookies.Delete("incorrect");
            HttpContext.Response.Cookies.Delete("empty");
            return View(model);
        }

        [HttpPost]
        public IActionResult Result(int id)
        {
            return View();
        }

        public async Task<User> GetUserInfo()
        {
            User user = await _userManager.GetUserAsync(User);
            return user;
        }


    }
}
