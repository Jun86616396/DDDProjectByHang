using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DDD.Domain.Models
{
    [Table("OrderPlacing")]
    public partial class OrderPlacing
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public OrderPlacing()
        {
            Assembles = new HashSet<Assemble>();
            Collections = new HashSet<Collection>();
            OrderBoxes = new HashSet<OrderBox>();
            Storages = new HashSet<Storage>();
        }

        [Key]
        public int OrderId { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime OrderDate { get; set; }

        [Required]
        [StringLength(20)]
        public string Type { get; set; }

        [Required]
        [StringLength(20)]
        public string PlanNo { get; set; }

        [Required]
        [StringLength(15)]
        public string FinishedProductNo { get; set; }

        [Required]
        [StringLength(15)]
        public string ProductTypeNo { get; set; }

        public int OnLineQuantity { get; set; }

        [Required]
        [StringLength(15)]
        public string SnMin { get; set; }

        [Required]
        [StringLength(15)]
        public string SnMax { get; set; }

        [StringLength(100)]
        public string LabelingRequirements { get; set; }

        [StringLength(20)]
        public string TestReport { get; set; }

        [StringLength(100)]
        public string CodingRequirements { get; set; }

        [StringLength(20)]
        public string PackingRequirement { get; set; }

        [StringLength(100)]
        public string SpecialRequirement { get; set; }

        [StringLength(20)]
        public string TestSoftConfigFile { get; set; }

        [StringLength(20)]
        public string Remark { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime CustomDemandDate { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime PlannedLaunchDate { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime PlanStorageDate { get; set; }

        public byte DaysOfProduction { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime OrderCreateTime { get; set; }

        public int OrderStorageCount { get; set; }

        [Required]
        [StringLength(1)]
        public string StorageFinishedFlag { get; set; }

        public int OrderCollectionCount { get; set; }

        public int OrderAssembleCount { get; set; }

        public int FisrtTestCount { get; set; }

        public int LastTestCount { get; set; }

        public int StorageAdvanceDays { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Assemble> Assembles { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Collection> Collections { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderBox> OrderBoxes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Storage> Storages { get; set; }
    }
}
