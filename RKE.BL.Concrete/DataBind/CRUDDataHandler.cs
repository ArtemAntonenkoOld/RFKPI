using RKE.BL.Abstract;
using RKE.DAL.Abstract.IRepositories;
using RKE.IOC.Common.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RKE.UIModels.CRUDLessonForExternalModels;
using RKE.BL.Concrete.CRUDMappersForExternalStudents;
using RKE.Entity;

namespace RKE.BL.Concrete.DataBind
{
    [BindsTo(typeof(ICRUDDataHandler))]
    public class CRUDDataHandler : ICRUDDataHandler
    {
        private readonly IGroupRepository _groupRepository;
        private readonly ITeacherRepository _teacherRepository;
        private readonly IAudRepository _audRepository;
        private readonly IDisziplinRepository _disziplinRepository;
        private readonly ILessonRepository _lessonRepository;
        public CRUDDataHandler(
            IGroupRepository groupRepository,
            ITeacherRepository teacherRepository,
            IAudRepository audRepository,
            IDisziplinRepository disziplinRepository,
            ILessonRepository lessonRepository
            )
        {
            _teacherRepository = teacherRepository;
            _audRepository = audRepository;
            _disziplinRepository = disziplinRepository;
            _groupRepository = groupRepository;
            _lessonRepository = lessonRepository;
        }
        public async Task<CRUDLessonForExternalModelsDataModel> GetAllInfo()
        {

            CRUDMappersForExternalStudentsDataMapper mapper = new CRUDMappersForExternalStudentsDataMapper();
            List<Group> group = await _groupRepository.FetchByAsync(p=>p.Type==1);
            List<Teacher> teacher = await _teacherRepository.FetchAsync();
            List<Aud> aud = await _audRepository.FetchAsync();
            List<Disziplin> disziplin = await _disziplinRepository.FetchAsync();

            return mapper.EntityToModel(group,teacher,aud,disziplin);
        }
        public async Task<int> SetLesson(int[] groups, int aud, int teacher, int disziplin, DateTime date)
        {
            
            CRUDMappersForExternalStudentsLessonGroupsMapper mapper = new CRUDMappersForExternalStudentsLessonGroupsMapper();
            var lg = mapper.ModelToEntity(groups);
            var k = await _lessonRepository.FetchByAsync(p =>
            p.AudApiId == aud
            && p.TeacherApiId == teacher
            && p.DisziplinApiId == disziplin
            && p.Date == date
            
           );
            int o = k.Select(p=>p.LessonGroups==lg).Count();


            if (o==0)
            {
                try
                {
                    await _lessonRepository.AddAsync(new Lesson()
                    {
                        AudApiId = aud,
                        Date = date,
                        DisziplinApiId = disziplin,
                        TeacherApiId = teacher,
                        LessonGroups = mapper.ModelToEntity(groups)
                    });
                    return 1;
                }
                catch (Exception)
                {
                    return 0;
                }
            }else
            {
                return 0;
            }
            
        }
    }
    
}