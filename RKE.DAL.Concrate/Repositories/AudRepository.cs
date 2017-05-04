using RKE.DAL.Abstract.IContextOfDatabase;
using RKE.DAL.Abstract.IRepositories;
using RKE.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RKE.DAL.Concrate.Repositories
{
    public class AudRepository : GenericRepository<Aud>, IAudRepository
    {
        public AudRepository(IRKEContext context) : base(context)
        {

        }
    }
}
