using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RKE.IOC.Common
{
    public class BindsToAttribute : Attribute
    {
        public Type TypeToBind { get; private set; }

        public BindsToAttribute(Type typeToBind)
        {
            TypeToBind = typeToBind;
        }
    }
}
