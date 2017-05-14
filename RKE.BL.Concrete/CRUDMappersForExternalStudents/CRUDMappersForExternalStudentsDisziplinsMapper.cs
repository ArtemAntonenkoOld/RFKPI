using System.Collections.Generic;
using RKE.UIModels.CRUDLessonForExternalModels;
using RKE.Entity;
namespace RKE.BL.Concrete.CRUDMappersForExternalStudents
{
    public class CRUDMappersForExternalStudentsDisziplinsMapper
    {
        public List<CRUDLessonForExternalModelsDisziplinModel> EntityToModel(List<Disziplin> entity)
        {
            List<CRUDLessonForExternalModelsDisziplinModel> p = new List<CRUDLessonForExternalModelsDisziplinModel>();
            foreach (var item in entity)
            {
                p.Add(new CRUDLessonForExternalModelsDisziplinModel
                {
                    Id = item.ApiId,
                    Name = item.FullNameOfDisziplin
                });
            }
            return p;
        }
    }
}