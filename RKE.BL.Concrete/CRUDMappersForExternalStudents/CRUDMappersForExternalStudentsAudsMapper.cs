using System.Collections.Generic;
using RKE.UIModels.CRUDLessonForExternalModels;
using RKE.Entity;

namespace RKE.BL.Concrete.CRUDMappersForExternalStudents
{
    public class CRUDMappersForExternalStudentsAudsMapper
    {
        public List<CRUDLessonForExternalModelsAudsModel> EntityToModel(List<Aud> entity)
        {
            List<CRUDLessonForExternalModelsAudsModel> p = new List<CRUDLessonForExternalModelsAudsModel>();
            foreach (var item in entity)
            {
                p.Add(new CRUDLessonForExternalModelsAudsModel
                {
                    Id=item.ApiId,
                    NumberOfAud=item.NumberOfAud
                });
            }
            return p;
        }
    }
}