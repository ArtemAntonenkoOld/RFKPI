using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin;
using RKE.DAL.Concrate.ContextOfDatabase;
using RKE.Entity;

namespace RKE.Identity
{
    public class RKERoleManager: RoleManager<Role>
    {
        
            public RKERoleManager(RoleStore<Role> store)
                        : base(store)
            { }
            public static RKERoleManager Create(IdentityFactoryOptions<RKERoleManager> options,
                                                    IOwinContext context)
            {
                return new RKERoleManager(new
                        RoleStore<Role>(context.Get<RKEContext>()));
            }
        
    }
}
