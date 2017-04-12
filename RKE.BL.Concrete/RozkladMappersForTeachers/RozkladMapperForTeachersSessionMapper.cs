using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RKE.Entity;
using RKE.UIModels.RozkladModelsForTeachers;

namespace RKE.BL.Concrete.RozkladMappersForTeachers
{
    public class RozkladMapperForTeachersSessionMapper
    {
        public List<RozkladModelForTeachersSessionModel> EntityToModel(List<Session> entity)
        {
          List<RozkladModelForTeachersSessionModel> l = new List<RozkladModelForTeachersSessionModel>();
            foreach (var temp in entity)
            {
                l.Add(new RozkladModelForTeachersSessionModel()
                {
                   
                });
            }
            return l;
        }

    }
}
