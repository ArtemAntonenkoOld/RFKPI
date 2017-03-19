using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RKE.DAL.Abstract;
using RKE.IOC.Common.Attributes;

namespace RKE.DAL.Concrate
{
    [BindsTo(typeof(ISampleTest))]
    public class SampleTest : ISampleTest
    {
        public string GetResult()
        { 
            return "It\'s work\'s";
        }
    }
}
