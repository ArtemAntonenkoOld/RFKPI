using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RKE.ViewModels.RozkladModelsForTeachers
{
    public class RozkladForTeachersModel
    {
        public string FullName { get; set; }
        public string ShortName { get; set; }
        public List<LessonForExternalStudentsForTeachersModel> LessonForExternalStudents { get; set; }
        public List<LessonForTeachersModel> LessonForStudents { get; set; }
    }
}
