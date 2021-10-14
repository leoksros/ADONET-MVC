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
                name: "GuardarUsuarioEditado",
                url: "Usuario/Editar/Guardar",
                defaults: new { controller = "Usuario", action = "Update" }
            );

            routes.MapRoute(
                name: "EditarUsuario",
                url: "Usuario/Editar/{id}",
                defaults: new { controller = "Usuario", action = "Edit", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "BorrarUsuario",
                url: "Usuario/Borrar/{id}",
                defaults: new { controller = "Usuario", action = "Delete", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "CrearNuevoUsuario",
                url: "Usuario/Crear",
                defaults: new { controller = "Usuario", action = "Create"}
            );

            routes.MapRoute(
                name: "GuardarNuevoUsuario",
                url: "Usuario/Crear/Guardar",
                defaults: new { controller = "Usuario", action = "Store" }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Usuario", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
