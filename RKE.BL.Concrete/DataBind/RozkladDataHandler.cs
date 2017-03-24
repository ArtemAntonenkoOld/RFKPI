using RKE.BL.Abstract;
using RKE.UIModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RKE.BL.Concrete.Mappers;
using RKE.UIModels.RozkladModel;
using RKE.DAL.Concrate.Repositories;
using RKE.DAL.Abstract.Repositories;
using RKE.Entity;
using RKE.IOC.Common.Attributes;

namespace RKE.BL.Concrete.DataBind
{
    [BindsTo(typeof(IRozkladDataHandler))]
    public class RozkladDataHandler : IRozkladDataHandler
    {
        private readonly IGroupRepository _groupRepository;
        private readonly IWeekRepository _weekRepository;
        //private readonly ITeacherRepository _teacherRepository;
        private readonly ILessonRepository _lessonRepository;

        public RozkladDataHandler(
            IGroupRepository groupRepository,
            IWeekRepository weekRepository,
       //     ITeacherRepository teacherRepository,
            ILessonRepository lessonRepository)
        {
            _groupRepository = groupRepository;
            _weekRepository = weekRepository;
            _lessonRepository = lessonRepository;
         //   _teacherRepository = teacherRepository;
        }

        public async Task<List<RozkladModel>> GetByGroup(string groupName)
        {

            List<Group> res = await _groupRepository.FetchByAsync(p => p.NameOfGroup == groupName);
            RozkladMapper mapper = new RozkladMapper();
            return mapper.EntityToModel(res);
        }
    }
}

/*public async Task<int> GetCurrentWeek()
{
    DateTime dtNow = DateTime.Now;
    int year = dtNow.Month <= 9 ? dtNow.Year - 1 : dtNow.Year;
    DateTime startDate = new DateTime(year, 9, 1);
    List<Holidays> dbData = await _holidaysRepository.FetchByAsync(p => p.EndDate <= dtNow);
    int weekCount = 0;
    if (dbData != null)
    {
        foreach (Holidays holidayse in dbData)
        {
            TimeSpan beetween = holidayse.EndDate - holidayse.StartDate;

            weekCount += (int) (beetween.Days / 7) + 1;
        }
    }
    int result = ((int) ((dtNow - startDate).Days / 7) + 1 - weekCount) % 2;
    return result;
}
}
}

/*todo
namespace RKE.BL.Concrete.DataBind
{
public class RozkladDataHandler : IRozkladDataHandler
{
private readonly IGroupRepository _groupRepository;
public RozkladDataHandler(IGroupRepository groupRepository)
{
    _groupRepository = groupRepository;
}
public async Task<RozkladModel> GetByGroup(string groupName)
{ 
    Group res = await _groupRepository.FirstOrDefaultAsync(p => p.NameOfGroup == groupName).ti;
    
    RozkladMapper maper = new RozkladMapper();
   return maper.EntityToModel(res);
}
public async Task<List<RozkladModel>> GetByGroup(string groupName)
{
    using (RepositoryHolder scope = new RepositoryHolder())
    {
        ProductMapper mapper = new ProductMapper();
        List<ProductListItemModel> result =
            scope.ProductRepository
            .Fetch()
            .Select
                (
                    p =>
                        mapper.EntityToModel(p)
                )
           .ToList();
        return result;
    }

}


public async Task<RozkladModel> GetByGroup(string groupName,int week)
{
    return null;
}
}
}
*/
