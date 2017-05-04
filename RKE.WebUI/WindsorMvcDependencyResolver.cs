using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http.Dependencies;
using Castle.MicroKernel;
using RKE.IOC.Common.Attributes;
using IDependencyResolver = System.Web.Http.Dependencies.IDependencyResolver;
using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using RKE.API.Shedules.Triggers;

namespace RKE.WebUI
{
    [BindsTo(typeof(WindsorMvcDependencyResolver))]
    public class WindsorMvcDependencyResolver : IDependencyResolver
    {
        private readonly IKernel _kernel;
        readonly List<object> _resolvedServices = new List<object>();

        public WindsorMvcDependencyResolver(IKernel kernel)
        {
            _kernel = kernel;
          
        }


        public void Dispose()
        {
            foreach (var service in _resolvedServices)
            {
                _kernel.ReleaseComponent(service);
            }
        }

        public object GetService(Type serviceType)
        {
            try
            {
                var service = _kernel.Resolve(serviceType);

                if (service != null)
                    _resolvedServices.Add(service);

                return service;
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            var resolveAll = _kernel.ResolveAll(serviceType);

            foreach (var service in resolveAll)
            {
                _resolvedServices.Add(service);
            }

            return resolveAll.Cast<object>();
        }

        public IDependencyScope BeginScope()
        {
            var scope = new WindsorMvcDependencyResolver(_kernel);

            return scope;
        }
         }

    [BindsTo(typeof(WindsorSignalRDependencyResolver))]
    public class WindsorSignalRDependencyResolver : Microsoft.AspNet.SignalR.DefaultDependencyResolver
    {
        private readonly WindsorMvcDependencyResolver _resolver;

        public WindsorSignalRDependencyResolver(WindsorMvcDependencyResolver resolver)
        {
            _resolver = resolver;
        }
        public override object GetService(Type serviceType)
        {
            return base.GetService(serviceType) ?? _resolver.GetService(serviceType);
        }

        public override IEnumerable<object> GetServices(Type serviceType)
        {
            return _resolver.GetServices(serviceType).Concat(base.GetServices(serviceType));
        }
    }
}