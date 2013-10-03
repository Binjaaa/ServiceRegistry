using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SRR.Contracts.DAL.Repositories;
using SRR.Contracts.Managers;
using SRR.DataAccessLayer.Model;
using SRR.Infrastructure.Helpers.MVC;
using SRR.Web.ViewModels.Application;

namespace SRR.UI.MVC4.Managers
{
    public class SRRApplicationManager : ISRRApplicationManager
    {
        internal readonly IApplicationRepository _appRepository;
        internal readonly IUserRepository _userRepository;
        internal readonly IEntityTagRepository _tagRepository;

        public SRRApplicationManager(IApplicationRepository appRepository, IUserRepository userRepository, IEntityTagRepository tagRepository)
        {
            this._appRepository = appRepository;
            this._userRepository = userRepository;
            this._tagRepository = tagRepository;
        }


        public ApplicationIndexViewModel Index()
        {
            return new ApplicationIndexViewModel()
            {
                ItemsToList = _appRepository.All().ToList()
            };
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public ApplicationCreateViewModel GetCreate()
        {
            ApplicationCreateViewModel vm = new ApplicationCreateViewModel();
            vm.Users = _userRepository
                .All()
                .ToList()
                .Select(e => new SelectListItem { Text = e.Name, Value = e.PK_ID.ToString() })
                .WithEmptyItem("Select developer")
                .ToList();

            IEnumerable<SRREntityTagKeywords> tags = _tagRepository.All().ToList();
            vm.Tags = new MultiSelectList(tags, "PK_ID", "Name");

            return vm;
        }


        public ApplicationEditViewModel Update(int updatedObjectPrimaryKey)
        {
            ApplicationEditViewModel vm = new ApplicationEditViewModel();
            vm.Application = _appRepository.GetById(updatedObjectPrimaryKey);
            vm.Users = _userRepository
                .All()
                .ToList()
                .Select(e => new SelectListItem { Text = e.Name, Value = e.PK_ID.ToString() })
                .WithEmptyItem("Select developer")
                .WithSelection(vm.Application.FK_Developer.ToString())
                .ToList();

            // getting tags
            IEnumerable<SRREntityTagKeywords> tags = _tagRepository.All().ToList();
            vm.Tags = new MultiSelectList(tags, "PK_ID", "Name", vm.Application.Tags.Select(p => p.PK_ID).ToArray());

            return vm;
        }


        public void Delete(long ID)
        {
            throw new NotImplementedException();
        }

        public void Update(ApplicationEditViewModel updatedObject)
        {
            if (updatedObject.SelectedTags != null && updatedObject.SelectedTags.Count() != 0)
            {
                var res = _tagRepository.Find(p => updatedObject.SelectedTags.Cast<int>().Contains(p.PK_ID));
                if (res.Any())
                {
                    foreach (var tag in res)
                    {
                        updatedObject.Application.Tags.Add(tag);
                    }
                }
            }

            _appRepository.Update(updatedObject.Application);
            _appRepository.Save();
        }


        public void PostCreate(ApplicationCreateViewModel createVM)
        {

            createVM.Application.AttachedObjects = "alma";
            if (createVM.SelectedTags != null && createVM.SelectedTags.Count() != 0)
            {
                var res = _tagRepository.Find(p => createVM.SelectedTags.Cast<int>().Contains(p.PK_ID));
                if (res.Any())
                {
                    createVM.Application.Tags.Clear();
                    foreach (var tag in res)
                    {
                        createVM.Application.Tags.Add(tag);
                    }
                }
            }
            _appRepository.Add(createVM.Application);
            _appRepository.Save();
        }
    }
}