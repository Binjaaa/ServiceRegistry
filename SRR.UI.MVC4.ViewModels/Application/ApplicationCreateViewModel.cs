namespace SRR.Web.ViewModels.Application
{
    using System.Collections.Generic;
    using System.Web.Mvc;
    using SRR.DataAccessLayer.Model;

    /// <summary>
    /// 
    /// </summary>
    public class ApplicationCreateViewModel
    {
        public ApplicationCreateViewModel()
        {

        }

        public SRRApplications Application { get; set; }
        public IList<SelectListItem> Users { get; set; }
        public MultiSelectList Tags { get; set; }
        public IEnumerable<string> SelectedTags { get; set; }
    }
}
