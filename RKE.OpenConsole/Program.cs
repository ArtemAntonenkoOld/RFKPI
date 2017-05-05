using System;
using System.Threading.Tasks;

using Quartz;
using Quartz.Impl;
using Quartz.Logging;

using System.Collections.Specialized;
using RKE.API.Models.AllLessonsApiModels;
using System.Collections.Generic;
using RestSharp;

namespace RKE.OpenConsole
{
    public class Program
    {
        private static void Main(string[] args)
        {
            List<ResultForAllLessonsModel> result = new List<ResultForAllLessonsModel>();
            
            RestClient client = new RestClient("http://api.rozklad.hub.kpi.ua/lessons/?limit=10");
            for (int i=0;i<10;i++)
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

            } 
            foreach(var item in result)
            {
                Console.WriteLine(item.id);
            }
            Console.Read();
        }
    }
}