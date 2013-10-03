using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Newtonsoft.Json;

namespace SRR.UI.MVC4.Models
{
     //[JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public class TimeSheet
    {
         //[JsonProperty]
        public string ID { get; set; }

         //[JsonProperty]
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public int Month { get; set; }
        public int Year { get; set; }

        public IEnumerable<SelectListItem> Months
        {
            get
            {
                var months = DateTimeFormatInfo.InvariantInfo.MonthNames.Select((monthName, index) => new SelectListItem
                {
                    Value = (index + 1).ToString(),
                    Text = monthName
                }).ToList();
                months.RemoveAt(12); // 13th item is empty
                return months;
            }
        }
    }
}