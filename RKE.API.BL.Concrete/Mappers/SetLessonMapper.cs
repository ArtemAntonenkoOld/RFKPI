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
            SetLessonGroupMapper _lessonGroupMapper = new SetLessonGroupMapper();
            List<Lesson> p = new List<Lesson>();
            foreach (var temp in entity)
            {
                p.Add(new Lesson()
                {
                    ApiId=temp.id,
                    Day=temp.day,
                    DisziplinApiId=temp.discipline,
                    NumberOfLesson=temp.number,
                    Week = temp.week,
                    TeacherApiId=temp.teachers.FirstOrDefault(),
                    AudApiId=temp.rooms.FirstOrDefault(),
                    Groups=_lessonGroupMapper.EntityToModel(temp.groups)
                    
                 });
            }
            return p;
        }
    }
}
