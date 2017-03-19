using System;
using System.Reflection;

namespace RKE.IOC.Manager.Core.Utils
{
    public class GenericMethodWrapper
    {
        private readonly MethodInfo _genericMethodInfo;

        public GenericMethodWrapper(Delegate methodDelegate)
        {
            var methodInfo = methodDelegate.Method;

            _genericMethodInfo = methodInfo.GetGenericMethodDefinition();
        }

        public MethodInfo MakeGenericMethod(Type tArgument)
        {
            return _genericMethodInfo.MakeGenericMethod(tArgument);
        }
    }
}