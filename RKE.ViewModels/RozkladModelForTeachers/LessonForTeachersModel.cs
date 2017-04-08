namespace RKE.UIModels.RozkladModelsForTeachers
{
    public class LessonForTeachersModel
    {
        public int Day { get; set; }
        public int NumberOfLesson { get; set; }
        public string Aud { get; set; }
        public string Type { get; set; } //Lekzia
        public string Group { get; set; }
    }
}