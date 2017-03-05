using RKE.DAL.Abstract.Repositories;
using RKE.DAL.Abstract.IContextOfDatabase;
using RKE.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RKE.DAL.Abstract.Repositories;

namespace RKE.DAL.Concrate.Repositories
{
    public class ExternalStudentGroupRepository : GenericRepository<ExternalStudentsGroup>,IExternalStudentGroupRepository
    {
        public ExternalStudentGroupRepository(IRKEContext context) : base(context)
        {

        }
    }
}
