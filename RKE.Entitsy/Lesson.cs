using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RKE.Entity
{
    [Table("tbLesson")]
    public  partial class Lesson
    {
        public Lesson()
        {
            this.LessonChanged = new HashSet<LessonChanged>();
        }
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        [Column("cId")]
        public int Id { get; set; }
        [Column("cDay")]
        public int Day { get; set; }
        [Column("cNumberOfLesson")]
        public int NumberOfLesson { get; set; }
        [Column("сAud")]
        public string Aud { get; set; }
        [Column("cType")]
        public string Type { get; set; }
        [Column("cNameOfLesson")]
        public string NameOfLesson { get; set; }
        [Column("cIsActive")]
        public bool IsActive { get; set; }


        
        [Column("cIdOfTeacher")]
        public int TeacherId { get; set; }
        [ForeignKey("TeacherId")]
        public virtual Teacher Teacher { get; set; }
        [Column("cIdOfWeek")]
        public int WeekId { get; set; }
        [ForeignKey("WeekId")]
        public virtual Week Week { get; set; }
        public virtual ICollection<LessonChanged> LessonChanged { get; set; }

    }
}