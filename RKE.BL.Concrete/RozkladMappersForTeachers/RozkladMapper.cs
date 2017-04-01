using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RKE.Entity;
using RKE.ViewModels.RozkladModelsForTeachers;

namespace RKE.BL.Concrete.RozkladMappersForTeachers
{
    public class RozkladMapper
    {
        public List<RozkladForTeachersModel> EntityToModel(List<Teacher> entity)
        {
            LessonsForExternalStudentsMapper _lessonsForExternalStudentsMapper = new LessonsForExternalStudentsMapper();
            LessonsForStudentsMapper _lessonsForStudentsMapper = new LessonsForStudentsMapper();
            List<RozkladForTeachersModel> l=new List<RozkladForTeachersModel>();
            foreach (var temp in entity)
            {
                l.Add(new RozkladForTeachersModel()
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
