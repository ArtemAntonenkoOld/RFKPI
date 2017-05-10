namespace RKE.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Group
    {
         public Group()
        {
            LessonGroups = new HashSet<LessonGroups>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ApiId { get; set; }

        
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string NameOfGroup { get; set; }

        public int Type { get; set; }
        

         public virtual ICollection<LessonGroups> LessonGroups { get; set; }
    }
}
