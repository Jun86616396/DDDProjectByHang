using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DDD.Domain.Models
{
    [Table("Right")]
    public partial class Right
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Right()
        {
            RoleRightRelations = new HashSet<RoleRightRelation>();
        }

        public int RightId { get; set; }

        [Required]
        [StringLength(20)]
        public string RightName { get; set; }

        [Required]
        [StringLength(50)]
        public string RightDesc { get; set; }

        public int ShowLevelOrder { get; set; }

        public int PID { get; set; }

        public int MenuLevel { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RoleRightRelation> RoleRightRelations { get; set; }
    }
}
