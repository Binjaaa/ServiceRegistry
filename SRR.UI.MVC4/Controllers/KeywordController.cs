using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SRR.DataAccessLayer.Model;

namespace SRR.UI.MVC4.Controllers
{
    public class KeywordController : Controller
    {
        //
        // GET: /Keyword/

        public ActionResult Index()
        {
            return View();
        }

        //
        // GET: /Keyword/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Keyword/Create

        //public ActionResult Create(SRREntityTagKeywords keyword)
        //{
        //    return View();
        //}

        //
        // POST: /Keyword/Create

        [HttpPost]
        public ActionResult Create(int keyword)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Create(SRREntityTagKeywords tag)
        {
            return View();
        }

        //
        // GET: /Keyword/Edit/5

        public ActionResult Edit(SRREntityTagKeywords keyword)
        {
            return View();
        }

        //
        // POST: /Keyword/Edit/5

        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Keyword/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Keyword/Delete/5

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
