using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DDD.Domain.Models
{
    [Table("OrderBox")]
    public partial class OrderBox
    {
        public int OrderBoxId { get; set; }

        public int OrderId { get; set; }

        [Required]
        [StringLength(20)]
        public string BoxNumber { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime OrderBoxCreateTime { get; set; }

        public virtual OrderPlacing OrderPlacing { get; set; }
    }
}
