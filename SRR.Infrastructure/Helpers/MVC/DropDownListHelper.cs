using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;

namespace SRR.Infrastructure.Helpers.MVC
{
    public static class DropDownListHelper
    {
        public static IList<SelectListItem> ToSelectList<T>(this IEnumerable<T> itemsToMap, Func<T, string> valueProperty, Func<T, string> textProperty, Predicate<T> isSelected = null)
        {
            var result = new List<SelectListItem>();

            if (isSelected == null)
            {
                foreach (var item in itemsToMap)
                {
                    result.Add(new SelectListItem
                    {
                        Value = valueProperty(item),
                        Text = textProperty(item),
                        //Selected = isSelected(item)
                    });
                }
            }
            else
            {
                foreach (var item in itemsToMap)
                {
                    result.Add(new SelectListItem
                    {
                        Value = valueProperty(item),
                        Text = textProperty(item),
                        Selected = isSelected(item)
                    });
                }
            }
            return result;
        }

        public static MultiSelectList ToMultiSelectList<T>(this IEnumerable<T> itemToMap, Func<T, string> valueProperty, Func<T, string> textProperty,IEnumerable selectedValues = null)
        {
            //var result = new MultiSelectList(itemToMap,valueProperty();

            //new MultiSelectList(tags, "PK_ID", "Name", vm.Application.SRREntityTagKeywords.Select(p => p.PK_ID).ToArray());

            return null;
        }
         //vm.Tags = 

        //// Make function

        //public static IList<SelectListItem> GetUserName()
        //{
        //    IList<SelectListItem> _result = new List<SelectListItem>();
        //    _result = db.users.Where(p => p.is_active == true).ToSelectList(
        //           new Func<user, string>(p => p.id.ToString())
        //           , new Func<user, string>(p => p.name));
        //}
    }
}
