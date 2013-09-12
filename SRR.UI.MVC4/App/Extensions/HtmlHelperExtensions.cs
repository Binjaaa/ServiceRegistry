using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SRR.UI.MVC4.App.Extensions
{
    public static class HtmlHelperExtensions
    {
        public static IEnumerable<T> WithEmptyItem<T>(this IEnumerable<T> items, string text) where T : SelectListItem, new()
        {
            return new[] { new T { Value = string.Empty, Text = text } }.Concat(items).ToList();
        }

        public static IEnumerable<T> WithSelection<T>(this IEnumerable<T> items, string id) where T : SelectListItem
        {
            var hasSelected = false;
            foreach (var item in items)
            {
                if (!hasSelected && string.IsNullOrWhiteSpace(id) ? string.IsNullOrWhiteSpace(item.Value) : item.Value == id)
                {
                    item.Selected = true;
                    hasSelected = true;
                }
                else
                {
                    item.Selected = false;
                }

                yield return item;
            }
        }

        //public static IEnumerable<T> WithSelection<T>(this IEnumerable<T> items, string[] ids) where T : SelectListItem
        //{
        //    var hasSelected = false;
        //    foreach (var item in items)
        //    {
        //        if (!hasSelected && string.IsNullOrWhiteSpace(id) ? string.IsNullOrWhiteSpace(item.Value) : item.Value == id)
        //        {
        //            item.Selected = true;
        //            hasSelected = true;
        //        }
        //        else
        //        {
        //            item.Selected = false;
        //        }

        //        yield return item;
        //    }
        //}
    }
}