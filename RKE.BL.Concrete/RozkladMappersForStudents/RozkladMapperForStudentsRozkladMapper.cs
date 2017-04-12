using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RKE.Entity;
using RKE.UIModels.RozkladModelForStudents;

namespace RKE.BL.Concrete.RozkladMappersForStudents
{
    public class RozkladMapperForStudentsRozkladMapper
    {
        public List<RozkladModelForStudentsRozkladModel> EntityToModel(List<Group> entity)
        {
            RozkladMapperForStudentsWeekMapper rozkladMapperForStudentsWeekMapper = new RozkladMapperForStudentsWeekMapper();
            RozkladMapperForStudentsSessionMapper rozkladMapperForStudentsSessionMapper = new RozkladMapperForStudentsSessionMapper();
            List<RozkladModelForStudentsRozkladModel> p = new List<RozkladModelForStudentsRozkladModel>();
            foreach (var item in entity)
            {
                p.Add(new RozkladModelForStudentsRozkladModel()
                {
                    GroupName = item.NameOfGroup,
                    
                    WeekModel = rozkladMapperForStudentsWeekMapper.EntityToModel(item.Weeks.ToList()),
                    SessionModel = rozkladMapperForStudentsSessionMapper.EntityToModel(item.Session.ToList()),

                });
            }
            return p;
            }


        }

    }
