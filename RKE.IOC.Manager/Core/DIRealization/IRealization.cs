using System;
using RKE.IOC.Common.Interfaces;

namespace RKE.IOC.Manager.Core.DIRealization
{
    public interface IRealization
    {
        void Stop();
        void Start();
        IServiceContainer<T> GetServiceContainer<T>();
        void PreApplicationStartMethod();
        void BindSingleton<T>(T service) where T : class;
        IDisposable BeginScope();
    }
}