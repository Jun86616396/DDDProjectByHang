using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace DDD.Domain.Models
{
    [Table("Storage")]
    public partial class Storage
    {
        public int StorageId { get; set; }

        public int OrderId { get; set; }

        public int Number { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime StorageCreateTime { get; set; }

        public virtual OrderPlacing OrderPlacing { get; set; }
    }
}
