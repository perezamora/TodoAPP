using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web.Http;
using Todo.Business.Facada.WebService.App_Start;

namespace Todo.Business.Facada.WebService
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Configuración y servicios de API web

            log4net.Config.XmlConfigurator.Configure();
            //log4net.Config.XmlConfigurator.Configure(new FileInfo("log4net.config"));

            IocConfig.Configure();

            // Rutas de API web
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{action}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
