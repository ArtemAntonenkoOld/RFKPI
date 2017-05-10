namespace RKE.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Disziplin
    {
        public Disziplin()
        {
            this.Lessons = new HashSet<Lesson>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ApiId { get; set; }

       
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string NameOfDisziplin { get; set; }

        public string FullNameOfDisziplin { get; set; }

         public virtual ICollection<Lesson> Lessons { get; set; }
        
    }
}
