using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RKE.UIModels.RozkladModel;

namespace RKE.BL.Abstract
{
    public interface IRozkladDataHandler
    {
        Task<List<RozkladModel>> GetByGroup(string groupName);
        Task<RozkladModel> GetByGroup(string groupName,int week);
    }
}
