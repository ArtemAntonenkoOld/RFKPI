using RKE.DAL.Abstract.Repositories;
using RKE.DAL.Abstract.IContextOfDatabase;
using RKE.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RKE.DAL.Concrate.Repositories
{
    public class WeekRepository:GenericRepository<Week>,IWeekRepository
    {
        public WeekRepository(IRKEContext context) : base(context)
        {

        }
    }
}
