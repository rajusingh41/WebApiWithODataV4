using Microsoft.AspNet.OData.Builder;
using Microsoft.AspNet.OData.Extensions;
using Microsoft.OData;
using Microsoft.OData.Edm;
using ODataV4.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace ODataV4.WebApi
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            //// Web API configuration and services

            //// Web API routes
            //config.MapHttpAttributeRoutes();

            //config.Routes.MapHttpRoute(
            //    name: "DefaultApi",
            //    routeTemplate: "api/{controller}/{id}",
            //    defaults: new { id = RouteParameter.Optional }
            //);

            config.MapODataServiceRoute("ODataRout","Odata",GetEdmModel());
            config.EnsureInitialized();

        }

        private static IEdmModel GetEdmModel()
        {
            var builder = new ODataConventionModelBuilder();
            builder.Namespace = "ODataV4";
            builder.ContainerName = "ODataV4Container";
            builder.EntitySet<Person>("Pepole");
            builder.EntitySet<Product>("Product");
            return builder.GetEdmModel();

        }
    }
}
