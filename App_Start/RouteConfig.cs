using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace SVGEssentials
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");


            routes.MapRoute(
                name: "Home",
                url: "",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Chapter",
                url: "{chapterTitle}",
            defaults: new { controller = "Home", action = "Chapter", chapterTitle = "" }
            );

            routes.MapRoute(
                name: "Example",
                url: "{chapterTitle}/{exampleId}",
                defaults: new { controller = "Home", action = "Example", chapterTitle = "", exampleId = "" }
            );

            routes.MapRoute(
                name: "Example_Html",
                url: "{chapterTitle}/{exampleId}.html",
                defaults: new { controller = "Home", action = "Example", chapterTitle = "", exampleId = "" }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );



        }
    }
}
