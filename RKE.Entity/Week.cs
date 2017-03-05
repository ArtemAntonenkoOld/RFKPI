using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RKE.Entity
{
    [Table("tbWeek")]
    public sealed class Week
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        [Column("cId")]
        public int Id { get; set; }
        public int NumberOfWeek { get; set; }
        public ICollection<Lesson> Lessons { get; set; }
    }
}