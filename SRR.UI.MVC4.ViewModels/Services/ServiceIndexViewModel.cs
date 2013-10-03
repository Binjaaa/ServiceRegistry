using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SRR.DataAccessLayer.Model;

namespace SRR.UI.MVC4.ViewModels.Services
{
    public class ServiceIndexViewModel
    {
        public IEnumerable<SRRServices> ItemsToList { get; set; }
    }
}
