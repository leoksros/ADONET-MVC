using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace ADONETMVC
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "CrearNuevoUsuario",
                url: "Usuario/Crear",
                defaults: new { controller = "Usuario", action = "Create"}
            );

            routes.MapRoute(
                name: "GuardarNuevoUsuario",
                url: "Usuario/Guardar",
                defaults: new { controller = "Usuario", action = "Store" }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
