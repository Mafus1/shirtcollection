using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Shirtcollection.Controllers
{
    public class HomeController : Controller
    {
        [Route("sommer.html")]
        public ActionResult Sommer()
        {
            return View();
        }

        [Route("herbst.html")]
        public ActionResult Herbst()
        {
            return View();
        }

        [Route("fruehling.html")]
        public ActionResult Fruehling()
        {
            return View();
        }

        [Route("winter.html")]
        public ActionResult Winter()
        {
            return View();
        }

        [Route("kontakt.html")]
        public ActionResult Kontakt()
        {
            return View();
        }
    }
}