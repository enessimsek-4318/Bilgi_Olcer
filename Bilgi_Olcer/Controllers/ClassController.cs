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
            // Varsayılan değerleri ayarlayın
            //HttpContext.Session.SetInt32("correct", 0);
            //HttpContext.Session.SetInt32("incorrect", 0);
            //HttpContext.Session.SetInt32("empty", 0);

            if (model.Option == model.Answer)
            {
                // Doğru cevap sayısını artırın
                //var correct = HttpContext.Session.GetInt32("correct") ?? 0;
                //HttpContext.Session.SetInt32("correct", correct + 1);
            }
            else if (model.Option == null)
            {
                // Boş cevap sayısını artırın
                //var empty = HttpContext.Session.GetInt32("empty") ?? 0;
                //HttpContext.Session.SetInt32("empty", empty + 1);
            }
            else
            {
                // Yanlış cevap sayısını artırın
                //var incorrect = HttpContext.Session.GetInt32("incorrect") ?? 0;
                //HttpContext.Session.SetInt32("incorrect", incorrect + 1);
            }

            if (model.QuestionNumber <= model.Index + 1)
            {
                // Test tamamlandıysa, sonuçları görüntülemek için Result metoduna yönlendirin
                return RedirectToAction("Result");
            }

            // Bir sonraki soruya yönlendirin
            return RedirectToAction("Test", new { index = model.Index + 1, data = model.Subject });
        }

        [HttpGet]
        public IActionResult Result()
        {
            // HttpContext.Session'dan doğru, yanlış ve boş cevap sayılarını alın
            var correct = HttpContext.Session.GetInt32("correct") ?? 0;
            var incorrect = HttpContext.Session.GetInt32("incorrect") ?? 0;
            var empty = HttpContext.Session.GetInt32("empty") ?? 0;

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
