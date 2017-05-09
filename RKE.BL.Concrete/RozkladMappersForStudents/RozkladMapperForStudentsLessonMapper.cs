using System.Collections.Generic;
using RKE.Entity;
using RKE.UIModels.RozkladModelForStudents;

namespace RKE.BL.Concrete.RozkladMappersForStudents
{
    public class RozkladMapperForStudentsLessonMapper
    {
        public List<RozkladModelForStudentsLessonModel[][]> EntityToModel(List<Lesson> entity)
        {
            List<RozkladModelForStudentsLessonModel> p = new List<RozkladModelForStudentsLessonModel>();
            foreach (var temp in entity)
            {
                RozkladModelForStudentsLessonModel l = new RozkladModelForStudentsLessonModel();
                l.Day = temp.Day;
                if (temp.Auds != null) {
                    l.Aud = temp.Auds.NumberOfAud;
                }else
                {
                    l.Aud = "";
                };
                l.NumberOfLesson = (int)temp.NumberOfLesson;
                l.TypeOfLesson = temp.TypeOfLesson;
                l.Disziplin = temp.Disziplins.NameOfDisziplin;
                if (temp.Teachers != null){
                    l.Teacher = temp.Teachers.ShortNameOfTeacherWithDegree;
                }
                else
                {
                    l.Teacher = "";
                };
                l.Week = temp.Week;


                p.Add(l);
            }
            RozkladModelForStudentsLessonModel[][] obj = new RozkladModelForStudentsLessonModel[6][];
            RozkladModelForStudentsLessonModel[][] obj2 = new RozkladModelForStudentsLessonModel[6][];

            for (int i = 0; i < 6; i++)
                {
                    obj[i] = new RozkladModelForStudentsLessonModel[7];
                    obj2[i] = new RozkladModelForStudentsLessonModel[7];
                }
            
                foreach (var item in p)
                {
                if (item.Week == 1)
                {
                    obj[item.NumberOfLesson - 1][(int)item.Day - 1] = item;
                }
                else
                {
                    obj2[item.NumberOfLesson - 1][(int)item.Day - 1] = item;
                }
            }

            return new List<RozkladModelForStudentsLessonModel[][]>{obj,obj2 };
        }
        
    }
}

