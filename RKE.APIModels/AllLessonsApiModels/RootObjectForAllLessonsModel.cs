using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RKE.API.Models.AllLessonsApiModels
{
    public class RootObjectForAllLessonsModel
    {
        public int count { get; set; }
        public string next { get; set; }
        public object previous { get; set; }
        public List<ResultForAllLessonsModel> results { get; set; }
    }
}
