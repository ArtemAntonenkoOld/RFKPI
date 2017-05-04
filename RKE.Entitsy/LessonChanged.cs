using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RKE.Entity
{
    [Table("tbLessonChanged")]
    public class LessonChanged
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("cId")]
        public int Id { get; set; }

        [Column("cComment")]
        public string Comment { get; set; }

        [Column("cIdOfUser")]
        public string UserId { get; set; }
        [ForeignKey("UserId")]
        public virtual User User { get; set; }

        [Column("cIdOfLesson")]
        public int LessonId { get; set; }
        [ForeignKey("LessonId")]
        public virtual Lesson Lesson { get; set; }

        [Column("cDateOfLesson")]
        public DateTime DateOfLesson { get; set; }
        [Column("cNumberOfLesson")]
        public int NumberOfLesson { get; set; }
    }
}
