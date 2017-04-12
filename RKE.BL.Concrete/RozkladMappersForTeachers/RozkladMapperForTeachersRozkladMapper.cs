using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RKE.Entity;
using RKE.UIModels.RozkladModelsForTeachers;

namespace RKE.BL.Concrete.RozkladMappersForTeachers
{
    public class RozkladMapperForTeachersRozkladMapper
    {
        public List<RozkladModelForTeachersRozkladModel> EntityToModel(List<Teacher> entity)
        {
            RozkladMapperForTeachersLessonsForExternalStudentsMapper _lessonsForExternalStudentsMapper = new RozkladMapperForTeachersLessonsForExternalStudentsMapper();
            RozkladMapperForTeachersLessonMapper _lessonsForStudentsMapper = new RozkladMapperForTeachersLessonMapper();
            RozkladMapperForTeachersSessionMapper _sessionMapper = new RozkladMapperForTeachersSessionMapper();
            List<RozkladModelForTeachersRozkladModel> l=new List<RozkladModelForTeachersRozkladModel>();
            foreach (var temp in entity)
            {
                l.Add(new RozkladModelForTeachersRozkladModel()
                {
                    FullName = temp.FullName,
                    ShortName = temp.ShortName,
                    LessonForExternalStudents =_lessonsForExternalStudentsMapper.EntityToModel(temp.LessonsForExternalStudents.ToList()),
                    LessonForStudents = _lessonsForStudentsMapper.EntityToModel(temp.Lessons.ToList()),
                    Session = _sessionMapper.EntityToModel(temp.Session.ToList())
                    
                });
            }
            return l;
        }

    }
}
