using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RKE.API.Models.AllLessonsApiModels
{
    public class ResultForAllLessonsModel
    {
        public int id { get; set; }
        public int number { get; set; }
        public int day { get; set; }
        public int week { get; set; }
        public int type { get; set; }
        public string discipline_name { get; set; }
        public int discipline { get; set; }
        public List<string> groups_names { get; set; }
        public List<int> groups { get; set; }
        public List<string> teachers_short_names { get; set; }
        public List<int> teachers { get; set; }
        public List<string> rooms_full_names { get; set; }
        public List<object> rooms { get; set; }
        

        
    }
}
