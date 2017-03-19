using System;
using RKE.IOC.Common.Interfaces;
using RKE.IOC.Manager.Core.DIRealization;

namespace RKE.IOC.Manager.Core
{
    public class IocMannager
    {

        private static OurRealization _impl = GetImplementation();

        private static OurRealization GetImplementation()
        {
            OurRealization realization = new RefinedRealization();
            realization.IRealization = new WindsorRealization();
            return realization;
        }


        public static IServiceContainer<T> GetServiceContainer<T>()
        {
            return _impl.GetServiceContainer<T>();
        }

        public static void Start()
        {
            _impl.Start();
        }
        public static void PreApplicationStartMethod()
        {
            _impl.PreApplicationStartMethod();
        }

        public static void Stop()
        {
            _impl.Stop();
        }

        public static void BindSingleton<T>(T service) where T : class
        {
            _impl.IRealization.BindSingleton(service);
        }

        public static IDisposable BeginScope()
        {
            return _impl.IRealization.BeginScope();
        }
    }
}