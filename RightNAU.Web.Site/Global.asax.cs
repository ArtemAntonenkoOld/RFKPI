using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using Microsoft.AspNet.SignalR;
using Newtonsoft.Json;
using RKE.IOC.Manager.Core;

namespace RKE.Web.Site
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            IocMannager.Start();
            AreaRegistration.RegisterAllAreas();
            GlobalHost.DependencyResolver.Register(
               typeof(JsonSerializer),
               () => new JsonSerializer()
               {
                   MissingMemberHandling = MissingMemberHandling.Ignore,
                   NullValueHandling = NullValueHandling.Include,
                   DefaultValueHandling = DefaultValueHandling.Include,
                   TypeNameHandling = TypeNameHandling.Auto
               }
           );
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
        protected void Application_End()
        {
            IocMannager.Stop();
        }
    }
}
