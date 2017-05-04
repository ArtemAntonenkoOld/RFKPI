namespace RKE.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Lesson
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Lesson()
        {
            Groups = new HashSet<Group>();
        }
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ApiId { get; set; }

        public int NumberOfLesson { get; set; }

        public int? Day { get; set; }

        public int? Week { get; set; }

        public DateTime? Date { get; set; }

        public int? DisziplinApiId { get; set; }

        public int? LessonChangedId { get; set; }

        public int? TeacherApiId { get; set; }

        public int TypeOfLesson { get; set; }

        public int? AudApiId { get; set; }

        public virtual Aud Auds{ get; set; }

        public virtual Disziplin Disziplins { get; set; }

        public virtual LessonChanged LessonChangeds { get; set; }

        public virtual Teacher Teachers { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Group> Groups { get; set; }
    }
}
