using Bilgi_Olcer.Models;
using Bilgi_Olcer_BLL.Absract;
using Entities;
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
            
            return View(subject);
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

            return RedirectToAction("Test",new {index=model.Index+1,data=model.Subject});
        }

    }
}
