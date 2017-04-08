using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RKE.Entity;
using RKE.UIModels.RozkladModelsForTeachers;

namespace RKE.BL.Concrete.RozkladMappersForTeachers
{
    public class LessonsForExternalStudentsMapper
    {
        public List<RozkladModelForTeachersLessonsModel> EntityToModel(List<LessonForExternalStudents> entity)
        {

            List<RozkladModelForTeachersLessonsModel> l = new List<RozkladModelForTeachersLessonsModel>();
            foreach (var temp in entity)
            {
                l.Add(new RozkladModelForTeachersLessonsModel()
                {
                    Group = temp.Group.NameOfGroup,
                    Aud = temp.Aud,
                    Date = temp.Date,
                    NumberOfLesson = temp.NumberOfLesson


                });
            }


            return l;
        }
    }
}
