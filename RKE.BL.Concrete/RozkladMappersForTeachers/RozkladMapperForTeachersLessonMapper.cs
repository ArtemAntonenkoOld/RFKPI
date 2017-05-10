using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RKE.Entity;
using RKE.UIModels.RozkladModelsForTeachers;

namespace RKE.BL.Concrete.RozkladMappersForTeachers
{
    public class RozkladMapperForTeachersLessonMapper
    {
        public List<RozkladModelForTeachersLessonModel[][]> EntityToModel(List<Lesson> entity)
        {

            RozkladMapperForTeachersGroupMapper _rozkladMapperForTeachersGroupMapper = new RozkladMapperForTeachersGroupMapper();
            List<RozkladModelForTeachersLessonModel> p = new List<RozkladModelForTeachersLessonModel>();
            foreach (var temp in entity)
            {
                p.Add(new RozkladModelForTeachersLessonModel()
                {
                    Day = (int)temp.Day,
                    Aud = (string)temp.Auds.NumberOfAud,
                    NumberOfLesson = (int)temp.NumberOfLesson,
                    Group=_rozkladMapperForTeachersGroupMapper.EntityToModel(temp.LessonGroups.ToList()),
                    Type = temp.TypeOfLesson,
                    Week=temp.Week,
                    NameOfDisziplin=temp.Disziplins.NameOfDisziplin



                });
            }
            RozkladModelForTeachersLessonModel[][] obj = new RozkladModelForTeachersLessonModel[6][];
            RozkladModelForTeachersLessonModel[][] obj2 = new RozkladModelForTeachersLessonModel[6][];
            for (int i = 0; i < 6; i++)
            {
                obj[i] = new RozkladModelForTeachersLessonModel[7];
                obj2[i] = new RozkladModelForTeachersLessonModel[7];
            }

            foreach (var item in p)
            {
                if (item.Week == 1)
                {
                    obj[(int)item.Day - 1][item.NumberOfLesson - 1] = item;
                }
                else
                {
                    obj2[(int)item.Day - 1][item.NumberOfLesson - 1] = item;
                }
            }
            return new List<RozkladModelForTeachersLessonModel[][]> { obj,obj2};
        }

    }
}
