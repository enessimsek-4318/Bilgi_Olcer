using Bilgi_Olcer.Models;
using Microsoft.AspNetCore.Mvc;

namespace Bilgi_Olcer.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            List<ClassModel> Classes = new List<ClassModel>()
            {
                new ClassModel(){Id=9,Name="9.Sınıf"},
                new ClassModel(){Id=10,Name="10.Sınıf"},
                new ClassModel(){Id=11,Name="11.Sınıf"},
                new ClassModel(){Id=12,Name="12.Sınıf"},
            };
            return View(Classes);
        }
        public IActionResult Contact()
        {
            return View();
        }
        public IActionResult About()
        {
            return View();
        }
        public IActionResult Grade(ClassModel model)
        {
            
            return View(model);
        }


    }
}
