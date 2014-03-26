using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace SugarMama.Web
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "ComingSoon",
                url: "coming-soon/{id}",
                defaults: new
                {
                    controller = "Home",
                    action = "ComingSoon",
                    id = UrlParameter.Optional
                }
            );

            routes.MapRoute(
                name: "About",
                url: "about/{id}",
                defaults: new
                {
                    controller = "Home",
                    action = "About",
                    id = UrlParameter.Optional
                }
             );

            routes.MapRoute(
               name: "Promotions",
               url: "promos/{id}",
               defaults: new
               {
                   controller = "Home",
                   action = "Promotions",
                   id = UrlParameter.Optional
               }
            );

            routes.MapRoute(
                name: "HairRemoval",
                url: "hair-removal/{id}",
                defaults: new
                {
                    controller = "Home",
                    action = "HairRemoval",
                    id = UrlParameter.Optional
                }
            );

            routes.MapRoute(
                name: "Tanning",
                url: "tanning/{id}",
                defaults: new
                {
                    controller = "Home",
                    action = "Tanning",
                    id = UrlParameter.Optional
                }
            );


            routes.MapRoute(
                name: "Peels",
                url: "peels/{id}",
                defaults: new
                {
                    controller = "Home",
                    action = "Peels",
                    id = UrlParameter.Optional
                }
            );

            routes.MapRoute(
               name: "Facials",
               url: "facials/{id}",
               defaults: new
               {
                   controller = "Home",
                   action = "Facials",
                   id = UrlParameter.Optional
               }
           );

            routes.MapRoute(
               name: "Contact",
               url: "contact/{id}",
               defaults: new
               {
                   controller = "Home",
                   action = "Contact",
                   id = UrlParameter.Optional
               }
           );

            routes.MapRoute(
               name: "Appointments",
               url: "appointments/{id}",
               defaults: new
               {
                   controller = "Home",
                   action = "Appointments",
                   id = UrlParameter.Optional
               }
           );


            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );




           
        }
    }
}
