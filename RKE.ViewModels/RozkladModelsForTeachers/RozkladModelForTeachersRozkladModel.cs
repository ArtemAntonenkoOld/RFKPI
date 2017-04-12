using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RKE.UIModels.RozkladModelsForTeachers
{
    public class RozkladModelForTeachersRozkladModel
    {
        public string FullName { get; set; }
        public string ShortName { get; set; }
        public List<RozkladModelForTeachersLessonsForExternalStudentsModel> LessonForExternalStudents { get; set; }
        public List<RozkladModelForTeachersLessonModel> LessonForStudents { get; set; }
        public List<RozkladModelForTeachersSessionModel> Session { get; set; }
    }
}
