using System;

namespace RKE.UIModels.RozkladModelsForTeachers
{
    public class RozkladModelForTeachersLessonsModel
    {
        public DateTime Date { get; set; }
        public string Aud { get; set; }
        public int NumberOfLesson { get; set; }
        public string Group { get; set; }
    }
}