using RKE.UIModels.RestModelForAllGroups;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RKE.BL.Abstract
{
    public interface IRestDataHandler
    {
        Task<List<FindGroupsModel>> GetAllGroups();
        Task<List<FindGroupsModel>> GetGroupsByName(string Name);
    }
}
