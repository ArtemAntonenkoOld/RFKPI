using Quartz;
using RKE.API.BL.Abstract;
using RKE.API.BL.Concrete.UpdateBind;
using RKE.IOC.Common.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RKE.API.Shedules.Triggers
{
    public class AllGroupJob
    {
        private readonly IRozkladUpdateHandler _logic;
        public AllGroupJob(IRozkladUpdateHandler logic)
        {
            _logic = logic;
        }
        
        public async Task Execute()
        {
            await _logic.SetGroups();
        }
    }
}
