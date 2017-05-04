using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RKE.Entity
{
    [Table("tbWeek")]
    public  partial class Week
    {
        public Week()
        {
            this.Lessons = new HashSet<Lesson>();
           
        }
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        [Column("cId")]
        public int Id { get; set; }
        [Column("cNumberOfWeek")]
        public int NumberOfWeek { get; set; }

        public virtual ICollection<Lesson> Lessons { get; set; }

        [Column("cIdOfGroup")]
        public int GroupId { get; set; }
        [ForeignKey("GroupId")]
        public virtual Group Group { get; set; }
    }
}