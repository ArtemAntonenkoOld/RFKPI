using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RKE.UIModels.RozkladModelForExternalStudents
{
    public class RozkladModelForExternalStudentsRozkladModel
    {
        public string NameOfGroup { get; set; }
        public List<RozkladModelForExternalStudentsLessonsForExternalStudentsModel> RozkladModelForExternalLessonsForExternalStudentsModel { get; set; }
    }
}
