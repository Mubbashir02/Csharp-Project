using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace eproject
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
      name: "Default",
      url: "{controller}/{action}/{id}",
      defaults: new { controller = "Home", action = "Single", id = UrlParameter.Optional }

  );

            routes.MapRoute(
                name: "Single",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }

            );
            routes.MapRoute(
               name: "Orders",
               url: "{controller}/{action}/{id}",
               defaults: new { controller = "Home", action = "Orders", id = UrlParameter.Optional }

           );
            routes.MapRoute(
               name: "Setting",
               url: "{controller}/{action}/{id}",
               defaults: new { controller = "Home", action = "Setting", id = UrlParameter.Optional }

           );


        }
    }
}
