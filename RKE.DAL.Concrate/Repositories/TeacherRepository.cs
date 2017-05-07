using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RKE.DAL.Abstract.IContextOfDatabase;
using RKE.DAL.Abstract.IRepositories;
using RKE.Entity;
using System.Linq.Expressions;
using System.Data.Entity;

namespace RKE.DAL.Concrate.Repositories
{
    public class TeacherRepository : GenericRepository<Teacher>, ITeacherRepository
    {
        IRKEContext _context;
        public TeacherRepository(IRKEContext context) : base(context)
        {
            _context = context;
        }


    }
    
}
