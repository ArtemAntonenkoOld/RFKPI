using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RKE.UIModels.CRUDLessonForExternalModels
{
    public class CRUDLessonForExternalModelsDataModel
    {
        public List<CRUDLessonForExternalModelsDisziplinModel> Disziplins { get; set; }
        public List<CRUDLessonForExternalModelsGroupsModel> Groups { get; set; }
        public List<CRUDLessonForExternalModelsTeachersModel> Teachers { get; set; }
        public List<CRUDLessonForExternalModelsAudsModel> Auds { get; set; }

    }
}
