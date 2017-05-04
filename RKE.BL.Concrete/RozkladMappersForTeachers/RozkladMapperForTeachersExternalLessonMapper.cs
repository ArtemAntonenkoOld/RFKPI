using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RKE.Entity;
using RKE.UIModels.RozkladModelsForTeachers;

namespace RKE.BL.Concrete.RozkladMappersForTeachers
{
    public class RozkladMapperForTeachersExternalLessonMapper
    {
        public List<RozkladModelForExternalStudentModel> EntityToModel(List<Lesson> entity)
        {
          List<RozkladModelForExternalStudentModel> l = new List<RozkladModelForExternalStudentModel>();
            foreach (var temp in entity)
            {
                l.Add(new RozkladModelForExternalStudentModel()
                {
                   
                });
            }
            return l;
        }

    }
}
