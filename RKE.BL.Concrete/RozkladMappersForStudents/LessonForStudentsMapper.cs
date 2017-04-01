using System.Collections.Generic;
using RKE.Entity;
using RKE.UIModels.RozkladModelForStudents;

namespace RKE.BL.Concrete.RozkladMappersForStudents
{
    public class LessonForStudentsMapper
    {
        public List<LessonModel> EntityToModel(List<Lesson> entity)
        {
            List<LessonModel> p = new List<LessonModel>();
            foreach (var temp in entity)
            {
                p.Add(new LessonModel()
                {
                    Day = temp.Day,
                    Aud = temp.Aud,
                    Id = temp.Id,
                    NumberOfLesson = temp.NumberOfLesson,
                    Type = temp.Type
                    
            });
        }
            return p;
        }
}
}