using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RKE.UIModels.RozkladModelsForTeachers
{
    public class RozkladModelForTeachersSessionModel
    {
        public DateTime Date { get; set; }
        public string NameOfLesson { get; set; }
        public string Aud { get; set; }
        public int NumberOfLesson { get; set; }
    }
}
