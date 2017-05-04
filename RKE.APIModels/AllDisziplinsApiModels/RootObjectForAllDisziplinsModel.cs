using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RKE.API.Models.AllDisziplinsApiModels
{
    public class RootObjectForAllDisziplinsModel
    {
        public int count { get; set; }
        public string next { get; set; }
        public object previous { get; set; }
        public List<ResultForAllDisziplinsModel> results { get; set; }
    }
}
