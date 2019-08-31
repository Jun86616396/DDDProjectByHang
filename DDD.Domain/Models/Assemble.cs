using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DDD.Domain.Models
{
    [Table("Assemble")]
    public partial class Assemble
    {
        public int AssembleId { get; set; }

        public int OrderId { get; set; }

        [Required]
        [StringLength(20)]
        public string BoxNumber { get; set; }

        public byte FinishedNumber { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime AssembleCreateTime { get; set; }

        public virtual OrderPlacing OrderPlacing { get; set; }
    }
}
