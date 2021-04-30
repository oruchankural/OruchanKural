using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using OruchanKural.Models.Siniflar;


namespace OruchanKural.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        Context c = new Context();
        public ActionResult Index()
        {
            var deger = c.Kullanicis.ToList();
            return View(deger);
        }
        [HttpGet]
        public ActionResult Login ()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(Kullanici ad)
        {
            var bilgiler = c.Kullanicis.FirstOrDefault(x => x.Email == ad.Email && x.Password == ad.Password);
            if(bilgiler !=null)
            {
                FormsAuthentication.SetAuthCookie(bilgiler.Email, false);
                Session["Email"] = bilgiler.Email.ToString();
                return RedirectToAction("Index", "Uye");
            }
            else
            {
                return View();
            }
        }
    }
}