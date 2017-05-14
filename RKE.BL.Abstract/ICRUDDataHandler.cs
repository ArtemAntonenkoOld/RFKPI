using RKE.UIModels.CRUDLessonForExternalModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RKE.BL.Abstract
{
    public interface ICRUDDataHandler
    {
        Task<CRUDLessonForExternalModelsDataModel> GetAllInfo();
        Task<int> SetLesson(int[] groups, int aud, int teacher, int disziplin, DateTime date);
    }
}
