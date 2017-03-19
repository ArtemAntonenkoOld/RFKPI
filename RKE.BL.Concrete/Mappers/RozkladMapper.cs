using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RKE.Entity;
using RKE.UIModels.RozkladModel;

namespace RKE.BL.Concrete.Mappers
{
    public class RozkladMapper
    {
        public List<RozkladModel> EntityToModel(List<Group> entity)
        {
            WeekMapper _weekMapper = new WeekMapper();
            List<RozkladModel> p = new List<RozkladModel>();
            foreach (var item in entity)
            {
                p.Add(new RozkladModel()
                {
                    GroupName =  item.NameOfGroup,
                    WeekModel = _weekMapper.EntityToModel(item.Weeks.ToList())
                });
            }
            return p;
        }


    }
    
}
