using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RKE.Entity;
using RKE.UIModels.RozkladModelForExternalStudents;
using RKE.UIModels.RozkladModelForStudents;

namespace RKE.BL.Concrete.RozkladMappersForStudents
{
    public class RozkladMapperForExternalStudentsRozkladMapper
    {
        public List<RozkladModelForExternalStudentsRozkladModel> EntityToModel(List<Group> entity)
        {
            RozkladMapperForExternalStudentsLessonMapper rozkladMapperForExternalStudentsLessonMapper = new RozkladMapperForExternalStudentsLessonMapper();
            List<RozkladModelForExternalStudentsRozkladModel> p = new List<RozkladModelForExternalStudentsRozkladModel>();
            foreach (var item in entity)
            {
                p.Add(new RozkladModelForExternalStudentsRozkladModel()
                {
                    NameOfGroup = item.NameOfGroup,
                    RozkladModelForExternalLessonsForExternalStudentsModel = rozkladMapperForExternalStudentsLessonMapper.EntityToModel(item.Lessons.ToList())
                });
            }
            return p;
            }


        }

    }
