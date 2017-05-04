using RKE.BL.Abstract;
using RKE.BL.Concrete.RestMappersForAllGroups;
using RKE.DAL.Abstract.IRepositories;
using RKE.Entity;
using RKE.IOC.Common.Attributes;
using RKE.UIModels.RestModelForAllGroups;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RKE.BL.Concrete.DataBind
{
    [BindsTo(typeof(IRestDataHandler))]
    public class RestDataHandler : IRestDataHandler
    {
        private readonly IGroupRepository _groupRepository;
      
        public RestDataHandler(
            IGroupRepository groupRepository
            )
        {
            _groupRepository = groupRepository;
             }
        public async Task<List<FindGroupsModel>> GetAllGroups()
        {
            
            FindGroupsMapper mapper = new FindGroupsMapper();
            List<Group> res = await _groupRepository.FetchAsync();
            return mapper.EntityToModel(res);
        }
        public async Task<List<FindGroupsModel>> GetGroupsByName(string name)
        {
            FindGroupsMapper mapper = new FindGroupsMapper();
            List<Group> res = await _groupRepository.FetchByAsync(p=>p.NameOfGroup.Contains(name));
            return mapper.EntityToModel(res);
        }

    }
}
