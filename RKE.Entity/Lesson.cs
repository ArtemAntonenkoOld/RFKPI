namespace RKE.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Lesson
    {
        public Lesson()
        {
            LessonGroups = new HashSet<LessonGroups>();
        }
        [Key]
        public int ApiId { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        

        public int NumberOfLesson { get; set; }

        public int? Day { get; set; }

        public int? Week { get; set; }

        public DateTime? Date { get; set; }

        public int? DisziplinApiId { get; set; }

        public int? LessonChangdId { get; set; }

        public int? TeacherApiId { get; set; }

        public int TypeOfLesson { get; set; }

        public int? AudApiId { get; set; }

        [ForeignKey("AudApiId")]
        public virtual Aud Auds{ get; set; }

        [ForeignKey("DisziplinApiId")]
        public virtual Disziplin Disziplins { get; set; }
        
        [ForeignKey("TeacherApiId")]
        public virtual Teacher Teachers { get; set; }
        public virtual ICollection<LessonGroups> LessonGroups { get; set; }
    }
}
