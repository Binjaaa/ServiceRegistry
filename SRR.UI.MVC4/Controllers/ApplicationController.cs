using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SRR.Contracts.DAL.Repositories;
using SRR.DataAccessLayer;
using SRR.DataAccessLayer.Model;
using SRR.DataAccessLayer.Repositories;
using SRR.UI.MVC4.Models.Application;
using SRR.UI.MVC4.App.Extensions;

namespace SRR.UI.MVC4.Controllers
{
    public class ApplicationController : Controller
    {
        internal readonly IApplicationRepository _appRepository;
        internal readonly IUserRepository _userRepository;
        internal readonly ISRREntityTagRepository _tagRepository;

        public ApplicationController(IApplicationRepository appRepository, IUserRepository userRepository, ISRREntityTagRepository tagRepository)
        {
            this._appRepository = appRepository;
            this._userRepository = userRepository;
            this._tagRepository = tagRepository;
        }

        //
        // GET: /Application/
        public ActionResult Index()
        {
            IEnumerable<SRRApplications> res = _appRepository.All().ToList();
            return View(res);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(ApplicationEditViewModel app)
        {
            if (ModelState.IsValid)
            {
                if (app.SelectedTags != null && app.SelectedTags.Count() != 0)
                {
                    
                }

                _appRepository.Update(app.Application);
                _appRepository.Save();
            }

            return RedirectToAction("Index");
        }

        public ActionResult Edit(int ID)
        {
            ApplicationEditViewModel vm = new ApplicationEditViewModel();
            vm.Application = _appRepository.GetById(ID);
            vm.Users = _userRepository
                .All()
                .ToList()
                .Select(e => new SelectListItem { Text = e.Name, Value = e.PK_ID.ToString() })
                .WithEmptyItem("Select developer")
                .WithSelection(vm.Application.FK_Developer.ToString())
                .ToList();

            // get all tags
            IEnumerable<SRREntityTagKeywords> tags = _tagRepository.All().ToList();

            //collect all the matching tags to preselect on view

            List<SRREntityTagKeywords> filteredTags = null;
            if (vm.Application.Application_Keyword_Switch != null || vm.Application.Application_Keyword_Switch.Count != 0)
            {
                filteredTags = vm.Application.Application_Keyword_Switch.Select(p => p.SRREntityTagKeywords).ToList();

                //IEnumerable<int> selectedTags = tags.Where(p => vm.Application.Application_Keyword_Switch.Contains()
                //                                    .Select(ids => ids.PK_ID);

                //foreach (var item in vm.Application.Application_Keyword_Switch)
                //{

                //}
            }

            List<SelectListItem> filterfilterfilter = new List<SelectListItem>();
            filteredTags.ForEach(p => filterfilterfilter.Add(new SelectListItem() 
            {
                Selected = true,
                Text = p.Name,
                Value = p.PK_ID.ToString()
            }));

            //var ll = new SelectListItem() {Selected = true,Text = "WCF" };

            vm.Tags = new MultiSelectList(tags, "PK_ID", "Name", vm.Application.Application_Keyword_Switch.Select(p => p.PK_ID).ToArray());

            return View(vm);
        }

        [HttpPost]
        public ActionResult Create(ApplicationEditViewModel app)
        {
            _appRepository.Add(app.Application);
            _appRepository.Save();

            return RedirectToAction("Index");
        }

        //
        //GET: /Application/Create
        public ActionResult Create()
        {
            ApplicationEditViewModel vm = new ApplicationEditViewModel();
            vm.Users = _userRepository
                .All()
                .ToList()
                .Select(e => new SelectListItem { Text = e.Name, Value = e.PK_ID.ToString() })
                .WithEmptyItem("Select developer")
                .ToList();
            return View(vm);
        }

        //public ActionResult Apps()
        //{
        //    ViewBag.valami = "ohhh apps! Stop it! :)";

        //    return View();
        //}

    }
}
