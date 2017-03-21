using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RKE.Entity
{
    [Table("tbLessonForExternalStudents")]
    public class LessonForExternalStudents
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        [Column("cId")]
        public int Id { get; set; }
        [Column("cDate")]
        public DateTime Date { get; set; }
        [Column("cNameOfLesson")]
        public string NameOfLesson { get; set; }
        [Column("cAud")]
        public string Aud { get; set; }
        [Column("cNumberOfLesson")]
        public int NumberOfLesson { get; set; }
        public Teacher Teacher { get; set; }
        public Group Group { get; set; }
    }
}