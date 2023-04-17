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

            int fault = 0;

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
                fault++;
            }
            if (model.QuestionNumber<=model.Index+1)
            {
                return RedirectToAction("Result");
                //Bu kısımda test yölendirilirken doğru yanlış sayılarıda eklenebilir.
            }
            return RedirectToAction("Test",new {index=model.Index+1,data=model.Subject});
           
            // 1 - sayfa görünümü düzenlenecek.
            // 2 - modelden gelecek cevaplara göre soruların doğru yanlış cevapları kontrol edilecek.
            // 3 - doğru yanlış ve boş sayılarını tutan bir değişken oluşturucağım.
            // 4 - Tutmuş olduğumuz bu verileri kullanıcının id si ile birlikte kaç doğru kaç yanlış hangi ders hangi konu bu gibi 
            // bilgiler ile birlikte database kaydedeceğiz.
            // 5 - Test ekranı için farklı bir layout kullanacağız. ekranda soru geçişleri ile değişmeyecek kısımlar burada tutulacaktır.
        }
        [HttpGet]
        public IActionResult Result()
        {
          return View();
        }
        [HttpPost]
        public IActionResult Result(int id)
        {
            return View();
        }

    }
}
