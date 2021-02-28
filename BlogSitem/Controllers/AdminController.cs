using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BlogSitem.Models.Sınıf;

namespace BlogSitem.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        Context c = new Context();
        [Authorize]
        public ActionResult Index()
        {
            var bloglar = c.blogs.ToList();
            return View(bloglar);
        }
        [Authorize]
        [HttpGet]
        public ActionResult YeniBlog()
        {
            return View();
        }
        [Authorize]
        [HttpPost]
        public ActionResult YeniBlog(Blog p)
        {
            c.blogs.Add(p);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        [Authorize]
        public ActionResult BlogSil(int id)
        {
            var sil = c.blogs.Find(id);
            c.blogs.Remove(sil);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        [Authorize]
        public ActionResult BlogGetir(int id)
        {
            var bul = c.blogs.Find(id);
            return View("BlogGetir", bul);
        }
        [Authorize]
        public ActionResult BlogGüncelle(Blog b)
        {
            var blg = c.blogs.Find(b.Id);
            blg.Baslık = b.Baslık;
            blg.BlogImg = b.BlogImg;
            blg.BlogOzet = b.BlogOzet;
            blg.BlogYazı = b.BlogYazı;
            blg.Tarih = b.Tarih;
            c.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}