using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BlogSitem.Models.Sınıf;

namespace BlogSitem.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        Context c = new Context();
        Anasf a = new Anasf();
        public ActionResult Index()
        {
            a.deger1 = c.blogs.OrderByDescending(x => x.Id).Take(3).ToList();
            a.deger2 = c.kategorilers.Take(5).ToList();
            a.deger3 = c.kategorilers.OrderByDescending(x => x.Id).Take(5).ToList();
            return View(a);
        }
        public PartialViewResult p1()
        {
            var hak = c.hakkımdas.ToList();
            return PartialView(hak);
        }
        public ActionResult BlogDetay(int id)
        {
            var blg = c.blogs.Where(x => x.Id == id).ToList();
            return View(blg);
        }
    }
}