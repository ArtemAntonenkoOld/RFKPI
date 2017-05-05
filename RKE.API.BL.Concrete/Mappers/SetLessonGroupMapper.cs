using RKE.API.Models.AllLessonsApiModels;
using RKE.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RKE.API.BL.Concrete.Mappers
{
    public class SetLessonGroupMapper
    {
        public List<LessonGroups> EntityToModel(List<int> entity)
        {
            List<LessonGroups> l = new List<LessonGroups>();
            foreach (var temp in entity)
            {
                l.Add(new LessonGroups()
                {
                    ApiGroupId=temp
                    
                });
            }
            return l;
        }
    }
}
