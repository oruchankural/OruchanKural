using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OruchanKural.Models.Siniflar;

namespace OruchanKural.Controllers
{
    public class AdmintController : Controller
    {
        // GET: Admint
        Context c = new Context();
        public ActionResult Index()
        {
            var degerler = c.Kullanicis.ToList();
            return View();
        }
    }
}