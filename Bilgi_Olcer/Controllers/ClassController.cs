using Bilgi_Olcer.Identity;
using Bilgi_Olcer.Models;
using Bilgi_Olcer_BLL.Absract;
using Entities;
using Microsoft.AspNetCore.Components.Server.ProtectedBrowserStorage;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Linq.Expressions;

namespace Bilgi_Olcer.Controllers
{
    public class ClassController : Controller
    {
        private IQuestionService _questionService;        
        public ClassController(IQuestionService questionService)
        {
            _questionService = questionService;
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
            // HttpContext.Session'dan doğru, yanlış ve boş cevap sayılarını alın
            var correct = Convert.ToInt32(Request.Cookies["correct"]);
            var incorrect = Convert.ToInt32(Request.Cookies["incorrect"]);
            var empty = Convert.ToInt32(Request.Cookies["empty"]);

            ResultModel model = new ResultModel()
            {
                Correct = correct,
                Incorrect = incorrect,
                Empty = empty,
                Name = User.Identity.Name
            };
            return View(model);
        }

        [HttpPost]
        public IActionResult Result(int id)
        {
            return View();
        }


    }
}
