using RKE.API.Models.AllGroupsApiModels;
using RKE.Entity;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RKE.API.BL.Concrete.Mappers
{
    public class SetGroupMapper
    {
        public List<Group> ModelToEntity(List<ResultForAllGroupsModel> entity)
        {
            List<Group> p = new List<Group>();
            foreach (var temp in entity)
            {
                p.Add(new Group()
                {
                    NameOfGroup=temp.name,
                    Type=temp.type,
                    ApiGroupId=temp.id,
                    Id=0,
                    LessonsForExternalStudents=new Collection<LessonForExternalStudents>(),
                    Session = new Collection<Session>(),
                    Weeks =  new Collection<Week>(),
                });
            }
            return p;
        }
    }
}
