using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RKE.API.Models.AllTeachersApiModels
{
    public class RootObjectForAllTeachersModel
    {
        public int count { get; set; }
        public string next { get; set; }
        public object previous { get; set; }
        public List<ResultForAllTeachersModel> results { get; set; }
    }
}
