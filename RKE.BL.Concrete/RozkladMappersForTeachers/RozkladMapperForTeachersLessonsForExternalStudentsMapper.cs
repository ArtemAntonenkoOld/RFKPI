using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RKE.Entity;
using RKE.UIModels.RozkladModelsForTeachers;

namespace RKE.BL.Concrete.RozkladMappersForTeachers
{
    public class RozkladMapperForTeachersLessonsForExternalStudentsMapper
    {
        public List<RozkladModelForTeachersLessonsForExternalStudentsModel> EntityToModel(List<LessonForExternalStudents> entity)
        {

            List<RozkladModelForTeachersLessonsForExternalStudentsModel> l = new List<RozkladModelForTeachersLessonsForExternalStudentsModel>();
            foreach (var temp in entity)
            {
                l.Add(new RozkladModelForTeachersLessonsForExternalStudentsModel()
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
