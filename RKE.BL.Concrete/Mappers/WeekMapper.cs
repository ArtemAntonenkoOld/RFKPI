using System.Collections.Generic;
using System.Linq;
using RKE.Entity;
using RKE.UIModels.RozkladModel;

namespace RKE.BL.Concrete.Mappers
{
    public class WeekMapper
    {
        public List<WeekModel> EntityToModel(List<Week> entity)
        {
            LessonMapper _lessonMapper = new LessonMapper();
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