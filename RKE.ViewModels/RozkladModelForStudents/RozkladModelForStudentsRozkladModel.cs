﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RKE.UIModels.RozkladModelForStudents
{
    public class RozkladModelForStudentsRozkladModel
        
    {
        public string GroupName { get; set; }
        public RozkladModelForStudentsLessonModel[][] LessonModel { get; set; }
        public List<RozkladModelForStudentsSessionModel> SessionModel { get; set; }
    }
    
}
