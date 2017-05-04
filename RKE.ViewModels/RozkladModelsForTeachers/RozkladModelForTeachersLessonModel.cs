using System.Collections.Generic;

namespace RKE.UIModels.RozkladModelsForTeachers
{
    public class RozkladModelForTeachersLessonModel
    {
        public int? Day { get; set; }
        public int NumberOfLesson { get; set; }
        public string Aud { get; set; }
        public string Type { get; set; } //Lekzia
        public List<GroupModelForTeachersModel> Group { get; set; }
    }
}