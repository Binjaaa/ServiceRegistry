namespace SRR.UI.MVC4.Controllers
{
    using System.Web.Mvc;
    using SRR.Contracts.Managers;
    using SRR.Web.ViewModels.Application;

    /// <summary>
    /// 
    /// </summary>
    public class ApplicationController : Controller
    {
        internal readonly ISRRApplicationManager _appManager;
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="appManager"></param>
        public ApplicationController(ISRRApplicationManager appManager)
        {
            this._appManager = appManager;
        }

        //
        // GET: /Application/
        public ActionResult Index()
        {
            var indexViewModel = this._appManager.Index();
            return View(indexViewModel);
        }


        //
        // POST: /Application/
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(ApplicationEditViewModel app)
        {
            if (ModelState.IsValid)
            {
                _appManager.Update(app);
            }

            return RedirectToAction("Index");
        }

        //
        // ????
        public ActionResult Edit(int ID)
        {
            var editViewModel = this._appManager.Update(ID);
            return View(editViewModel);
        }

        [HttpPost]
        public ActionResult Create(ApplicationCreateViewModel app)
        {
            this._appManager.PostCreate(app);
            return RedirectToAction("Index");
        }


        //
        //GET: /Application/Create
        public ActionResult Create()
        {
            var createViewModel = this._appManager.GetCreate();
            return View(createViewModel);
        }


        public ActionResult Delete(int ID)
        {
            //_appRepository.Delete(ID);
            //_appRepository.Save();
            return new JsonResult() {Data = "OK" };
            //return View("Index");
        }
    }
}
