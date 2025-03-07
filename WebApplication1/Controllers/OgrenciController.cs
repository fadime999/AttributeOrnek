using DefinexAttributeOrnek;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;
using DefinexAttributeOrnek;

namespace WebApplication1.Controllers
{
    public class OgrenciController : Controller
    {
        // GET: Ogrenci - Boş formu kullanıcıya gösterir
        public ActionResult Index()
        {
            return View(new OgrenciModel());
        }
        // POST: Ogrenci - Formdan gelen veriyi işler
        [HttpPost]
        public ActionResult Index(OgrenciModel model)
        {
            // MVC'nin kendi doğrulama mekanizmasını kullanıyoruz
            if (!ModelState.IsValid)
            {
                ViewBag.Message = "Lütfen tüm alanları eksiksiz doldurun!";
                return View(model);
            }

            // Ek olarak ZorunluAlanAttribute ile manuel doğrulama yapıyoruz
            if (!ZorunluAlanAttribute.Dogrula(model))
            {
                ViewBag.Message = "Zorunlu alanlar eksik!";
                return View(model);
            }

            // Eğer doğrulama başarılıysa, başarılı mesajını ViewBag içine at
            ViewBag.Message = "Öğrenci başarıyla kaydedildi.";
            return View(model);
        }
    }
}
