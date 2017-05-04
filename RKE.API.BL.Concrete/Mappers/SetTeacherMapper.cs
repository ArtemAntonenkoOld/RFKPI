using RKE.API.Models.AllTeachersApiModels;
using RKE.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RKE.API.BL.Concrete.Mappers
{
    public class SetTeacherMapper
    {
        public List<Teacher> ModelToEntity(List<ResultForAllTeachersModel> entity)
        {
            List<Teacher> p = new List<Teacher>();
            foreach (var temp in entity)
            {
                p.Add(new Teacher()
                {
                   FullName=temp.full_name,
                   ApiTeacherId=temp.id,
                   Name=temp.name,
                   Position=temp.degree,
                   ShortName = temp.short_name_with_degree
                   
                });
            }
            return p;
        }
    }
}
