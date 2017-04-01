using RKE.BL.Abstract;
using RKE.UIModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RKE.BL.Concrete.RozkladMappersForStudents;
using RKE.UIModels.RozkladModelForStudents;
using RKE.DAL.Concrate.Repositories;
using RKE.DAL.Abstract.Repositories;
using RKE.Entity;
using RKE.IOC.Common.Attributes;
using RKE.ViewModels.RozkladModelsForTeachers;

namespace RKE.BL.Concrete.DataBind
{
    [BindsTo(typeof(IRozkladForStudentsHandler))]
    public class RozkladForStudentsDataHandler : IRozkladForStudentsHandler
    {
       // private readonly ITeacherRepository _teacherRepository;
        private readonly IGroupRepository _groupRepository;
        private readonly ITeacherRepository _teacherRepository;

        public RozkladForStudentsDataHandler(
            IGroupRepository groupRepository,
            ITeacherRepository teacherRepository
         )
        {
            _groupRepository = groupRepository;
            _teacherRepository = teacherRepository;
        }

        public async Task<RozkladModel> GetByGroup(string groupName)
        {

            List<Group> res = await _groupRepository.FetchByAsync(p => p.NameOfGroup == groupName);
            RozkladMapper mapper = new RozkladMapper();
            List<RozkladModel> result = mapper.EntityToModel(res);
            return result.FirstOrDefault();
        }

        public async Task<RozkladForTeachersModel> GetByNameOfTeacher(string teacherName)
        {
            List<Teacher> res = await _teacherRepository.FetchByAsync(p => p.FullName == teacherName && p.ShortName == teacherName);
            RozkladMappersForTeachers.RozkladMapper mapper = new RozkladMappersForTeachers.RozkladMapper();
            List<RozkladForTeachersModel> result = mapper.EntityToModel(res);
            return result.FirstOrDefault();
        }
        

    }
}

