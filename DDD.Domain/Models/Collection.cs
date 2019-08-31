using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DDD.Domain.Models
{
    [Table("Collection")]
    public partial class Collection
    {
        [Key]
        public int MaterialCollectionID { get; set; }

        public int OrderID { get; set; }

        public int Number { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime CollectionCreateTime { get; set; }

        public virtual OrderPlacing OrderPlacing { get; set; }
    }
}
