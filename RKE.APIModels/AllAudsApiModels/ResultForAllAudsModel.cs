using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RKE.API.Models.AllAudsApiModels
{
    public class ResultForAllAudsModel
    {
        public int id { get; set; }
        public string name { get; set; }
        public string full_name { get; set; }
        public object kpimaps_id { get; set; }
        public int building { get; set; }

    }
}
