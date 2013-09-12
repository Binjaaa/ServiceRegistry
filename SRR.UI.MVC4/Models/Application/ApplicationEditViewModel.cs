using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SRR.DataAccessLayer.Model;

namespace SRR.UI.MVC4.Models.Application
{
    public class ApplicationEditViewModel
    {
        public ApplicationEditViewModel()
        {

        }

        public SRRApplications Application { get; set; }
        public IList<SelectListItem> Users { get; set; }
        public MultiSelectList Tags { get; set; }
        public IEnumerable<string> SelectedTags { get; set; }
    }
}