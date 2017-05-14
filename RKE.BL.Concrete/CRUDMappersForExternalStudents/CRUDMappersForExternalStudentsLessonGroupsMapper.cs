using RKE.Entity;
using RKE.UIModels.CRUDLessonForExternalModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RKE.BL.Concrete.CRUDMappersForExternalStudents
{
    public class CRUDMappersForExternalStudentsLessonGroupsMapper
    {
        public List<LessonGroups> ModelToEntity(int[] entity)
        {
            List<LessonGroups> p = new List<LessonGroups>();
            foreach (var item in entity)
            {
                p.Add(new LessonGroups
                {
                    ApiGroupId = item
                });
            }
            return p;
        }

    }
}
