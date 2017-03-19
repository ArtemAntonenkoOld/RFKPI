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
    public sealed class Group
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        [Column("cId")]
        public int Id { get; set; }
        [Column("cNameOfGroup")]
        public string NameOfGroup { get; set; }
        [Column("cRozkladLink")]
        public string RozkladLink { get; set; }
        public int Type { get; set; }
        public ICollection<LessonForExternalStudents> LessonForExternalStudents { get; set; }
        public ICollection<Week> Weeks { get; set; }
        public ICollection<Session> Session { get; set; }
    }
}
