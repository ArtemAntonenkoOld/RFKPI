using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RKE.Entity
{
    [Table("tbLesson")]
    public sealed class Lesson
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
        
        
    }
}