using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RKE.Entity
{
    [Table("tbTeacher")]
    
    public sealed class Teacher
    {

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        [Column("cId")]
        public int Id { get; set; }
        [Column("cName")]
        public string Name { get; set; }
        [Column("cFullName")]
        public string FullName { get; set; }
        [Column("cShortName")]
        public string ShortName { get; set; }
        [Column("cPosition")]
        public string Position { get; set; }
        
        [Column("cLink")]
        public string Link { get; set; }
        
        public ICollection<Lesson> Lessons { get; set; }
        public ICollection<LessonForExternalStudents> ExternalGroup { get; set; }
        public ICollection<Session> Session { get; set; }
    }
}
