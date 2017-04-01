using System.Collections.Generic;
using RKE.Entity;
using RKE.UIModels.RozkladModelForStudents;

namespace RKE.BL.Concrete.RozkladMappersForStudents
{
    public class LessonForStudentsMapper
    {
        public LessonModel[][] EntityToModel(List<Lesson> entity)
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
            LessonModel[][] obj = new LessonModel[6][];
                for (int i = 0; i < 6; i++)
                {
                    obj[i] = new LessonModel[6];
                }
            
                foreach (var item in p)
                {
                    obj[item.Day-1][item.NumberOfLesson-1] = item;
                }
            return obj;
        }
        
    }
}

