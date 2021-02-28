using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BlogSitem.Models.Sınıf;

namespace BlogSitem.Controllers
{
    public class HakkımdaController : Controller
    {
        // GET: Hakkımda
        Context c = new Context();
        public ActionResult Index()
        {
            return View();
        }
    }
}