using System.Collections.Generic;
using System.Linq;
using RKE.Entity;
using RKE.UIModels.RozkladModelForExternalStudents;
using RKE.UIModels.RozkladModelForStudents;

namespace RKE.BL.Concrete.RozkladMappersForStudents
{
    public class RozkladMapperForExternalStudentsLessonMapper
    {
        public List<RozkladModelForExternalStudentsLessonsForExternalStudentsModel> EntityToModel(List<Lesson> entity)
        {
            List<RozkladModelForExternalStudentsLessonsForExternalStudentsModel> p = new List<RozkladModelForExternalStudentsLessonsForExternalStudentsModel>();
            foreach (var temp in entity)
            {
                p.Add(new RozkladModelForExternalStudentsLessonsForExternalStudentsModel()
                {
                    Aud=temp.Auds.NumberOfAud,
                    Date=temp.Date,
                    NameOfTeacher=temp.Teachers.ShortNameOfTeacherWithDegree,
                    NumberOfLesson=temp.NumberOfLesson

                });
            }
            return p;
        }
        
    }
}

