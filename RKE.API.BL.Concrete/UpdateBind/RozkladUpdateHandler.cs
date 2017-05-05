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
using RKE.DAL.Abstract.IRepositories;
using RKE.API.BL.Concrete.Mappers;
using RKE.DAL.Concrate.Repositories;
using RKE.API.Models.AllTeachersApiModels;
using RKE.API.Models.AllLessonsApiModels;
using RKE.API.Models.AllAudsApiModels;
using RKE.API.Models.AllDisziplinsApiModels;
using System.Threading;

namespace RKE.API.BL.Concrete.UpdateBind
{

    [BindsTo(typeof(IRozkladUpdateHandler))]
    public class RozkladUpdateHandler: IRozkladUpdateHandler
    {
        private readonly IGroupRepository _groupRepository;
        private readonly IAudRepository _audRepository;
        private readonly IDisziplinRepository _disziplinRepository;
        private readonly ITeacherRepository _teacherRepository;
        private readonly ILessonRepository _lessonRepository;
        public RozkladUpdateHandler(
                IGroupRepository groupRepository,
                ITeacherRepository teacherRepository,
                IAudRepository audRepository,
                IDisziplinRepository disziplinRepository,
                ILessonRepository lessonRepository
             )
            {
                _disziplinRepository = disziplinRepository;
                _teacherRepository = teacherRepository;
                _groupRepository = groupRepository;
                _audRepository= audRepository;
                _lessonRepository = lessonRepository;
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
        private List<ResultForAllAudsModel> GetAllAuds()
        {
            List<ResultForAllAudsModel> result = new List<ResultForAllAudsModel>();
            RestClient client = new RestClient("http://api.rozklad.hub.kpi.ua/rooms/");
            do
            {
                var request = new RestRequest(Method.GET);

                IRestResponse<RootObjectForAllAudsModel> response2 = client.Execute<RootObjectForAllAudsModel>(request);
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
        private List<ResultForAllDisziplinsModel> GetAllDisziplins()
        {
            List<ResultForAllDisziplinsModel> result = new List<ResultForAllDisziplinsModel>();
            RestClient client = new RestClient("http://api.rozklad.hub.kpi.ua/disciplines/?limit=10");
            do
            {
                var request = new RestRequest(Method.GET);

                IRestResponse<RootObjectForAllDisziplinsModel> response2 = client.Execute<RootObjectForAllDisziplinsModel>(request);
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
        private List<ResultForAllLessonsModel> GetAllLessons()
        {
            List<ResultForAllLessonsModel> result = new List<ResultForAllLessonsModel>();
            RestClient client = new RestClient("http://api.rozklad.hub.kpi.ua/lessons/");
           
            for (int i = 0; i < 5; i++) { 
                var request = new RestRequest(Method.GET);

            IRestResponse<RootObjectForAllLessonsModel> response2 = client.Execute<RootObjectForAllLessonsModel>(request);
            if (response2.Data.next == null)
            {
                i = 10;
            };
            foreach (var item in response2.Data.results)
            {
                result.Add(item);
            }
            client = new RestClient(response2.Data.next);
        }

            return result;
        }

        public async Task SetGroups()
        {
            SetGroupMapper mapper = new SetGroupMapper();
            var groups = mapper.ModelToEntity(GetAllGroups());
            foreach (var item in groups)
            {
                
                if (await _groupRepository.GetCountAsync(p => p.ApiGroupId == item.Id)==0) {
                    await _groupRepository.AddAsync(item);
                    await _groupRepository.SaveAsync();
                }
            }
            
        }
        public async Task SetTeachers()
        {
            SetTeacherMapper mapper = new SetTeacherMapper();
            var groups = mapper.ModelToEntity(GetAllTeachers());
            foreach (var item in groups)
            {
                if (await _teacherRepository.GetCountAsync(p => p.ApiId==item.Id) == 0)
                {
                    await _teacherRepository.AddAsync(item);
                    await _teacherRepository.SaveAsync();
                }
            }
        }
        public async Task SetAuds()
        {
            SetAudsMapper mapper = new SetAudsMapper();
            var groups = mapper.ModelToEntity(GetAllAuds());
            foreach (var item in groups)
            {
                if (await _audRepository.GetCountAsync(p => p.IdOfApi == item.Id) == 0)
                {
                    await _audRepository.AddAsync(item);
                    await _audRepository.SaveAsync();
                }
            }
        }
        public async Task SetDisziplins()
        {
            SetDisziplinMapper mapper = new SetDisziplinMapper();
            var groups = mapper.ModelToEntity(GetAllDisziplins());
            foreach (var item in groups)
            {
                if (await _disziplinRepository.GetCountAsync(p => p.IdOfApi == item.Id) == 0)
                {
                    await _disziplinRepository.AddAsync(item);
                    await _disziplinRepository.SaveAsync();
                }
            }
        }
        public async Task SetLessons()
        {

            SetLessonMapper mapper = new SetLessonMapper();
            var groups = mapper.ModelToEntity(GetAllLessons());
            foreach (var item in groups)
            {
                var k = await _lessonRepository.FetchByAsync(p => p.ApiId == item.Id);
                if (k.Count == 0)
                {

                    await _lessonRepository.AddAsync(item);
                }
               
            }
            await _lessonRepository.SaveAsync();
        }
            
        }


    }

