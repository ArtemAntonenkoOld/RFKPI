using System.Linq;
using System.Reflection;
using System.Web.Mvc;
using Bender.Reflection;
using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using RKE.IOC.Common.Attributes.Abstract;

namespace RKE.IOC.Manager.Core.WinsdorsInstallers
{
    public class DefaultInstaller : BaseInstaller, IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            var allTypes = base.GetTypesFromThisApplication();
            foreach (var type in allTypes.Where(t => !t.GetCustomAttributes().OfType<BaseIoCAttribute>().Any()
                                                  && !t.CanBeCastTo<IController>()))
            {
                var interfaces = GetServiceTypes(type);
                foreach (var @interface in interfaces)
                {
                    Register(container, @interface, type, x => x.LifestyleTransient());
                }
            }
        }
    }
}