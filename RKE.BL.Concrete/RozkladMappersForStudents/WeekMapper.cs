using System.Collections.Generic;
using System.Linq;
using RKE.Entity;
using RKE.UIModels.RozkladModelForStudents;

namespace RKE.BL.Concrete.RozkladMappersForStudents
{
    public class WeekMapper
    {
        public List<WeekModel> EntityToModel(List<Week> entity)
        {
            LessonForStudentsMapper _lessonMapper = new LessonForStudentsMapper();
            List<WeekModel> p = new List<WeekModel>();
            foreach (var item in entity)
            {
                p.Add(new WeekModel()
                {
                   NumberOfWeek = item.NumberOfWeek,
                   LessonModel = _lessonMapper.EntityToModel(item.Lessons.ToList())
                });
        }
            return p;
        }
}
}