using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DDD.Domain.Models
{
    [Table("DayFinished")]
    public partial class DayFinished
    {
        public int Id { get; set; }

        public int CollectionCount { get; set; }

        public int AssembleCount { get; set; }

        public int FistTestCount { get; set; }

        public int LastTestCount { get; set; }

        public int StorageCount { get; set; }

        [Required]
        [StringLength(15)]
        public string CreateTime { get; set; }

        public int SynchronizationFlag { get; set; }
    }
}
