using System.Collections.Generic;

namespace RKE.UIModels.RozkladModelForStudents
{
    public class RozkladModelForStudentsWeekModel
    {
        public int NumberOfWeek { get; set; }
        public RozkladModelForStudentsLessonModel[][] RozkladModelForStudentsLessonModel { get; set; }
    }
}