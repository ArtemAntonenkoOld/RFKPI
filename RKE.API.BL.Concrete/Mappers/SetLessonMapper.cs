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
                Lesson e = new Lesson();
                
                    e.ApiId = temp.id;
                    e.Day = temp.day;
                    if (temp.discipline == 0)
                    {
                        e.DisziplinApiId = null;
                    }
                    else
                    {
                        e.DisziplinApiId = temp.discipline;
                    };
                    e.NumberOfLesson = temp.number;
                    e.Week = temp.week;
                    if (temp.teachers.FirstOrDefault() == 0)
                    {
                        e.TeacherApiId = null;
                    }
                    else
                    {
                        e.TeacherApiId = temp.teachers.FirstOrDefault();
                    };
                    if (temp.rooms.FirstOrDefault() == 0)
                    {
                        e.AudApiId = null;
                    }
                    else
                    {
                        e.AudApiId = temp.rooms.FirstOrDefault();
                    };
                    e.LessonGroups = _lessonGroupMapper.EntityToModel(temp.groups);
                    p.Add(e);
                }
                return p;
            }
        }
    }

