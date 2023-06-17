using Microsoft.AspNetCore.Mvc;
using MvcHadi.Models;
namespace MvcHadi.Controllers
{
    public class OgrenciIslemleriController:Controller
    {
        [HttpGet]
        public IActionResult Kayit()
        {
          
          return View();
        }
        [HttpPost]
        public IActionResult Kayit(Ogrenci ogrenci)
        {
          if(ModelState.IsValid){
            OkulDbContext okulDbContext=new OkulDbContext();
            okulDbContext.SaveChanges();
            okulDbContext.Add(ogrenci);
            return View("BasariliKayit",ogrenci);

          }
          else{
            return View(ogrenci);
          }
        }
    }
}