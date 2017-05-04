using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RKE.Entity
{
    [Table("tbGroup")]
    public  partial class Group
    {
        public Group()
        {
            this.LessonsForExternalStudents =new HashSet<LessonForExternalStudents>();
            this.Weeks =new HashSet<Week>();
            this.Session = new HashSet<Session>();
        }
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        [Column("cId")]
        public int Id { get; set; }
        [Column("cNameOfGroup")]
        public string NameOfGroup { get; set; }

        [Column("cApiGroupId")]
        public int ApiGroupId { get; set; }
        public int Type { get; set; }

        public virtual ICollection<LessonForExternalStudents> LessonsForExternalStudents { get; set; }
        public virtual ICollection<Week> Weeks { get; set; }
        public virtual ICollection<Session> Session { get; set; }
    }
}
