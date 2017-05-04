using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RKE.API.Models.AllGroupsApiModels
{
    public class RootObjectForAllGroups
    {
        public int count { get; set; }
        public string next { get; set; }
        public object previous { get; set; }
        public List<ResultForAllGroupsModel> results { get; set; }
    }
}
