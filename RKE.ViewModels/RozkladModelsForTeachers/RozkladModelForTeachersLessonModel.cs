using System.Collections.Generic;

namespace RKE.UIModels.RozkladModelsForTeachers
{
    public class RozkladModelForTeachersLessonModel
    {
        public int? Day { get; set; }
        public int NumberOfLesson { get; set; }
        public string Aud { get; set; }
        public int Type { get; set; } //Lekzia
        public int? Week { get; set; }
        public string NameOfDisziplin { get; set; }
        public List<GroupModelForTeachersModel> Group { get; set; }
    }
}