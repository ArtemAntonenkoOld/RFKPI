using RKE.API.Models.AllLessonsApiModels;
using RKE.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RKE.API.BL.Concrete.Mappers
{
    public class SetLessonMapper
    {
        public List<Lesson> ModelToEntity(List<ResultForAllLessonsModel> entity)
        {
            List<Lesson> p = new List<Lesson>();
            foreach (var temp in entity)
            {
                p.Add(new Lesson()
                {
                    Aud = temp.rooms_full_names.FirstOrDefault(),
                    Day=temp.day,
                    IsActive=true,
                    NameOfLesson=temp.discipline_name,
                    
                });
            }
            return p;
        }
    }
}
