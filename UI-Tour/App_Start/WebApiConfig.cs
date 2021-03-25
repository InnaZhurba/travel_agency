using Ninject;
using Ninject.Web.WebApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Web.Http;
using System.Web.Mvc;
using UI_Tour.Controllers;

namespace UI_Tour
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Конфигурация и службы веб-API

            // Маршруты веб-API
            config.MapHttpAttributeRoutes();

            //config.Routes.MapHttpRoute(
            //   name: "Api",
            //   routeTemplate: "api/{controller}"
            //   );
            //var kernel = new StandardKernel();
            //config.DependencyResolver = new NinjectDependencyResolver(kernel);

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "{api}/{controller}/{id}",
                defaults: new {api = "api", controller = "TourElements", id = RouteParameter.Optional }
            );
            config.Formatters.JsonFormatter.SupportedMediaTypes.Add(new MediaTypeHeaderValue("text/html"));
            //config.Formatters.Remove(config.Formatters.JSonFormatter);
        }
    }
}
