using System;

namespace RKE.UIModels.RozkladModelForExternalStudents
{
    public class RozkladModelForExternalStudentsLessonsForExternalStudentsModel
    {
        public DateTime? Date { get; set; }
        public string Aud { get; set; }
        public int NumberOfLesson { get; set; }
        public string Group { get; set; }
        public string NameOfTeacher { get; set; }
    }
}