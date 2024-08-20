using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace ProjectB3_API
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }

        //protected void Application_BeginRequest()
        //{
        //    // Verifique se o cabeçalho já foi adicionado
        //    if (HttpContext.Current.Response.Headers["Access-Control-Allow-Origin"] == null)
        //    {
        //        HttpContext.Current.Response.AddHeader("Access-Control-Allow-Origin", "http://localhost:4200");
        //    }
        //    HttpContext.Current.Response.AddHeader("Access-Control-Allow-Headers", "Content-Type, Accept, Authorization");
        //    HttpContext.Current.Response.AddHeader("Access-Control-Allow-Methods", "GET, POST, PUT, DELETE, OPTIONS");
        //    HttpContext.Current.Response.AddHeader("Access-Control-Allow-Credentials", "true");

        //    if (HttpContext.Current.Request.HttpMethod == "OPTIONS")
        //    {
        //        HttpContext.Current.Response.StatusCode = 200;
        //        HttpContext.Current.Response.End();
        //    }
        //}
    }
}
