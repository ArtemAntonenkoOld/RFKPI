using System.Linq;
using Bender.Reflection;
using Castle.MicroKernel.Lifestyle;
using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using RKE.IOC.Common.Attributes;

namespace RKE.IOC.Manager.Core.WinsdorsInstallers
{
    public class RequestScopeInstaller : BaseInstaller, IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            var allTypes = base.GetTypesFromThisApplication();
            foreach (var type in allTypes.Where(t => t.HasAttribute<RequestScopeAttribute>()))
            {
                var interfaces = GetServiceTypes(type);
                foreach (var @interface in interfaces)
                {
                    Register(container, @interface, type, x => x.LifeStyle.Scoped<HybridPerWebRequestScopedScopeAccessor>());
                }
            }
        }
    }
    public class HybridPerWebRequestScopedScopeAccessor : HybridPerWebRequestScopeAccessor
    {
        public HybridPerWebRequestScopedScopeAccessor()
            : base(new LifetimeScopeAccessor())
        {
        }
    }
}