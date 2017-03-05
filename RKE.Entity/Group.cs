using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RKE.Entity
{
    [Table("tbGroup")]
    public sealed class Group
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        [Column("cId")]
        public int Id { get; set; }
        public string NameOfGroup { get; set; }
        public string Rozkladink { get; set; }
        public ICollection<Week> Weeks { get; set; }
        public ICollection<Session> Session { get; set; }
    }
}
