using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SRR.UI.MVC4.Models;

namespace SRR.UI.MVC4.Controllers
{
    public class BabyController : Controller
    {
        //
        // GET: /Baby/

        public ActionResult Index()
        {
            return View(new List<MyModelBaby>());
        }


        
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        public ActionResult Create(MyModelBaby baby)
        {
            return View();
        }

        
        ////[ValidateAntiForgeryToken]
        //public ActionResult Create(MyModelBaby baby)
        //{
        //    return View();
        //}
    }
}
