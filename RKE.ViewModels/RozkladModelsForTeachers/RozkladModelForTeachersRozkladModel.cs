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
        public RozkladModelForTeachersLessonModel[][] LessonModel { get; set; }
        public List<RozkladModelForTeachersSessionModel> SessionModel { get; set; }
        public List<RozkladModelForExternalStudentModel> ExternalModel { get; set; }
    }
}
