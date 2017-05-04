using System.Collections.Generic;
using RKE.Entity;
using RKE.UIModels.RozkladModelForStudents;

namespace RKE.BL.Concrete.RozkladMappersForStudents
{
    public class RozkladMapperForStudentsLessonMapper
    {
        public RozkladModelForStudentsLessonModel[][] EntityToModel(List<Lesson> entity)
        {
            List<RozkladModelForStudentsLessonModel> p = new List<RozkladModelForStudentsLessonModel>();
            foreach (var temp in entity)
            {
                p.Add(new RozkladModelForStudentsLessonModel()
                {
                    Day = temp.Day,
                    Aud = temp.Auds.NumberOfAud,
                    NumberOfLesson = temp.NumberOfLesson,
                    TypeOfLesson=temp.TypeOfLesson,
                    Disziplin = temp.Disziplins.NameOfDisziplin,
                    Teacher = temp.Teachers.ShortNameOfTeacherWithDegree,
                    Week=temp.Week,


                });
            }
            RozkladModelForStudentsLessonModel[][] obj = new RozkladModelForStudentsLessonModel[6][];
                for (int i = 0; i < 6; i++)
                {
                    obj[i] = new RozkladModelForStudentsLessonModel[7];
                }
            
                foreach (var item in p)
                {
                    obj[(int)item.Day-1][item.NumberOfLesson-1] = item;
                }
            return obj;
        }
        
    }
}

