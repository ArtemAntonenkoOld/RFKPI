namespace RKE.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class LessonGroups
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int LessonId { get; set; }
        [ForeignKey("LessonId")]
        public virtual Lesson Lessons { get; set; }


        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ApiGroupId { get; set; }
        [ForeignKey("ApiGroupId")]
        public virtual Group Groups { get; set; }
    }
}
