using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SRR.UI.MVC4.Models;

namespace SRR.UI.MVC4.Controllers
{
    //public class HomeController : Controller
    //{
    //    public ActionResult Index()
    //    {
    //        ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";

    //        return View();
    //    }

    //    public ActionResult About()
    //    {
    //        ViewBag.Message = "Your app description page.";

    //        return View();
    //    }

    //    public ActionResult Contact()
    //    {
    //        ViewBag.Message = "Your contact page.";

    //        return View();
    //    }


    //}

    public class HomeController : Controller
    {
        // Renders the main form
        public ActionResult Index()
        {

            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";
            var model = new MyViewModel
            {
                Values = new[]
            {
                new SelectListItem { Value = "1", Text = "item 1" },
                new SelectListItem { Value = "2", Text = "item 2" },
                new SelectListItem { Value = "3", Text = "item 3" },
            }
            };
            return View(model);
        }

        // Processes the submission of the main form
        [HttpPost]
        public ActionResult Index(MyViewModel model)
        {
            return Content(
                string.Format(
                    "Thanks for filling out the form. You selected value: \"{0}\" and other property: \"{1}\"",
                    model.SelectedValue,
                    model.SomeOtherProperty
                )
            );
        }

        // Renders the partial view which will be shown in a modal
        public ActionResult Modal(string selectedValue)
        {
            var model = new DialogViewModel
            {
                Prop1 = selectedValue
            };
            return PartialView(model);
        }

        // Processes the submission of the modal
        [HttpPost]
        public ActionResult Modal(DialogViewModel model)
        {
            if (ModelState.IsValid)
            {
                // validation of the modal view model succeeded =>
                // we return a JSON result containing some precalculated value
                return Json(new
                {
                    value = string.Format("{0} - {1} - {2}", model.Prop1, model.Prop2, model.Prop3)
                });
            }

            // Validation failed => we need to redisplay the modal form
            // and give the user the possibility to fix his errors
            return PartialView(model);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

    }
}
