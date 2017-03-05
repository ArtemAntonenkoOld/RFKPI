using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RKE.Entity
{
    [Table("tbExternalStudentsGroup")]
    public class ExternalStudentsGroup
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        [Column("cId")]
        public int Id { get; set; }
        [Column("cNameOfGroup")]
        public string NameOfGroup { get; set; }
        public ICollection<LessonForExternalStudents> LessonsForExternalStudents  { get; set; }
        public ICollection<Session> Session { get; set; }
    }
}