using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OruchanKural.Models.Siniflar;

namespace OruchanKural.Controllers
{
    public class RegisterController : Controller
    {
        // GET: Register
        Context c = new Context();
        public ActionResult Index()
        {
            var degeler = c.Kullanicis.ToList();
            return View();
        }
        [HttpGet]
        public ActionResult Kayit()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Kayit(Kullanici p)
        {
            c.Kullanicis.Add(p);
            c.SaveChanges();
            return View();
        }
    }
}