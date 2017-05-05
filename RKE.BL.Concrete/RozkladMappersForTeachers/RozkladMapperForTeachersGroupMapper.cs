using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RKE.Entity;
using RKE.UIModels.RozkladModelsForTeachers;

namespace RKE.BL.Concrete.RozkladMappersForTeachers
{
    public class RozkladMapperForTeachersGroupMapper
    {
        public List<GroupModelForTeachersModel> EntityToModel(List<LessonGroups> entity)
        {
            List<GroupModelForTeachersModel> l = new List<GroupModelForTeachersModel>();
            foreach (var temp in entity)
            {
                l.Add(new GroupModelForTeachersModel()
                {
                    Name=temp.Groups.NameOfGroup
                });
            }
            return l;
        }
    }
}
