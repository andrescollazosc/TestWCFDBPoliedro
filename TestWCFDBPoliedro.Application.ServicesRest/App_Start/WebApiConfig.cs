﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Formatting;
using System.Web.Http;

namespace TestWCFDBPoliedro.Application.ServicesRest
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            //Json
            config.Formatters.Clear();
            config.Formatters.Add(new JsonMediaTypeFormatter());
            // Configuración y servicios de API web

            // Rutas de API web
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
