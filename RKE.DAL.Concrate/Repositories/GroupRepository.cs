using RKE.DAL.Abstract.IRepositories;
using RKE.DAL.Abstract.IContextOfDatabase;
using RKE.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RKE.DAL.Concrate.Repositories
{
    public class GroupRepository:GenericRepository<Group>,IGroupRepository
    {
        public GroupRepository(IRKEContext context) : base(context)
        {

        }
    }
}
