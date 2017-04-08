using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RKE.UIModels.RozkladModelsForTeachers
{
    public class RozkladModelForTeachersTeacherModel
    {
        public string FullName { get; set; }
        public string ShortName { get; set; }
        public List<RozkladModelForTeachersLessonsModel> LessonForExternalStudents { get; set; }
        public List<LessonForTeachersModel> LessonForStudents { get; set; }
    }
}
