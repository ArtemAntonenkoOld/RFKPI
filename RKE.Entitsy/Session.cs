using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RKE.Entity
{
    [Table("tbSession")]
    public  partial class Session
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

        [Column("cIdOfGroup")]
        public int GroupId { get; set; }
        [ForeignKey("GroupId")]
        public virtual Group Group { get; set; }

        [Column("cIdOfTeacher")]
        public int TeacherId { get; set; }
        [ForeignKey("TeacherId")]
        public virtual Teacher Teacher { get; set; }
    }
}