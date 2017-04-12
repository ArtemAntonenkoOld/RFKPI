using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RKE.Entity;
using RKE.UIModels.RozkladModelsForTeachers;

namespace RKE.BL.Concrete.RozkladMappersForTeachers
{
    public class RozkladMapperForTeachersLessonMapper
    {
        public List<RozkladModelForTeachersLessonModel> EntityToModel(List<Lesson> entity)
        {

            List<RozkladModelForTeachersLessonModel> l = new List<RozkladModelForTeachersLessonModel>();
            foreach (var temp in entity)
            {
                l.Add(new RozkladModelForTeachersLessonModel()
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
