using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RKE.Entity;
using RKE.UIModels.RozkladModelsForTeachers;

namespace RKE.BL.Concrete.RozkladMappersForTeachers
{
    public class RozkladMapperForTeachersRozkladMapper
    {
        public List<RozkladModelForTeachersRozkladModel> EntityToModel(List<Teacher> entity)
        {
            RozkladMapperForTeachersLessonMapper _lessonsMapperForStudentsLessonMapper = new RozkladMapperForTeachersLessonMapper();
            RozkladMapperForTeachersSessionMapper _sessionMapperForStudentsLessonMapper = new RozkladMapperForTeachersSessionMapper();
            RozkladMapperForTeachersExternalLessonMapper _externalLessonsMapperForStudentsLessonMapper = new RozkladMapperForTeachersExternalLessonMapper();
            List<Lesson> session = new List<Lesson>();
            List<Lesson> lesson = new List<Lesson>();
            List<Lesson> external = new List<Lesson>();
            List<RozkladModelForTeachersRozkladModel> l=new List<RozkladModelForTeachersRozkladModel>();
            foreach (var temp in entity)
            {
                RozkladModelForTeachersRozkladModel k = new RozkladModelForTeachersRozkladModel();
                foreach (var lessonItem in temp.Lessons)
                {
                    if (lessonItem.LessonGroups.FirstOrDefault().Groups.Type == 1)
                    {
                        external.Add(lessonItem);
                    }
                    
                    else if (lessonItem.TypeOfLesson != 5)
                    {
                        lesson.Add(lessonItem);
                    }
                    else
                    {
                        session.Add(lessonItem);
                    }
                }
                k.LessonModel = _lessonsMapperForStudentsLessonMapper.EntityToModel(lesson);
                k.SessionModel = _sessionMapperForStudentsLessonMapper.EntityToModel(session);
                k.ExternalModel = _externalLessonsMapperForStudentsLessonMapper.EntityToModel(external);
                k.FullName = temp.FullNameOfTeacher;
                k.ShortName = temp.ShortNameOfTeacherWithDegree;
                l.Add(k);

            }
            return l;
        }

    }
}
