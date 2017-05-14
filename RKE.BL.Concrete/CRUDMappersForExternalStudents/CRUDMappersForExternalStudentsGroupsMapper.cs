using RKE.Entity;
using RKE.UIModels.CRUDLessonForExternalModels;
using System.Collections.Generic;

namespace RKE.BL.Concrete.CRUDMappersForExternalStudents
{
    public class CRUDMappersForExternalStudentsGroupsMapper
    {
        public List<CRUDLessonForExternalModelsGroupsModel> EntityToModel(List<Group> entity)
        {
            List<CRUDLessonForExternalModelsGroupsModel> p = new List<CRUDLessonForExternalModelsGroupsModel>();
            foreach (var item in entity)
            {
                p.Add(new CRUDLessonForExternalModelsGroupsModel
                {
                    Id = item.ApiId,
                    Name = item.NameOfGroup
                });
            }
            return p;
        }
    }
}