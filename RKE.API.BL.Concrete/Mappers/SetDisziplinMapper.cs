using RKE.API.Models.AllDisziplinsApiModels;
using RKE.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RKE.API.BL.Concrete.Mappers
{
    public class SetDisziplinMapper
    {
        public List<Disziplin> ModelToEntity(List<ResultForAllDisziplinsModel> entity)
        {
            List<Disziplin> p = new List<Disziplin>();
            foreach (var temp in entity)
            {
                p.Add(new Disziplin()
                {
                    FullNameOfDisziplin=temp.full_name,
                    IdOfApi=temp.id,
                    NameOfDisziplin=temp.name
                });
            }
            return p;
        }
    }
}
