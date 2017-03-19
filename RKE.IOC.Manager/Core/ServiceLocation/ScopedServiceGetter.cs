using System;
using Castle.MicroKernel;
using RKE.IOC.Common.Interfaces;

namespace RKE.IOC.Manager.Core.ServiceLocation
{
    public class ScopedServiceGetter : IScopedServiceGetter
    {
        private readonly IKernel _kernel;
        public ScopedServiceGetter(IKernel kernel)
        {
            _kernel = kernel;
        }
        public IServiceContainer<T> GetService<T>()
        {
            return new ServiceContainer<T>(_kernel, _kernel.Resolve<T>());
        }

        public IServiceContainer<T> GetService<T>(Type type)
        {
            return new ServiceContainer<T>(_kernel, (T)_kernel.Resolve(type));
        }

        public IServiceContainer<Object> GetService(Type type)
        {
            return new ServiceContainer<Object>(_kernel, _kernel.Resolve(type));
        }
    }
}