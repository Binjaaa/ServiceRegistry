namespace SRR.Web.ViewModels.Application
{
    using System.Collections.Generic;
    using SRR.DataAccessLayer.Model;

    /// <summary>
    /// 
    /// </summary>
    public class ApplicationIndexViewModel
    {
        public IEnumerable<SRRApplications> ItemsToList { get; set; }
    }
}
