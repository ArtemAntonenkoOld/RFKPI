using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Reflection;
using Bender.Extensions;
using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Transports;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Owin;
using RKE.IOC.Manager.Core;
using RKE.Identity;
using Microsoft.Owin.Security.Cookies;
using Microsoft.AspNet.Identity;
using Microsoft.Owin;
using Microsoft.Owin.Security;
using RKE.DAL.Concrate.ContextOfDatabase;

[assembly: OwinStartup(typeof(RKE.WebUI.Startup))]
namespace RKE.WebUI
{

    public partial class Startup
    {
        private WebClient _dummy;
        public void Configuration(IAppBuilder app)
        {
            app.CreatePerOwinContext<RKEIdentityContext>(RKEIdentityContext.Create);
            app.CreatePerOwinContext<ApplicationUserManager>(ApplicationUserManager.Create);
            app.UseCookieAuthentication(new CookieAuthenticationOptions()
            {
                AuthenticationType = DefaultAuthenticationTypes.ApplicationCookie,
                LoginPath = new PathString("/Account/Login"),
            });
            //ConfigureAuth(app);

            var resolver = IocMannager.GetServiceContainer<WindsorSignalRDependencyResolver>();
            var windsorSignalDependencyResolver = resolver.Service;


            GlobalHost.Configuration.LongPollDelay = TimeSpan.FromSeconds(6);
            (GlobalHost.DependencyResolver.Resolve<ITransportManager>() as TransportManager).Remove("webSockets");
            //(GlobalHost.DependencyResolver.Resolve<ITransportManager>() as TransportManager).Remove("serverSentEvents");
            //(GlobalHost.DependencyResolver.Resolve<ITransportManager>() as TransportManager).Remove("foreverFrame");

            app.MapSignalR(new HubConfiguration
            {
                EnableDetailedErrors = true,
                //   Resolver = windsorSignalDependencyResolver,

            });
        }
    }

    public class FilteredCamelCasePropertyNamesContractResolver : DefaultContractResolver
    {
        public FilteredCamelCasePropertyNamesContractResolver()
        {
            AssembliesToInclude = new HashSet<Assembly>(AppDomain.CurrentDomain.GetAssemblies().Where(a => a.FullName.StartsWith("Svetophor")));
            TypesToInclude = new HashSet<Type>();
            ;
        }
        // Identifies assemblies to include in camel-casing
        public HashSet<Assembly> AssembliesToInclude { get; set; }
        // Identifies types to include in camel-casing
        public HashSet<Type> TypesToInclude { get; set; }
        protected override JsonProperty CreateProperty(MemberInfo member, MemberSerialization memberSerialization)
        {
            //AssembliesToInclude = new HashSet<Assembly>(AppDomain.CurrentDomain.GetAssemblies().Where(a => a.FullName.StartsWith("Svetophor")));

            var jsonProperty = base.CreateProperty(member, memberSerialization);
            Type declaringType = member.DeclaringType;
            if (
                TypesToInclude.Contains(declaringType)
                || AssembliesToInclude.Contains(declaringType.Assembly))
            {
                jsonProperty.PropertyName = jsonProperty.PropertyName.ToCamelCase();
            }
            return jsonProperty;
        }
    }
}