using System.Collections.Generic;
using System.Linq;
using RKE.UIModels.RozkladModelForStudents;
using RKE.Entity;
using RKE.BL.Concrete.RozkladMappersForStudents;

namespace RKE.BL.Concrete.RozkladMappersForStudents
{
    public class RozkladMapperForStudentsRozkladMapper
    {
        public List<RozkladModelForStudentsRozkladModel> EntityToModel(List<Group> entity)
        {
            RozkladMapperForStudentsLessonMapper rozkladMapperForStudentsLessonMapper = new RozkladMapperForStudentsLessonMapper();
            RozkladMapperForStudentsSessionMapper rozkladMapperForStudentsSessionMapper = new RozkladMapperForStudentsSessionMapper();
            List<RozkladModelForStudentsRozkladModel> p = new List<RozkladModelForStudentsRozkladModel>();
            foreach (var item in entity)
            {
                RozkladModelForStudentsRozkladModel k = new RozkladModelForStudentsRozkladModel();
                List<Lesson> session=new List<Lesson>();
                List<Lesson> lesson = new List<Lesson>(); ;
                k.GroupName = item.NameOfGroup;
                foreach (var lessonItem in item.Lessons)
                {
                    if (lessonItem.TypeOfLesson != 5)
                    {
                        lesson.Add(lessonItem);
                    }
                    else
                    {
                        session.Add(lessonItem);
                    }
                }
                k.LessonModel = rozkladMapperForStudentsLessonMapper.EntityToModel(lesson);
                k.SessionModel = rozkladMapperForStudentsSessionMapper.EntityToModel(session);
                p.Add(k);


            }

        
            return p;
            }


        }

    }
