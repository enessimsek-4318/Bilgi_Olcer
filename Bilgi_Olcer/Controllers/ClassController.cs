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
            List<Question> subject=_questionService.GetAllSubject(model.Id);

            List<ClassModel> classes = new List<ClassModel>()
            {
                new ClassModel(){Id=1,Name="Matematik"},
                new ClassModel(){Id=2,Name="Kimya"},
                new ClassModel(){Id=3,Name="Biyoloji"},
                new ClassModel(){Id=4,Name="Fizik"},
                new ClassModel(){Id=5,Name="Türk Edebiyatı"},
                new ClassModel(){Id=6,Name="Coğrafya"},
                new ClassModel(){Id=7,Name="Tarih"},
                new ClassModel(){Id=8,Name="Din Kültürü ve Ahlak Bilgisi"},
                new ClassModel(){Id=9,Name="Felsefe"}
            };
            
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

 
    }
}
