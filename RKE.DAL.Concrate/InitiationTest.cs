using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RKE.DAL.Abstract;

namespace RKE.DAL.Concrate
{
    [BindsTo(typeof(IInitiationTest))]
    public class InitiationTest : IInitiationTest
    {
        public string GetResult()
        {
            return "It\'s work\'s";
        }
    }
}
