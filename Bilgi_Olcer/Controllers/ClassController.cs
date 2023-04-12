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
        public IActionResult Test(string data)
        {

            // Soruları al
            List<Question> questions = _questionService.GetQuestion(data);

            // TestModel oluştur ve özellikleri ayarla
            TestModel model = new TestModel();
            model.Questions = questions;
            model.Index = 0;

            // İlk soruyu görüntüle
            return View(model);
        }
        [HttpPost]
        public IActionResult Test(TestModel model)
        {
            // Sonraki soruya gitmek için indeksi artır
            model.Questions = _questionService.GetQuestion(model.Subject);
            model.Index++;

          

            // Bir sonraki soruyu görüntüle
            return View(model);
        }

    }
}
