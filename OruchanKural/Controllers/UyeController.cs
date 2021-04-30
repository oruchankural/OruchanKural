using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OruchanKural.Models.Siniflar;

namespace OruchanKural.Controllers
{
    public class UyeController : Controller
    {
        // GET: Uye
        Context c = new Context();
        [Authorize]
        public ActionResult Index()

        {
            var values = c.Kullanicis.ToList();
            return View(values);
        }
    }
}