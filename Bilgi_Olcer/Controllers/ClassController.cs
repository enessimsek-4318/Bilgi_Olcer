using Bilgi_Olcer.Models;
using Microsoft.AspNetCore.Mvc;

namespace Bilgi_Olcer.Controllers
{
    public class ClassController : Controller
    {
        public IActionResult Index()
        {
            List<ClassModel> classes = new List<ClassModel>()
            {
                new ClassModel(){Name="Matematik"},
                new ClassModel(){Name="Kimya"},
                new ClassModel(){Name="Biyoloji"},
                new ClassModel(){Name="Fizik"},
                new ClassModel(){Name="Türk Edebiyatı"},
                new ClassModel(){Name="Coğrafya"},
                new ClassModel(){Name="Tarih"}
            };
            
            return View(classes);
        }
    }
}
