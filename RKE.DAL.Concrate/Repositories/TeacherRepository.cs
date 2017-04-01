using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RKE.DAL.Abstract.IContextOfDatabase;
using RKE.DAL.Abstract.Repositories;
using RKE.Entity;

namespace RKE.DAL.Concrate.Repositories
{
    public class TeacherRepository : GenericRepository<Teacher>, ITeacherRepository
    {
        public TeacherRepository(IRKEContext context) : base(context)
        {

        }
    }
}
