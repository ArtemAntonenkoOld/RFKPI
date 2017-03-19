using System;
using System.Linq;
using System.Reflection;
using Bender.Configuration;
using Bender.Reflection;
using Castle.MicroKernel;
using Castle.MicroKernel.Context;
using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using RKE.IOC.Common.Attributes;
using RKE.IOC.Manager.Core.Utils;
using SC = SimpleConfig;

namespace RKE.IOC.Manager.Core.WinsdorsInstallers
{
    public class ConfigSectionInstaller : BaseInstaller, IWindsorInstaller
    {
        GenericMethodWrapper _configLoadMethod =
            new GenericMethodWrapper(
                new Func<string, Action<DeserializerOptionsDsl>, string, object>(
                    SC.Configuration.Load<object>
                )
            );

        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            var allTypes = base.GetTypesFromThisApplication();
            foreach (var type in allTypes.Where(t => t.HasAttribute<ConfigAttribute>()))
            {
                var interfaces = GetServiceTypes(type);
                var configAttribute = type.GetCustomAttribute<ConfigAttribute>();
                foreach (var @interface in interfaces)
                {
                    Register(
                        container,
                        @interface,
                        type,
                        x => x
                                .LifestyleSingleton()
                                .UsingFactoryMethod(CreateFactoryMethod(type, configAttribute))
                        );
                }
            }
        }

        private Func<IKernel, CreationContext, object> CreateFactoryMethod(Type tImpl, ConfigAttribute configAttribute)
        {
            return (kernel, context) =>
                _configLoadMethod.MakeGenericMethod(tImpl)
                    .Invoke(
                        null,
                        new object[]
                        {
                            configAttribute.ConfigSectionName,
                            null,
                            configAttribute.ConfigPath
                        }
                    );
        }

        private string GetInterfaceName(Type @interface)
        {
            string name = @interface.Name;
            if (name.Length > 1 && (int)name[0] == 73 && char.IsUpper(name[1]))
                return name.Substring(1);
            return name;
        }
    }
}