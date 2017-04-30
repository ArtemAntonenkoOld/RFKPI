using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.Identity.EntityFramework;

namespace RKE.Entity
{
    public class Role : IdentityRole
    {
        public Role() { }

        public int RoleDetailsId { get; set; }
        public string Description { get; set; }
    }
}