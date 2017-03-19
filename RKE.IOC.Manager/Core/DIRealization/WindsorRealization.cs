using System;
using System.Configuration;
using System.Web.Mvc;
using Castle.MicroKernel.Lifestyle;
using Castle.MicroKernel.Registration;
using Castle.Windsor;
using Castle.Windsor.Configuration.Interpreters;
using Castle.Windsor.Installer;
using RKE.IOC.Common.Interfaces;
using RKE.IOC.Manager.Core.Factories;

namespace RKE.IOC.Manager.Core.DIRealization
{
    public class WindsorRealization : IRealization
    {
        private static IWindsorContainer _container;
        public void Start()
        {
            if (ConfigurationManager.GetSection("castle") != null)
            {
                _container = new WindsorContainer(new XmlInterpreter());
            }
            else
            {
                _container = new WindsorContainer();
            }
            _container.Install(FromAssembly.This());

            var controllerFactory = new WinsdorControllerFactory(_container.Kernel);
            ControllerBuilder.Current.SetControllerFactory(controllerFactory);
        }

        public void PreApplicationStartMethod()
        {

        }

        public void BindSingleton<T>(T service)
            where T : class
        {
            _container.Kernel.Register(Component.For<T>().LifestyleSingleton().Instance(service));
        }

        public IDisposable BeginScope()
        {
            return _container.BeginScope();
        }

        public IServiceContainer<T> GetServiceContainer<T>()
        {
            return _container.Resolve<IScopedServiceGetter>().GetService<T>();
        }

        public void Stop()
        {
            _container.Dispose();
        }
    }
}