using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RKE.UIModels.RozkladModelForStudents;
using RKE.ViewModels.RozkladModelsForTeachers;

namespace RKE.BL.Abstract
{
    public interface IRozkladForStudentsHandler
    {
        Task<List<RozkladModel>> GetByGroup(string groupName);
        Task<RozkladForTeachersModel> GetByNameOfTeacher(string teacherName);
    }
}
