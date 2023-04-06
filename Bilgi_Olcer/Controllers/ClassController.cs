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
            switch (model.Id)
            {
                case 1:
                    //_questionService.GetAll();
                    // code block
                    break;
                case 2:
                    // code block
                    break;
                case 3:
                    // code block
                    break;
                case 4:
                    // code block
                    break;
                case 5:
                    // code block
                    break;
                case 6:
                    // code block
                    break;
                case 7:
                    // code block
                    break;
                case 8:
                    // code block
                    break;
                case 9:
                    // code block
                    break;
                default:
                    // code block
                    break;
            }

            return View();
        }
        [HttpGet]
        public IActionResult Test()
        {
            // Seçilen Konuya uygun olarak gelen soruları QestionModel oluşturup uygun olarak ekrana taşımamız gereklidir.
            return View();
        }
        //[HttpPost]
        //public IActionResult Test()
        //{
        //    return View();
        //}

    }
}
