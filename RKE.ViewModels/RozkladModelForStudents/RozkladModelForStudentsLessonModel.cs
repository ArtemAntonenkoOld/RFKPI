using System.Collections.Generic;

namespace RKE.UIModels.RozkladModelForStudents
{
    public class RozkladModelForStudentsLessonModel
    {
        public int Day { get; set; }
        public int Id { get; set; }
        public string NameOfLesson { get; set; }
        public int NumberOfLesson { get; set; }
        public string Aud { get; set; }
        public string Type { get; set; }
        public string NameOfTeacher { get; set; }
    }
}