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
    public class AllTeachersJob
    {
        private readonly IRozkladUpdateHandler _logic;
        public AllTeachersJob(IRozkladUpdateHandler logic)
        {
            _logic = logic;
        }
        
        public void Execute()
        {
             _logic.SetTeachers();
        }
    }
}
