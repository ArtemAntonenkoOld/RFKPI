using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RKE.Entity
{
    [Table("LessonForExternalStudents")]
    public class LessonForExternalStudents
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        [Column("cId")]
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string NameOfLesson { get; set; }
        public string Aud { get; set; }
        public int NumberOfLesson { get; set; }
    }
}