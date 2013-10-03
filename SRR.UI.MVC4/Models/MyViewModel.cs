using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SRR.UI.MVC4.Models
{
    public class MyViewModel
    {
        [DisplayName("select a value")]
        public string SelectedValue { get; set; }
        public IEnumerable<SelectListItem> Values { get; set; }
        public string SomeOtherProperty { get; set; }
    }
}