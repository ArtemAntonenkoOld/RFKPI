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
using RKE.UIModels.RozkladModelForExternalStudents;
using RKE.UIModels.RozkladModelsForTeachers;

namespace RKE.BL.Concrete.DataBind
{
    [BindsTo(typeof(IRozkladHandler))]
    public class RozkladDataHandler : IRozkladHandler
    {
        private readonly IGroupRepository _groupRepository;
        private readonly ITeacherRepository _teacherRepository;

        public RozkladDataHandler(
            IGroupRepository groupRepository,
            ITeacherRepository teacherRepository
         )
        {
            _groupRepository = groupRepository;
            _teacherRepository = teacherRepository;
        }

        public async Task<RozkladModelForStudentsRozkladModel> GetByGroup(string groupName)
        {
            List<Group> res = await _groupRepository.FetchByAsync(p => p.NameOfGroup == groupName&&p.Type==0);
            RozkladMapperForStudentsRozkladMapper mapper = new RozkladMapperForStudentsRozkladMapper();
            List<RozkladModelForStudentsRozkladModel> result = mapper.EntityToModel(res);
            return result.FirstOrDefault();
        }
        public async Task<RozkladModelForTeachersTeacherModel> GetByNameOfTeacher(string teacherName)
        {
            List<Teacher> res = await _teacherRepository.FetchByAsync(p => p.FullName == teacherName && p.ShortName == teacherName);
            RozkladMappersForTeachers.RozkladMapper mapper = new RozkladMappersForTeachers.RozkladMapper();
            List<RozkladModelForTeachersTeacherModel> result = mapper.EntityToModel(res);
            return result.FirstOrDefault();
        }
        public async Task<RozkladModelForExternalStudentsRozkladModel> GetByExternalGroup(string groupName)
        {
            List<Group> res = await _groupRepository.FetchByAsync(p => p.Type==1&&p.NameOfGroup==groupName);
            RozkladMapperForExternalStudentsRozkladMapper mapper = new RozkladMapperForExternalStudentsRozkladMapper();
            List<RozkladModelForExternalStudentsRozkladModel> result = mapper.EntityToModel(res);
            return result.FirstOrDefault();
        }

    }
}

