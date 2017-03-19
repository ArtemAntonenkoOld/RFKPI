using System;

namespace RKE.IOC.Common.Interfaces
{
    public interface IServiceContainer<out T> : IDisposable
    {
        T Service { get; }
    }
}