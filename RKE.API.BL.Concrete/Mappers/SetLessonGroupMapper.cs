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
        public List<Group> EntityToModel(List<GroupForAllLessonModel> entity)
        {
            List<Group> l = new List<Group>();
            foreach (var temp in entity)
            {
                l.Add(new Group()
                {
                    ApiGroupId=temp.Id
                });
            }
            return l;
        }
    }
}
