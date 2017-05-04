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
    public class DisziplinRepository : GenericRepository<Disziplin>, IDisziplinRepository
    {
        public DisziplinRepository(IRKEContext context) : base(context)
        {

        }
    }
}
