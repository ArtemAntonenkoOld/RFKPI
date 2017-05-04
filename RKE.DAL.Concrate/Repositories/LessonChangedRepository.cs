using RKE.DAL.Abstract.IContextOfDatabase;
using RKE.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RKE.DAL.Abstract.IRepositories;

namespace RKE.DAL.Concrate.Repositories
{
    public class LessonChangedRepository : GenericRepository<LessonChanged>, ILessonChangedRepository
    {
        public LessonChangedRepository(IRKEContext context) : base(context)
        {

        }
    }
}
