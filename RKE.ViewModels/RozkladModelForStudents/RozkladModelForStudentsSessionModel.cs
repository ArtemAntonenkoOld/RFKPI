using System;
using System.Collections.Generic;

namespace RKE.UIModels.RozkladModelForStudents
{
    public class RozkladModelForStudentsSessionModel
    {
        public int NumberOfLesson { get; set; }

        public DateTime? Date { get; set; }
                
        public int TypeOfLesson { get; set; }

        public string Aud { get; set; }

        public string Disziplin { get; set; }
        
        public string Teacher { get; set; }

    }
}