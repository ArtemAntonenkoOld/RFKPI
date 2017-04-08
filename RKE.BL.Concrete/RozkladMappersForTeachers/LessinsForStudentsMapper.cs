using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RKE.Entity;
using RKE.UIModels.RozkladModelsForTeachers;

namespace RKE.BL.Concrete.RozkladMappersForTeachers
{
    public class LessonsForStudentsMapper
    {
        public List<LessonForTeachersModel> EntityToModel(List<Lesson> entity)
        {

            List<LessonForTeachersModel> l = new List<LessonForTeachersModel>();
            foreach (var temp in entity)
            {
                l.Add(new LessonForTeachersModel()
                {
                    Group = temp.Week.Group.NameOfGroup,
                    Aud = temp.Aud,
                    NumberOfLesson = temp.NumberOfLesson,
                    Day = temp.Day,
                    Type = temp.Type


                });
            }


            return l;
        }

    }
}
