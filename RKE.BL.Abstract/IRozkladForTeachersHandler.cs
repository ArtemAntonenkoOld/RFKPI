using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RKE.ViewModels.RozkladModelsForTeachers;

namespace RKE.BL.Abstract
{
    public interface IRozkladForTeachersHandler
    {
        Task<RozkladForTeachersModel> GetByNameOfTeacher(string teacherName);
    }
}
