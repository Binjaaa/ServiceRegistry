using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SRR.UI.MVC4.Models
{
    public class DialogViewModel
    {
        [Required]
        public string Prop1 { get; set; }
        [Required]
        public string Prop2 { get; set; }
        [Required]
        public string Prop3 { get; set; }
    }
}