using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RKE.UIModels.RozkladModelForStudents;
using RKE.UIModels.RozkladModelsForTeachers;
using RKE.UIModels.RozkladModelForExternalStudents;

namespace RKE.BL.Abstract
{
    public interface IRozkladHandler
    {
        Task<RozkladModelForExternalStudentsRozkladModel> GetByExternalGroup(string groupname);
        Task<RozkladModelForStudentsRozkladModel> GetByGroup(string groupName);
        Task<RozkladModelForTeachersRozkladModel> GetByNameOfTeacher(string teacherName);
        Task<RozkladModelForTeachersRozkladModel> GetByIdOfTeacher(int id);
    }
}
