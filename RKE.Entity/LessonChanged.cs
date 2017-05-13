namespace RKE.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    
    public partial class LessonChanged
    {
        LessonChanged()
        {
            Lesson = new HashSet<Lesson>();
        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public int NumberOfLesson { get; set; }

        public int? Day { get; set; }

        public DateTime Date { get; set; }

        public int? Week { get; set; }

        public int AudApiId{ get; set; }
        [ForeignKey("AudApiId")]
        public virtual Aud Auds { get; set; }
        public virtual ICollection<Lesson> Lesson { get; set; }
    }
}
