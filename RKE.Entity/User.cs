using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity.EntityFramework;

namespace RKE.Entity
{
    public class User : IdentityUser
    {
        public User()
        {
            this.LessonChanged = new HashSet<LessonChanged>();
        }
        public ICollection<LessonChanged> LessonChanged { get; set; }
    }
}
