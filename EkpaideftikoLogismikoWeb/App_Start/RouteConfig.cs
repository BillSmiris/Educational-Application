using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace EkpaideftikoLogismikoWeb
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Units",
                url: "Units/{action}/{unit}",
                defaults: new { controller = "Units", action = "", unit = "" }
            );

            routes.MapRoute(
                name: "Quizes",
                url: "Quizes/{action}/{unit}",
                defaults: new { controller = "Quizes", action = "", unit = "" }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional}
            );
        }
    }
}
