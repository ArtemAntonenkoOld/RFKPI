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
                RozkladModelForTeachersLessonModel l = new RozkladModelForTeachersLessonModel();

                    l.Day = (int)temp.Day;
                    if (temp.Auds != null)
                    {
                        l.Aud = (string)temp.Auds.NumberOfAud;
                    }
                    else {
                    l.Aud = "";
                    }
                    l.NumberOfLesson = (int)temp.NumberOfLesson;
                    l.Group = _rozkladMapperForTeachersGroupMapper.EntityToModel(temp.LessonGroups.ToList());
                    l.Type = temp.TypeOfLesson;
                    l.Week = temp.Week;
                    l.NameOfDisziplin = temp.Disziplins.NameOfDisziplin;
                p.Add(l);
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
