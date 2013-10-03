using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using SRR.DataAccessLayer.Model;

namespace SRR.UI.MVC4.ViewModels.Services
{
    public class ServiceCreateViewModel
    {
        public SRRServices CurrentServiceObject { get; set; }
        public List<SelectListItem> UserList { get; set; }
        public MultiSelectList TagList { get; set; }
        public IEnumerable<string> SelectedTags { get; set; }
    }
}
