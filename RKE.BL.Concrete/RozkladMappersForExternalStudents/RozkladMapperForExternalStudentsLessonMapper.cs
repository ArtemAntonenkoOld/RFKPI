using System.Collections.Generic;
using System.Linq;
using RKE.Entity;
using RKE.UIModels.RozkladModelForExternalStudents;
using RKE.UIModels.RozkladModelForStudents;

namespace RKE.BL.Concrete.RozkladMappersForStudents
{
    public class RozkladMapperForExternalStudentsLessonMapper
    {
        public List<RozkladModelForExternalStudentsLessonsForExternalStudentsModel> EntityToModel(List<LessonForExternalStudents> entity)
        {
            List<RozkladModelForExternalStudentsLessonsForExternalStudentsModel> p = new List<RozkladModelForExternalStudentsLessonsForExternalStudentsModel>();
            foreach (var temp in entity)
            {
                p.Add(new RozkladModelForExternalStudentsLessonsForExternalStudentsModel()
                {
                    Group = temp.Group.NameOfGroup,
                    Aud = temp.Aud,
                    NumberOfLesson = temp.NumberOfLesson,
                    Date = temp.Date,
                    NameOfTeacher = temp.Teacher.FullName

                });
            }
            return p;
        }
        
    }
}

