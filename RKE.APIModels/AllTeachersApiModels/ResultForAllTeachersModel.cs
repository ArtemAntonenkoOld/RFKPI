using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RKE.API.Models.AllTeachersApiModels
{
    public class ResultForAllTeachersModel
    {
        public int id { get; set; }
        public string last_name { get; set; }
        public string first_name { get; set; }
        public string middle_name { get; set; }
        public string name { get; set; }
        public string full_name { get; set; }
        public string short_name { get; set; }
        public string short_name_with_degree { get; set; }
        public string degree { get; set; }
    }
}
