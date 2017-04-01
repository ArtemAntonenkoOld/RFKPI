using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RKE.Entity;
using RKE.ViewModels.RozkladModelsForTeachers;

namespace RKE.BL.Concrete.RozkladMappersForTeachers
{
    public class LessonsForExternalStudentsMapper
    {
        public List<LessonForExternalStudentsForTeachersModel> EntityToModel(List<LessonForExternalStudents> entity)
        {

            List<LessonForExternalStudentsForTeachersModel> l = new List<LessonForExternalStudentsForTeachersModel>();
            foreach (var temp in entity)
            {
                l.Add(new LessonForExternalStudentsForTeachersModel()
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
