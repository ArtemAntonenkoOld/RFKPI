using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RKE.API.Models;
using RKE.API.Models.AllGroupsApiModels;
using RestSharp;
using RKE.IOC.Common.Attributes;
using RKE.API.BL.Abstract;
using RKE.DAL.Abstract.Repositories;
using RKE.API.BL.Concrete.Mappers;
using RKE.DAL.Concrate.Repositories;
using RKE.API.Models.AllTeachersApiModels;
using RKE.API.Models.AllLessonsApiModels;

namespace RKE.API.BL.Concrete.UpdateBind
{

    [BindsTo(typeof(IRozkladUpdateHandler))]
    public class RozkladUpdateHandler: IRozkladUpdateHandler
    {
        private readonly IGroupRepository _groupRepository;
        private readonly ITeacherRepository _teacherRepository;
        public RozkladUpdateHandler(
                IGroupRepository groupRepository,
                ITeacherRepository teacherRepository
             )
            {
                _teacherRepository = teacherRepository;
                _groupRepository = groupRepository;
            }


        private List<ResultForAllGroupsModel> GetAllGroups()
        {
            List<ResultForAllGroupsModel> result = new List<ResultForAllGroupsModel>();
            RestClient client = new RestClient("https://api.rozklad.hub.kpi.ua/groups");
            do
            {
                var request = new RestRequest(Method.GET);
               
                IRestResponse<RootObjectForAllGroups> response2 = client.Execute<RootObjectForAllGroups>(request);
                if (response2.Data.next == null)
                {
                    break;
                };
                foreach(var item in response2.Data.results)
                {
                    result.Add(item);
                }
                client = new RestClient(response2.Data.next);
                
            } while (true);

            return result;
        }
        private List<ResultForAllTeachersModel> GetAllTeachers()
        {
            List<ResultForAllTeachersModel> result = new List<ResultForAllTeachersModel>();
            RestClient client = new RestClient("http://api.rozklad.hub.kpi.ua/teachers/");
            do
            {
                var request = new RestRequest(Method.GET);

                IRestResponse<RootObjectForAllTeachersModel> response2 = client.Execute<RootObjectForAllTeachersModel>(request);
                if (response2.Data.next == null)
                {
                    break;
                };
                foreach (var item in response2.Data.results)
                {
                    result.Add(item);
                }
                client = new RestClient(response2.Data.next);

            } while (true);

            return result;
        }
      /*  private List<ResultForAllLessonsModel> GetAllLessons()
        {
            List<ResultForAllLessonsModel> result = new List<ResultForAllLessonsModel>();
            RestClient client = new RestClient("https://api.rozklad.hub.kpi.ua/lessons/");
            do
            {
                var request = new RestRequest(Method.GET);

                IRestResponse<RootObjectForAllLessonsModel> response2 = client.Execute<RootObjectForAllLessonsModel>(request);
                if (response2.Data.next == null)
                {
                    break;
                };
                foreach (var item in response2.Data.results)
                {
                    result.Add(item);
                }
                client = new RestClient(response2.Data.next);

            } while (true);

            return result;
        }

        public async Task SetAllLessons()
        {

        }*/
        public async Task SetGroups()
        {
            SetGroupMapper mapper = new SetGroupMapper();
            var groups = mapper.ModelToEntity(GetAllGroups());
            foreach (var item in groups)
            {
                
                if ((await _groupRepository.GetByAsync(p => p.ApiGroupId == item.Id)).Count()==0) {
                    await _groupRepository.AddAsync(item);
                }
            }
            await _groupRepository.SaveAsync();
        }
        public async Task SetTeachers()
        {
            SetTeacherMapper mapper = new SetTeacherMapper();
            var groups = mapper.ModelToEntity(GetAllTeachers());
            foreach (var item in groups)
            {
                if ((await _teacherRepository.GetByAsync(p => p.ApiTeacherId==item.Id)).Count() == 0)
                {
                    await _teacherRepository.AddAsync(item);
                }
            }
            await _teacherRepository.SaveAsync();
        }
       
    }
}
