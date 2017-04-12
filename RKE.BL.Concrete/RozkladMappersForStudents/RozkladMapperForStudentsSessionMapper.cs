using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RKE.Entity;
using RKE.UIModels.RozkladModelForStudents;

namespace RKE.BL.Concrete.RozkladMappersForStudents
{
    public class RozkladMapperForStudentsSessionMapper
    {
        public List<RozkladModelForStudentsSessionModel> EntityToModel(List<Session> entity)
        {
            List < RozkladModelForStudentsSessionModel > p = new List<RozkladModelForStudentsSessionModel>();
            foreach (var temp in entity)
            {
                p.Add(new RozkladModelForStudentsSessionModel()
                {
                   Aud = temp.Aud,
                   NumberOfLesson = temp.NumberOfLesson,
                   Date = temp.Date,
                   Id = temp.Id,
                   NameOfLesson = temp.NameOfLesson

                });
            }
            return p;
        }
    }
}
