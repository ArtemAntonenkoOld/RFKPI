using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity.EntityFramework;
using RKE.DAL.Abstract.IContextOfDatabase;
using RKE.Entity;
using RKE.IOC.Common.Attributes;

namespace RKE.DAL.Concrate.ContextOfDatabase
{

    [RequestScope]
    [BindsTo(typeof(IRKEIdentityContext))]
    public class RKEIdentityContext : IdentityDbContext<User>
    {
        public static RKEIdentityContext Create()
        {
            return new RKEIdentityContext();
        }
    }
}
