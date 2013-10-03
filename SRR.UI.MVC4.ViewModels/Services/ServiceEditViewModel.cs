using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using SRR.DataAccessLayer.Model;

namespace SRR.UI.MVC4.ViewModels.Services
{
    public class ServiceEditViewModel
    {
        public SRRServices CurrentServiceObject { get; set; }
        public IList<SelectListItem> Users { get; set; }
        
        public MultiSelectList Tags { get; set; }
        public IEnumerable<string> SelectedTags { get; set; }
    }
}
