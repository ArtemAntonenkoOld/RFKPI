﻿using System;

namespace RKE.IOC.Common.Interfaces
{
    public interface IScopedServiceGetter
    {
        IServiceContainer<T> GetService<T>();
        IServiceContainer<T> GetService<T>(Type type);
        IServiceContainer<Object> GetService(Type type);
    }
}