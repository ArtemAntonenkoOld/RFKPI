using System;
using Castle.MicroKernel;
using RKE.IOC.Common.Interfaces;

namespace RKE.IOC.Manager.Core.ServiceLocation
{
    public class ServiceContainer<T> : IServiceContainer<T>
    {
        private IKernel _kernel;
        private bool _isDisposabled;
        public T Service { get; private set; }

        public ServiceContainer(IKernel container, T service)
        {
            _kernel = container;
            Service = service;
        }

        public void Dispose()
        {
            if (_isDisposabled == false)
            {
                _kernel.ReleaseComponent(Service);
                _isDisposabled = true;
                Service = default(T);
                GC.SuppressFinalize(this);
            }
        }

        ~ServiceContainer()
        {
            Dispose();
        }
    }
}