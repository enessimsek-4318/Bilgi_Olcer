using Bilgi_Olcer.Identity;
using Bilgi_Olcer.Models;
using Bilgi_Olcer_BLL.Absract;
using Entities;
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
            int correct = 0;

            int incorrect = 0;

            int empty = 0;
            
            if (model.Option == model.Answer)
            {
                correct++;
            }
            else if (model.Option == null)
            {
                empty++;
            }
            else
            {
                incorrect++;
            }
            if (model.QuestionNumber<=model.Index+1)
            {
                return RedirectToAction("Result", new {correct=correct, incorrect=incorrect, empty=empty});
                
            }
            return RedirectToAction("Test",new {index=model.Index+1,data=model.Subject});
           
             
        }
        [HttpGet]
        public IActionResult Result(int correct, int incorrect, int empty)
        {
            if (correct==null || incorrect==null || empty==null)
            {
                // viewbag içerisinden gelen veri ekrana basılacak.
            }
            //var user = _userManager.FindByIdAsync(model.userId);

          //  Name = User.Identity.Name;
          return View();
        }
        [HttpPost]
        public IActionResult Result(int id)
        {
            return View();
        }

    }
}
