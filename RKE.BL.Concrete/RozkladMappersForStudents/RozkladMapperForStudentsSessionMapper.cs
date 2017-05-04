using System.Collections.Generic;
using RKE.Entity;
using RKE.UIModels.RozkladModelForStudents;

namespace RKE.BL.Concrete.RozkladMappersForStudents
{
    public class RozkladMapperForStudentsSessionMapper
    {
        public List<RozkladModelForStudentsSessionModel> EntityToModel(List<Lesson> entity)
        {
            List<RozkladModelForStudentsSessionModel> p = new List<RozkladModelForStudentsSessionModel>();
            foreach (var temp in entity)
            {
                p.Add(new RozkladModelForStudentsSessionModel()
                {
                    Aud=temp.Auds.NumberOfAud,
                    Date=temp.Date,
                    Disziplin=temp.Disziplins.NameOfDisziplin,
                    NumberOfLesson=temp.NumberOfLesson,
                    Teacher=temp.Teachers.FullNameOfTeacher

                });
            }
            return p;
        }
        
    }
}

