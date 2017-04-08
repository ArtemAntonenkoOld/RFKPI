using System.Collections.Generic;
using System.Linq;
using RKE.Entity;
using RKE.UIModels.RozkladModelForStudents;

namespace RKE.BL.Concrete.RozkladMappersForStudents
{
    public class RozkladMapperForStudentsWeekMapper
    {
        public List<RozkladModelForStudentsWeekModel> EntityToModel(List<Week> entity)
        {
            RozkladMapperForStudentsLessonMapper rozkladMapperForStudentsLessonMapper = new RozkladMapperForStudentsLessonMapper();
            List<RozkladModelForStudentsWeekModel> p = new List<RozkladModelForStudentsWeekModel>();
            foreach (var item in entity)
            {
                p.Add(new RozkladModelForStudentsWeekModel()
                {
                   NumberOfWeek = item.NumberOfWeek,
                   RozkladModelForStudentsLessonModel = rozkladMapperForStudentsLessonMapper.EntityToModel(item.Lessons.ToList())
                });
        }
            return p;
        }
}
}