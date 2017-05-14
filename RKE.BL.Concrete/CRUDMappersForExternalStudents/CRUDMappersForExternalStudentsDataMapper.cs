using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RKE.UIModels.CRUDLessonForExternalModels;
using RKE.Entity;

namespace RKE.BL.Concrete.CRUDMappersForExternalStudents
{
    public class CRUDMappersForExternalStudentsDataMapper
    {
        public CRUDLessonForExternalModelsDataModel EntityToModel(List<Group> groups,List<Teacher> teachers,List<Aud> auds,List<Disziplin> disziplin)
        {
            CRUDMappersForExternalStudentsAudsMapper _CRUDMappersForExternalStudentsAudsMapper = new CRUDMappersForExternalStudentsAudsMapper();
            CRUDMappersForExternalStudentsTeachersMapper _CRUDMappersForExternalStudentsTeachersMapper = new CRUDMappersForExternalStudentsTeachersMapper();
            CRUDMappersForExternalStudentsGroupsMapper _CRUDMappersForExternalStudentsGroupsMapper = new CRUDMappersForExternalStudentsGroupsMapper();
            CRUDMappersForExternalStudentsDisziplinsMapper _CRUDMappersForExternalStudentsDisziplinsMapper = new CRUDMappersForExternalStudentsDisziplinsMapper();
            CRUDLessonForExternalModelsDataModel p = new CRUDLessonForExternalModelsDataModel() {
                Auds=_CRUDMappersForExternalStudentsAudsMapper.EntityToModel(auds),
                Disziplins=_CRUDMappersForExternalStudentsDisziplinsMapper.EntityToModel(disziplin),
                Groups=_CRUDMappersForExternalStudentsGroupsMapper.EntityToModel(groups),
                Teachers=_CRUDMappersForExternalStudentsTeachersMapper.EntityToModel(teachers)

            };
            
            return p;
        }


    }
}

