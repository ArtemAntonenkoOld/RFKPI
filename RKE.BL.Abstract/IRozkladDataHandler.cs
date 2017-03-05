using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RKE.UIModels;

namespace RKE.BL.Abstract
{
    public interface IRozkladDataHandler
    {
        Task<RozkladModel> GetByGroup(string groupName);
        Task<RozkladModel> GetByGroup(string groupName,int week);
    }
}
