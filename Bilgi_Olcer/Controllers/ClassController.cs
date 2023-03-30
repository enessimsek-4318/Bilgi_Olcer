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
            
            return View(classes);
        }
        public IActionResult Subject(ClassModel model)
        {
            //Id ile seçilen dersi yakalıyorum bundan sonra database üzerinden gidip ilgili ders hakkında konuları
            // listelemem gereklidir.

            return View(model.Name);
        }
    }
}
