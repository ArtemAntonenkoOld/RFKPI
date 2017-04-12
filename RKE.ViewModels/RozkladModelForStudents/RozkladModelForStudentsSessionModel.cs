using System;

namespace RKE.UIModels.RozkladModelForStudents
{
    public class RozkladModelForStudentsSessionModel
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string NameOfLesson { get; set; }
        public string Aud { get; set; }
        public int NumberOfLesson { get; set; }
    }
}