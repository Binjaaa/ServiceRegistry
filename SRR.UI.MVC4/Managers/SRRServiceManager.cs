using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SRR.Contracts.DAL.Repositories;
using SRR.Contracts.Managers;
using SRR.DataAccessLayer.Model;
using SRR.UI.MVC4.ViewModels.Services;
using SRR.Infrastructure.Helpers.MVC;


namespace SRR.UI.MVC4.Managers
{
    public class SRRServiceManager : ISRRServiceManager
    {
        internal readonly IServicesRepository _serviceRepository;
        internal readonly IUserRepository _userRepository;
        internal readonly IEntityTagRepository _tagRepository;


        public SRRServiceManager(IServicesRepository serviceRepository, IUserRepository userRepository, IEntityTagRepository tagRepository)
        {
            this._serviceRepository = serviceRepository;
            this._userRepository = userRepository;
            this._tagRepository = tagRepository;
        }


        public ServiceIndexViewModel Index()
        {
            return new ServiceIndexViewModel()
            {
                ItemsToList = _serviceRepository.All().ToList()
            };
        }

        public ServiceCreateViewModel GetCreate()
        {
            ServiceCreateViewModel vm = new ServiceCreateViewModel();
            vm.UserList = _userRepository
                .All()
                .ToList()
                .Select(e => new SelectListItem { Text = e.Name, Value = e.PK_ID.ToString() })
                .WithEmptyItem("Select developer")
                .ToList();

            IEnumerable<SRREntityTagKeywords> tags = _tagRepository.All().ToList();
            vm.TagList = new MultiSelectList(tags, "PK_ID", "Name");

            return vm;
        }

        public void Delete(long ID)
        {
            throw new NotImplementedException();
        }

        public void Update(ServiceEditViewModel updatedObject)
        {
            if (updatedObject.SelectedTags != null && updatedObject.SelectedTags.Count() != 0)
            {
                var res = _tagRepository.Find(p => updatedObject.SelectedTags.Cast<int>().Contains(p.PK_ID));
                if (res.Any())
                {
                    foreach (var tag in res)
                    {
                        updatedObject.CurrentServiceObject.Tags.Add(tag);
                    }
                }
            }

            _serviceRepository.Update(updatedObject.CurrentServiceObject);
            _serviceRepository.Save();
        }

        public ServiceEditViewModel Update(int updatedObjectPrimaryKey)
        {
            ServiceEditViewModel vm = new ServiceEditViewModel();
            vm.CurrentServiceObject = _serviceRepository.GetById(updatedObjectPrimaryKey);
            vm.Users = _userRepository
                .All()
                .ToList()
                .Select(e => new SelectListItem { Text = e.Name, Value = e.PK_ID.ToString() })
                .WithEmptyItem("Select developer")
                .WithSelection(vm.CurrentServiceObject.FK_Owner.ToString())
                .ToList();

            // getting tags
            IEnumerable<SRREntityTagKeywords> tags = _tagRepository.All().ToList();
            vm.Tags = new MultiSelectList(tags, "PK_ID", "Name", vm.CurrentServiceObject.Tags.Select(p => p.PK_ID).ToArray());

            return vm;
        }

        public void PostCreate(ServiceCreateViewModel createVM)
        {
            //createVM.Application.AttachedObjects = "alma";
            if (createVM.SelectedTags != null && createVM.SelectedTags.Count() != 0)
            {
                var res = _tagRepository.Find(p => createVM.SelectedTags.Cast<int>().Contains(p.PK_ID));
                if (res.Any())
                {
                    createVM.CurrentServiceObject.Tags.Clear();
                    foreach (var tag in res)
                    {
                        createVM.CurrentServiceObject.Tags.Add(tag);
                    }
                }
            }
            _serviceRepository.Add(createVM.CurrentServiceObject);
            _serviceRepository.Save();
        }
    }
}