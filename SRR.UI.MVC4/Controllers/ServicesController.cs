namespace SRR.UI.MVC4.Controllers
{
    using System.Web.Mvc;
    using SRR.Contracts.Managers;
    using SRR.UI.MVC4.ViewModels.Services;

    /// <summary>
    /// 
    /// </summary>
    public class ServicesController : Controller
    {
        internal readonly ISRRServiceManager _serviceManager;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="serviceManager"></param>
        public ServicesController(ISRRServiceManager serviceManager)
        {
            this._serviceManager = serviceManager;
        }

        //
        // GET: /Services/

        public ActionResult Index()
        {
            return View(this._serviceManager.Index());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(ServiceEditViewModel service)
        {
            if (ModelState.IsValid)
            {
                _serviceManager.Update(service);
            }

            return RedirectToAction("Index");
        }

        
        public ActionResult Edit(int ID)
        {
            var editViewModel = this._serviceManager.Update(ID);
            return View(editViewModel);
        }

        [HttpPost]
        public ActionResult Create(ServiceCreateViewModel app)
        {
            this._serviceManager.PostCreate(app);
            return RedirectToAction("Index");
        }


        public ActionResult Create()
        {
            var createViewModel = this._serviceManager.GetCreate();
            return View(createViewModel);
        }


        public ActionResult Delete(int ID)
        {
            //_appRepository.Delete(ID);
            //_appRepository.Save();
            return new JsonResult() { Data = "OK" };
            //return View("Index");
            
        }
        

       
    }
}
