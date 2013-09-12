using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace SRR.UI.MVC4
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );

          //  routes.MapRoute(
          //    name: "KeywordRoute",
          //    url: "{Keyword}/{Create}/",
          //    defaults: new { controller = "Keyword", action = "Create" }
          //);

          //  routes.MapRoute(
          //      name: "Application",
          //      url: "{Application}/{Edit}/{id}",
          //      defaults: new { controller = "Application", action = "Edit", id = UrlParameter.Optional }
          //  );

          //  routes.MapRoute(
          //      name: "Baby",
          //      url: "{Baby}/{Create}",
          //      defaults: new { controller = "Baby", action = "Create" }
          //      );
        }
    }
}