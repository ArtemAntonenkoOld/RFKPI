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
        private readonly IWeekRepository _weekRepository;
        private readonly ILessonRepository _lessonRepository;
        private readonly ITeacherRepository _teacherRepository;

        public RozkladForStudentsDataHandler(
            IGroupRepository groupRepository,
            IWeekRepository weekRepository,
            ILessonRepository lessonRepository,
            ITeacherRepository teacherRepository
         )
        {
            _groupRepository = groupRepository;
            _weekRepository = weekRepository;
            _lessonRepository = lessonRepository;
            _teacherRepository = teacherRepository;
        }

        public async Task<List<RozkladModel>> GetByGroup(string groupName)
        {

            List<Group> res = await _groupRepository.FetchByAsync(p => p.NameOfGroup == groupName);
            RozkladMapper mapper = new RozkladMapper();
            return mapper.EntityToModel(res);
        }
        public async Task<RozkladForTeachersModel> GetByNameOfTeacher(string teacherName)
        {
            List<Teacher> res = await _teacherRepository.FetchByAsync(p => p.FullName == teacherName && p.ShortName == teacherName);
            RozkladMappersForTeachers.RozkladMapper mapper = new RozkladMappersForTeachers.RozkladMapper();
            return mapper.EntityToModel(res);
        }
        

    }
}

