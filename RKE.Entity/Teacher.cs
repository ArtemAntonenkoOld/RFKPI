namespace RKE.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Teacher
    {
        public Teacher()
        {
            Lessons = new HashSet<Lesson>();
        }

        [Key]
        public int ApiId { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string NameOfTeacher { get; set; }
        public string FullNameOfTeacher { get; set; }
        public string ShortNameOfTeacher { get; set; }
        public string ShortNameOfTeacherWithDegree { get; set; }
        public string Degree { get; set; }

        public virtual ICollection<Lesson> Lessons { get; set; }
        
    }
}
