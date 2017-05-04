using RKE.API.Models.AllAudsApiModels;
using RKE.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RKE.API.BL.Concrete.Mappers
{
    public class SetAudsMapper
    {

        public List<Aud> ModelToEntity(List<ResultForAllAudsModel> entity)
        {
            List<Aud> p = new List<Aud>();
            foreach (var temp in entity)
            {
                p.Add(new Aud()
                {
                    IdOfApi=temp.id,
                    NumberOfAud =temp.name
                    
                });
            }
            return p;
        }
    }
}
