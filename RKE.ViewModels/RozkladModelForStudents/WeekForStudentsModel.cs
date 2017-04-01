using System.Collections.Generic;

namespace RKE.UIModels.RozkladModelForStudents
{
    public class WeekModel
    {
        public int NumberOfWeek { get; set; }
        public LessonModel[][] LessonModel { get; set; }
    }
}