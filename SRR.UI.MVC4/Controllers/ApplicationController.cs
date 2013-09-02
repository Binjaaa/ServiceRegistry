using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SRR.UI.MVC4.Controllers
{
    public class ApplicationController : Controller
    {
        //
        // GET: /Application/

        public ActionResult Index()
        {
            string g = "";

            return View();
        }

        public ActionResult Apps()
        {
            ViewBag.valami = "ohhh apps! Stop it! :)";

            return View();
        }

    }
}
