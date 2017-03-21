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
        public RozkladModel EntityToModel(List<Group> entity)
        {
            WeekMapper _weekMapper = new WeekMapper();
            RozkladModel p = new RozkladModel() {
                    GroupName =  entity.FirstOrDefault().NameOfGroup,
                    WeekModel = _weekMapper.EntityToModel(entity.FirstOrDefault().Weeks.ToList())
                };
            
            return p;
        }


    }
    
}
