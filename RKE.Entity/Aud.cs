namespace RKE.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Aud
    {
       public Aud()
        {
            this.Lessons = new HashSet<Lesson>();
        //    this.LessonChangeds = new HashSet<LessonChanged>();
        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ApiId { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string NumberOfAud { get; set; }

       // public virtual ICollection<LessonChanged> LessonChangeds { get; set; }

        public virtual ICollection<Lesson> Lessons { get; set; }
        
    }
}
