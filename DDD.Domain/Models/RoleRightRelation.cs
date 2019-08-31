using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DDD.Domain.Models
{
    [Table("RoleRightRelation")]
    public partial class RoleRightRelation
    {
        [Key]
        public int RoleRightId { get; set; }

        public int RoleId { get; set; }

        public int RightId { get; set; }

        public virtual Right Right { get; set; }

        public virtual Role Role { get; set; }
    }
}
