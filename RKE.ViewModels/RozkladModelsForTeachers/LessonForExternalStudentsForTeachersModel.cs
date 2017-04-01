using System;

namespace RKE.ViewModels.RozkladModelsForTeachers
{
    public class LessonForExternalStudentsForTeachersModel
    {
        public DateTime Date { get; set; }
        public string Aud { get; set; }
        public int NumberOfLesson { get; set; }
        public string Group { get; set; }
    }
}