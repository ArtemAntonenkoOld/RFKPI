using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RKE.BL.Abstract;
using RKE.BL.Concrete.RozkladMappersForTeachers;
using RKE.DAL.Abstract.Repositories;
using RKE.Entity;
using RKE.IOC.Common.Attributes;
using RKE.ViewModels.RozkladModelsForTeachers;

namespace RKE.BL.Concrete.DataBind
{
    [BindsTo(typeof(IRozkladForTeachersHandler))]
    public class RozkladForTeachersHandler: IRozkladForTeachersHandler
    {
        private readonly IGroupRepository _groupRepository;
        private readonly IWeekRepository _weekRepository;
        private readonly ILessonRepository _lessonRepository;
        private readonly ITeacherRepository _teacherRepository;

        public RozkladForTeachersHandler(
            IGroupRepository groupRepository,
            IWeekRepository weekRepository,
            ITeacherRepository teacherRepository,
            ILessonRepository lessonRepository)
        {
            _groupRepository = groupRepository;
            _weekRepository = weekRepository;
            _lessonRepository = lessonRepository;
            _teacherRepository = teacherRepository;
        }

        public async Task<RozkladForTeachersModel> GetByNameOfTeacher(string teacherName)
        {
            List<Teacher> res = await _teacherRepository.FetchByAsync(p => p.FullName == teacherName && p.ShortName==teacherName);
            RozkladMapper mapper = new RozkladMapper();
            return mapper.EntityToModel(res.FirstOrDefault());
        }

    }


}
