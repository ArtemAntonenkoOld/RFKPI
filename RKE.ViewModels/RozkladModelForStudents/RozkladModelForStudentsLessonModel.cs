using System.Collections.Generic;

namespace RKE.UIModels.RozkladModelForStudents
{
    public class RozkladModelForStudentsLessonModel
    {
        public int NumberOfLesson { get; set; }

        public int? Day { get; set; }

        public int? Week { get; set; }
        
        public int TypeOfLesson { get; set; }

        public string Aud { get; set; }

        public string Disziplin { get; set; }
        
        public string Teacher { get; set; }

    }
}