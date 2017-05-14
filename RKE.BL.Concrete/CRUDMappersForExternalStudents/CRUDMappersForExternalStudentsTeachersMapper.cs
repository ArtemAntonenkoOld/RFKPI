using RKE.Entity;
using RKE.UIModels.CRUDLessonForExternalModels;
using System.Collections.Generic;

namespace RKE.BL.Concrete.CRUDMappersForExternalStudents
{
    public class CRUDMappersForExternalStudentsTeachersMapper
    {
        public List<CRUDLessonForExternalModelsTeachersModel> EntityToModel(List<Teacher> entity)
        {
            List<CRUDLessonForExternalModelsTeachersModel> p = new List<CRUDLessonForExternalModelsTeachersModel>();
            foreach (var item in entity)
            {
                p.Add(new CRUDLessonForExternalModelsTeachersModel
                {
                    Id = item.ApiId,
                    Name = item.NameOfTeacher
                });
            }
            return p;
        }
    }
}