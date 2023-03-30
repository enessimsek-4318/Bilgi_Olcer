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
                new ClassModel(){Id=9,Name="9.Sınıf",PhotoUrl="~/img/9-Sinif.jpg"},
                new ClassModel(){Id=10,Name="10.Sınıf",PhotoUrl="~/img/10-Sinif.jpg"},
                new ClassModel(){Id=11,Name="11.Sınıf",PhotoUrl="~/img/11-Sinif.jpg"},
                new ClassModel(){Id=12,Name="12.Sınıf",PhotoUrl="~/img/12-Sinif.jpg"},

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
        public IActionResult Grade()
        {
            
            return View();
        }


    }
}
