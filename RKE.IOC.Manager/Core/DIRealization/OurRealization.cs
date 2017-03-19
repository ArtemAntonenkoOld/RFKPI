using RKE.IOC.Common.Interfaces;

namespace RKE.IOC.Manager.Core.DIRealization
{
    public class OurRealization
    {
        public IRealization IRealization { get; set; }
        public virtual void Start()
        {
            IRealization.Start();
        }
        public virtual void Stop()
        {
            IRealization.Stop();
        }
        public IServiceContainer<T> GetServiceContainer<T>()
        {
            return IRealization.GetServiceContainer<T>();
        }
        public void PreApplicationStartMethod()
        {
            IRealization.PreApplicationStartMethod();
        }

    }
}