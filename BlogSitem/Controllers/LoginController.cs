using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using BlogSitem.Models.Sınıf;

namespace BlogSitem.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        Context c = new Context();
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(Admin a)
        {
            var bilgi = c.admins.FirstOrDefault(x => x.KullanıcıAdı == a.KullanıcıAdı &&
              x.Sifre == a.Sifre);
            if (bilgi != null)
            {
                FormsAuthentication.SetAuthCookie(bilgi.KullanıcıAdı, false);
                Session["KullanıcıAdı"] = bilgi.KullanıcıAdı.ToString();
                return RedirectToAction("Index", "Admin");
            }
            else
            {
                return View();
            }
        }
    }
}