using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RKE.Entity
{
    [Table("tbLesson")]
    public  partial class Lesson
    {
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

        public virtual Teacher Teacher { get; set; }
        public virtual Week Week { get; set; }

        
    }
}