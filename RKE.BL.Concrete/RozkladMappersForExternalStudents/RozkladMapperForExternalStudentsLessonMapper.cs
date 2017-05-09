using System.Collections.Generic;
using System.Linq;
using RKE.Entity;
using RKE.UIModels.RozkladModelForExternalStudents;
using RKE.UIModels.RozkladModelForStudents;

namespace RKE.BL.Concrete.RozkladMappersForStudents
{
    public class RozkladMapperForExternalStudentsLessonMapper
    {
        public List<RozkladModelForExternalStudentsLessonsForExternalStudentsModel> EntityToModel(List<LessonGroups> entity)
        {
            List<RozkladModelForExternalStudentsLessonsForExternalStudentsModel> p = new List<RozkladModelForExternalStudentsLessonsForExternalStudentsModel>();
            foreach (var temp in entity)
            {
                p.Add(new RozkladModelForExternalStudentsLessonsForExternalStudentsModel()
                {
                    
                    Aud=temp.Lessons.Auds.NumberOfAud,
                    Date=temp.Lessons.Date,
                    NameOfTeacher=temp.Lessons.Teachers.ShortNameOfTeacherWithDegree,
                   
                });
            }
            return p;
        }
        
    }
}

