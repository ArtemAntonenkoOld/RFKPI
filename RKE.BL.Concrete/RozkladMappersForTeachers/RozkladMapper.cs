using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RKE.Entity;
using RKE.UIModels.RozkladModelsForTeachers;

namespace RKE.BL.Concrete.RozkladMappersForTeachers
{
    public class RozkladMapper
    {
        public List<RozkladModelForTeachersTeacherModel> EntityToModel(List<Teacher> entity)
        {
            LessonsForExternalStudentsMapper _lessonsForExternalStudentsMapper = new LessonsForExternalStudentsMapper();
            LessonsForStudentsMapper _lessonsForStudentsMapper = new LessonsForStudentsMapper();
            List<RozkladModelForTeachersTeacherModel> l=new List<RozkladModelForTeachersTeacherModel>();
            foreach (var temp in entity)
            {
                l.Add(new RozkladModelForTeachersTeacherModel()
                {
                    FullName = temp.FullName,
                    ShortName = temp.ShortName,
                    LessonForExternalStudents =
                        _lessonsForExternalStudentsMapper.EntityToModel(temp.LessonsForExternalStudents.ToList()),
                    LessonForStudents = _lessonsForStudentsMapper.EntityToModel(temp.Lessons.ToList())

                });
            }
            return l;
        }

    }
}
