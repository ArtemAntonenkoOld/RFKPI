using RKE.Entity;
using RKE.UIModels.RestModelForAllGroups;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RKE.BL.Concrete.RestMappersForAllGroups
{
    public class FindGroupsMapper
    {
        public List<FindGroupsModel> EntityToModel(List<Group> entity)
        {
            List<FindGroupsModel> p = new List<FindGroupsModel>();
            foreach (var temp in entity)
            {
                p.Add(new FindGroupsModel()
                {
                    Name=temp.NameOfGroup

                });
            }
            return p;
        }
    }
}
